using System;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


class LooperMain
{
    static void Main()
    {
        string strPath = Path.GetFullPath(Directory.GetCurrentDirectory());
        string[] strFiles = Directory.GetFiles(strPath);
        Excel.Application excel = null;
        bool bMakeOnce = true;
        string strReportName = "Report.xlsx";

        int intFirstLine = 1;
        int intLastColumn = 5;
        int lastRow;
        int lastRowReport;
        int intTotalRows;

        Excel.Workbook wkbReport = null;
        string strWkbReportPath;

        excel = new Excel.Application();
        excel.Visible = true;

        foreach (string strFile in strFiles)
        {
            if (strFile.Contains(strReportName))
            {
                Console.WriteLine(strReportName + " is deleted.");
                File.Delete(strFile);
            }
        }

        foreach (string strFile in strFiles)
        {
            if ((strFile.Contains(strReportName)) || !(strFile.Contains("xls")))
            {
                continue;
            }

            Console.WriteLine(strFile);
            Excel.Workbook wkb = null;
            Excel.Worksheet sheet = null;
            Excel.Worksheet sheetReport = null;
            Excel.Range rngLastReport = null;
            Excel.Range rngToCopy = null;

            wkb = Open(excel, strFile);
            System.Threading.Thread.Sleep(3000);

            if (bMakeOnce)
            {
                bMakeOnce = false;
                strWkbReportPath = wkb.Path + "\\" + strReportName;
                wkb.SaveAs(strWkbReportPath);
                wkb.Close();
                wkbReport = Open(excel, strWkbReportPath);
            }
            else
            {
                sheetReport = wkbReport.Worksheets[1];
                sheet = wkb.Worksheets[1];

                intTotalRows = sheet.Rows.Count;
                lastRow = sheet.Cells[intTotalRows, 1].End(Excel.XlDirection.xlUp).Row;
                lastRowReport = sheetReport.Cells[intTotalRows, 1].End(Excel.XlDirection.xlUp).Row;

                rngToCopy = sheet.Range[sheet.Cells[intFirstLine, 1], sheet.Cells[lastRow, intLastColumn]];
                int size = rngToCopy.Rows.Count;
                rngLastReport = sheetReport.Range[sheetReport.Cells[lastRowReport + 1, 1], sheetReport.Cells[lastRowReport + 1 + size, intLastColumn]];

                rngToCopy.Copy(rngLastReport);
                wkb.Close(false);
            }
        }
        wkbReport.Close(true);
        excel.Quit();
        Console.WriteLine("Finished!");
    }

    public static Excel.Workbook Open(Excel.Application excelInstance, string fileName, bool readOnly = false, bool editable = true, bool updateLinks = true)
    {
        Excel.Workbook book = excelInstance.Workbooks.Open(
            fileName, updateLinks, readOnly,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, editable, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);
        return book;
    }
}
