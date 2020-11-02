using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace WordSplitter.CustomClasses
{
    class SplitByBookmark
    {
        private string SourceDocument { get; set; }
        private string DestinationFolder { get; set; }
        private void DeleteIfExist(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    SummaryForm.AddSummaryRow("Existing file deleted.");
                }
            }
            catch(Exception ex)
            {
                ResponseBoxes.ShowExceptionBox(ex);
                SummaryForm.AddSummaryRow("Exception: " + ex.Message);
            }
        }

        private List<string> Names = new List<string>();
        private Summary SummaryForm;
        private bool showFiles = false;
        int startPageAt = 1;
        public bool isKeepPages { get; set; }
        public bool canSavePDF { get; set; }


        public bool SplitDocument(string SourceDocument, string DestinationFolder, List<string> Names, Summary summryForm, bool ifFileOpen, bool keepNums, bool pdf)
        {
            this.SourceDocument = SourceDocument;
            this.DestinationFolder = DestinationFolder;
            this.SummaryForm = summryForm;
            showFiles = ifFileOpen;
            isKeepPages = keepNums;
            canSavePDF = pdf;

            foreach (var item in Names)
            {
                this.Names.Add(item);
            }

            if (ReadBookmarks())
                return true;

            return false;
        }

        private bool ReadBookmarks()
        {
            try
            {
                var app = new Application();
                //app.Visible = true;
                app.Visible = false;

                SummaryForm.AddSummaryRow("Trying to open Document: " + SourceDocument);
                var doc = app.Documents.Open(SourceDocument, ReadOnly: true);
                SummaryForm.AddSummaryRow("Document Opened Successfully!");

                int BookmarkCount = doc.Bookmarks.Count;
                SummaryForm.AddSummaryRow("Bookmarks Counted");


                if (ValidateFileNamesCount(BookmarkCount))
                {
                    List<int> Starting = new List<int>();
                    int start = 0;
                    int end = 0;
                    string name = "";

                    List<Bookmark> bookMarkList = new List<Bookmark>();

                    Bookmarks books = doc.Bookmarks;

                    foreach (Bookmark bo in books)
                    {
                        bookMarkList.Add(bo);
                    }

                    foreach (Bookmark item in bookMarkList.OrderBy(x => x.Start))
                    {
                        Starting.Add(item.Range.Start);
                    }

                    SummaryForm.AddSummaryRow("All Bookmarks Read.");

                    float top = doc.PageSetup.TopMargin;
                    float right = doc.PageSetup.RightMargin;
                    float bottom = doc.PageSetup.BottomMargin;
                    float left = doc.PageSetup.LeftMargin;
                    
                    for (int i = 0; i < Starting.Count; i++)
                    {
                        SummaryForm.AddNewLIne();
                        SummaryForm.AddSummaryRow("Working on file number: "+ (i+1).ToString());
                        start = Starting[i];

                        if (Starting.Count > i + 1)
                            end = Starting[i + 1];
                        else
                            end = -1;

                        if (i < Names.Count)
                            name = Names[i];
                        else
                            name = (i + 1).ToString();

                        try
                        {
                            CreateDoc(doc, start, end, app, name, top, right, bottom, left);
                        }
                        catch(Exception ex)
                        {
                            ResponseBoxes.ShowExceptionBox(ex);
                            SummaryForm.AddSummaryRow("Exception: " + ex.Message);
                        }    
                    }
                    doc.Close();


                    app.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                    SummaryForm.AddSummaryRow("Process completed sucessfully!!!");
                    return true;
                }
                doc.Close();


                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                SummaryForm.AddSummaryRow("Source document closed.");
            }
            catch (Exception ex)
            {
                ResponseBoxes.ShowExceptionBox(ex);
                SummaryForm.AddSummaryRow("Exception: " + ex.Message);
            }
            SummaryForm.AddSummaryRow("Process failed.");
            return false;
        }

        private void CreateDoc(Document doc, int start, int end, Application app, string Name, float top, float right, float bottom, float left)
        {
            string fileName = DestinationFolder + Name ;
            string wordFile = fileName + ".docx";

            DeleteIfExist(wordFile);

            Range NewRange = doc.Range();
            NewRange.Start = start;

            if (end == -1)
                NewRange.End = doc.Characters.Last.End;
            else
                NewRange.End = end;

            var page = doc.Range(NewRange.Start, NewRange.End);

            page.Select();
            page.Copy();
            SummaryForm.AddSummaryRow("Creating New document.");
            var doc2 = app.Documents.Add();
            doc2.Range().Paste();
            
            doc2.PageSetup.LeftMargin = left;
            doc2.PageSetup.RightMargin = right;
            doc2.PageSetup.TopMargin = top;
            doc2.PageSetup.BottomMargin = bottom;

            KeepPageNumbers(doc2);

            doc2.SaveAs(wordFile);
            SummaryForm.AddSummaryRow("Word Creation Successful!!");
            SummaryForm.AddSummaryRow("File saved: " + wordFile);

            if (canSavePDF)
                SavePDF(doc2, fileName);

            doc2.Close();
            SummaryForm.AddSummaryRow("New document saved");

            if(showFiles)
            {
                Application ap = new Application();
                Document document = ap.Documents.Open(fileName);
                ap.WindowState = WdWindowState.wdWindowStateMaximize;
                ap.Visible = true;                
            }
        }

        private void KeepPageNumbers(Document doc2)
        {
            HeaderFooter header = doc2.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary];
            header.PageNumbers.RestartNumberingAtSection = true;
            header.PageNumbers.ShowFirstPageNumber = true;
            header.PageNumbers.NumberStyle = WdPageNumberStyle.wdPageNumberStyleArabic;
            header.PageNumbers.Add(WdPageNumberAlignment.wdAlignPageNumberCenter, true);
            header.PageNumbers.StartingNumber = startPageAt;

            HeaderFooter footer = doc2.Sections[1].Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary];
            footer.Range.Delete();
            //header.LinkToPrevious = false;
            if (isKeepPages)
            {
                WdStatistic PagesCountStat = WdStatistic.wdStatisticPages;
                int PagesCount = doc2.ComputeStatistics(PagesCountStat);
                startPageAt += PagesCount;
            }
        }

        private bool ValidateFileNamesCount(int count)
        {
            int NamesListCount = Names.Count;
            int difference = Math.Abs(NamesListCount - count);

            if (NamesListCount < count)
            {
                ResponseBoxes.ShowErrorBox("The file provided has " + count.ToString() + " bookmarks, please add " + difference.ToString() + " more FileName(s).");
                SummaryForm.AddSummaryRow("Less Files names provided.");
                return false;
            }
            else if (NamesListCount > count)
            {
                ResponseBoxes.ShowErrorBox("The file provided has " + count.ToString() + " bookmarks, please remove " + difference.ToString() + " FileName(s).");
                SummaryForm.AddSummaryRow("Extra File names provided.");
                return false;
            }
            SummaryForm.AddSummaryRow("Bookmarks and filenames count match.");
            return true;
        }


        private void SavePDF(Document doc, string filename)
        {
            try
            {
                string pdfFile = filename + ".pdf";
                DeleteIfExist(pdfFile);

                doc.SaveAs2(pdfFile, WdExportFormat.wdExportFormatPDF);

                SummaryForm.AddSummaryRow("PDF Creation Successful!!");
                SummaryForm.AddSummaryRow("File saved: " + pdfFile);
            }
            catch(Exception ex)
            {
                ResponseBoxes.ShowExceptionBox(ex);
                SummaryForm.AddSummaryRow("Exception: " + ex.Message);
            }
        }

    }
}
