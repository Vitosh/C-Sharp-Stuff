using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

class MainClass
{
    static void Main()
    {
        string strPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
        string[] strFiles = Directory.GetFiles(strPath);
        Excel.Application excel = null;
        bool bMakeOnce = true;
        string strReportName = "Report.xlsx";
        int intFirstLine = 10;
        int intLastColumn = 50;
        int lastRow;
        int lastRowReport;

        Excel.Workbook wkbReport = null;
        string strWkbReportPath;
        int n = 0;

        excel = new Excel.Application();
        excel.Visible = true;

        foreach (string strFile in strFiles)
        {
            if (strFile.Contains(strReportName))
            {
                continue;
            }
            Console.WriteLine(strFile);
            Excel.Workbook wkb = null;
            Excel.Worksheet sheet = null;
            Excel.Worksheet sheetReport = null;
            Excel.Range rngLast = null;
            Excel.Range rngLastReport = null;
            Excel.Range rngToCopy = null;
            Excel.Range rngDestination = null;


            wkb = Open(excel, strFile);
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
                n++;
                rngLastReport = sheetReport.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                rngLast = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                rngToCopy = sheet.Range[sheet.Cells[intFirstLine, 1], sheet.Cells[rngLast.Row, intLastColumn]];
                int size = rngToCopy.Rows.Count;
                Console.WriteLine(size);

                rngDestination = sheetReport.Range[sheetReport.Cells[200 * n, 1], sheetReport.Cells[200 * n + size, intLastColumn]];

                rngToCopy.Copy(rngDestination);
                wkb.Close(false);
            }
        }
        wkbReport.Close(true);
        excel.Quit();
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
    //public static Excel.Workbook OpenBook(Excel.Application excelInstance, string fileName, bool readOnly = false, bool editable = true, bool updateLinks = true)
    //{
    //    Excel.Workbook book = excelInstance.Workbooks.Open(
    //        fileName, updateLinks, readOnly,
    //        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
    //        Type.Missing, editable, Type.Missing, Type.Missing, Type.Missing,
    //        Type.Missing, Type.Missing);
    //    return book;
    //}
}
