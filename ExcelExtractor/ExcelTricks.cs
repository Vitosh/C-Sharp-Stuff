using System;
using System.Threading;
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
    public class ExcelTricks
    {
        private string deletedFilesInfo;
        public string DeletedFilesInfo
        {
            get
            {
                return this.deletedFilesInfo;
            }
            set
            {
                this.deletedFilesInfo += value + '\n';
            }
        }

        public void ExcelTricksRun(string[] strFiles, string strDeleteSheet)
        {
            Excel.Application excel = null;
            Excel.Workbook wkb = null;
            Excel.Worksheet wks = null;

            excel = new Excel.Application();
            excel.Visible = false;

            foreach (string strFile in strFiles)
            {
                wkb = General.OpenExcelFile(excel, strFile);
                Thread.Sleep(1000);

                for (int i = wkb.Worksheets.Count; i > 0; i--)
                {
                    wks = wkb.Worksheets[i];
                    if (wks.Name== strDeleteSheet)
                    {
                        DeletedFilesInfo = wkb.Name + " => " + wks.Name;
                        wks.Delete();
                    }
                }
                wkb.Close(true);
            }
            excel.Quit();
        }
    }
}