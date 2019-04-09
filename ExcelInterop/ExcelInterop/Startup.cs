namespace ExcelTest
{
    using System;
    using Excel = Microsoft.Office.Interop.Excel;

    public class Startup
    {
        const string filePath = @"C:\Users\gropc\Desktop\Sample.xlsx";

        static void Main()
        {
            Excel.Application excel = new Excel.Application { Visible = true, EnableAnimations = false };
            Excel.Workbook wkb = Open(excel, filePath);

            foreach (Excel.Worksheet wks in wkb.Worksheets)
            {
                int lastRowA = LastRowPerColumn(1, wks);
                int lastRowB = LastRowPerColumn(2, wks);
                int lastRowC = LastRowPerColumn(3, wks);
                Console.WriteLine($"{lastRowA} - {lastRowB} - {lastRowC}");
            }

            wkb.Close(true);
            excel.Quit();
        }

        static int LastRowPerColumn(int column, Excel.Worksheet wks)
        {
            int lastRow = LastRowTotal(wks);
            while (((wks.Cells[lastRow, column]).Text == "") && (lastRow != 1))
            {
                lastRow--;
            }
            return lastRow;
        }

        static int LastRowTotal(Excel.Worksheet wks)
        {
            Excel.Range lastCell = wks.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            return lastCell.Row;
        }

        static Excel.Workbook Open(Excel.Application excelInstance,
            string fileName, bool readOnly = false,
            bool editable = true, bool updateLinks = true)
        {
            return excelInstance.Workbooks.Open(fileName, updateLinks, readOnly);
        }
    }
}