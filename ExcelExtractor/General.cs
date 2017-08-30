using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelExtractor
{
    public static class General
    {
        public static string NotSelectedAnything = "You have not selected anything!";

        public static string[] GenerateFilePath(bool blnIsMultiselect = false, bool blnFilterExcel = true)
        {
            OpenFileDialog ofdObject = new OpenFileDialog();
            ofdObject.Multiselect = blnIsMultiselect;

            if (blnFilterExcel)
            {
                ofdObject.Filter = "Excel files | *.xls; *.xlsx; *.xlsm; *xlsb";
            }

            string [] strReturn = new string[1] {NotSelectedAnything};

            if (ofdObject.ShowDialog() == DialogResult.OK)
            {
                strReturn = ofdObject.FileNames;
            }
            return strReturn;
        }

        public static Excel.Workbook OpenExcelFile(Excel.Application excelInstance, string fileName, bool readOnly = false, bool editable = true, bool updateLinks = true)
        {
            Excel.Workbook book = excelInstance.Workbooks.Open(
                fileName, updateLinks, readOnly,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, editable, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            return book;
        }
    }
}