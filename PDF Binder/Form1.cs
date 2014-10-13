using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PDF_Binder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            progBar.Visible = false;
        }

        /* return the file name header for file name that fits the pattern string */
        private string extractPattern(string myString, string pattern)
        {
            string output = null;
            //Regex rx = new Regex(@"(\w:[\s-_\w\d\\]+)" + pattern + @"\d+.pdf"); // need to change to .pdf
            Regex rx = new Regex(@"(\w:[^<>:\/|?*]+)" + pattern + @"\d+.(?i)pdf(?-i)");
            MatchCollection matches = rx.Matches(myString);


            if (matches.Count > 0)
            {
                Console.WriteLine(matches.Count);
                string myMatch = matches[0].Groups[1].ToString();
                Console.WriteLine(myMatch);
                output = myMatch;
                //MessageBox.Show(matches[0].ToString());                
            }
            else
            {
                output = "-1";
            }
            //output = matches[0].ToString();
            return output;
        }

        /* return the index number at the end of the file name */
        private int getEndNumber(string text, string pattern)
        {
            int output = -1;

            Regex rx = new Regex(@"(\w:[^<>:\/|?*]+)" + pattern + @"(\d+).pdf");
            MatchCollection matches = rx.Matches(text);

            if (matches.Count > 0)
            {
                Console.WriteLine(matches.Count);
                string myMatch = matches[0].Groups[2].ToString();
                Console.WriteLine(myMatch);
                output = int.Parse(myMatch);                
            }
            return output;            
        }

        /* Combine pdf files in myList into the output file */
        int combinePDF(List<string> myList, string outputFile)
        {

            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage;
            string outputPdfPath = outputFile;
            string k = "abc";
            int b = k.Length;
            
            sourceDocument = new Document();
            pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

            // Open document 
            sourceDocument.Open();
            try
            {
                foreach (string item in myList)
                {
                    reader = new PdfReader(item);
                    int pages = reader.NumberOfPages;

                    //Add pages of current file
                    for (int i = 1; i <= pages; i++)
                    {
                        importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                        pdfCopyProvider.AddPage(importedPage);
                    }

                    reader.Close();
                }

                sourceDocument.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return 1;
        }
        /* Delete files in myList */
        void deleteFiles(List<string> myList)
        {
            try
            {
                foreach (string item in myList)
                {
                    File.Delete(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abtForm = new AboutForm();
            abtForm.ShowDialog();
            
        }

        private void btnSrcFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDiag = new FolderBrowserDialog();
            folderDiag.Description = "Select the source folder";
            if (folderDiag.ShowDialog() == DialogResult.OK)
            {                
                txtSrcFolder.Text = folderDiag.SelectedPath;
            }
        }

        private void btnTgtFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDiag = new FolderBrowserDialog();
            folderDiag.Description = "Select the source folder";
            if (folderDiag.ShowDialog() == DialogResult.OK)
            {
                txtTgtFolder.Text = folderDiag.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            progBar.Value = 0;
            progBar.Visible = true;


            //combinePDF(tempList);
            string endPattern = txtEndPattern.Text;
            string sourcePath = txtSrcFolder.Text;
            string targetPath = txtTgtFolder.Text;
            string fileNameBase = "";

            // Sanitize targetPath
            if (!targetPath.EndsWith(@"\"))
            {
                targetPath += @"\";
            }

            // Sanity check
            if (String.IsNullOrEmpty(sourcePath) || String.IsNullOrEmpty(targetPath))
            {
                MessageBox.Show("Target path or source path cannot be empty!");
                return;
            }
            else if (String.IsNullOrEmpty(endPattern))
            {
                MessageBox.Show("End pattern cannot be empty!");
                return;
            }

            List<string> fileList = new List<string>();

            string[] filesInFolder = Directory.GetFiles(sourcePath);

            int fileCount = filesInFolder.Count();

            progBar.Minimum = 0;
            progBar.Maximum = fileCount;
            progBar.Step = 1;


            int counter = 0;

            // Handle each file in the files folder 
            foreach (string fileName in filesInFolder)
            {
                counter++;

                string extract = extractPattern(fileName, endPattern);

                if (fileNameBase.Length <= 0)
                {
                    if (extract != "-1") // make sure we found pattern.
                    {
                        fileNameBase = extract;
                        fileList.Add(fileName);
                    }
                }
                else
                {
                    if (extract != "-1")
                    {
                        // If the base file name is the same, add the file name to list for combine later
                        if (fileNameBase == extract)
                        {
                            fileList.Add(fileName);
                        }
                        else // If the base file name is different, a new file encountered, combine the previous fileList
                        {
                            // combine PDF for current fileList
                            int indx = fileNameBase.LastIndexOf(@"\");
                            fileNameBase = targetPath + fileNameBase.Substring(indx + 1);

                            // Sort the fileList in ascending order of the end index number
                            var newList = from item in fileList
                                          orderby getEndNumber(item, endPattern)
                                          select item;
                            fileList = newList.ToList();

                            combinePDF(fileList, fileNameBase + ".pdf");
                            deleteFiles(fileList);

                            // New file name base
                            fileList.Clear();
                            fileList.Add(fileName);
                            fileNameBase = extract;
                        }
                    }
                }

                // Update progress bar
                progBar.PerformStep();
            }

            // combine the last fileList if it exists
            if (fileList.Count > 0)
            {
                //combine PDF for current fileList
                int indx = fileNameBase.LastIndexOf(@"\");
                fileNameBase = targetPath + fileNameBase.Substring(indx + 1);

                // Sort the fileList in ascending order of the end index number
                var newList = from item in fileList
                              orderby getEndNumber(item, endPattern)
                              select item;
                fileList = newList.ToList();

                combinePDF(fileList, fileNameBase + ".pdf");
                deleteFiles(fileList);
            }

            progBar.Visible = false;
            //finally indicate work is done !            
            MessageBox.Show("Done !");
        }
    }
}
