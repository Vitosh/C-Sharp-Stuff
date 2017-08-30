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

    public partial class Form1 : Form
    {
        public string[] FilesToGenerate;
        public string DeleteSheetName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strPath = Path.GetFullPath(Directory.GetCurrentDirectory());
            lblPath.Text = strPath;
            lblPathFromButton.Text = String.Empty;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strFiles = General.GenerateFilePath(true);
                lvPaths.Items.Clear();

                foreach (var item in strFiles)
                {
                    lvPaths.Items.Add(item);
                    //lblPathFromButton.Text += '\n' + item;
                }

                FilesToGenerate = strFiles;
                lblPathFromButton.ForeColor = Color.BlueViolet;
            }

            catch (Exception ex)
            {
                lblPathFromButton.Text = ex.ToString();
            }
        }

        private void txtBoxRemoveSheet_TextChanged(object sender, EventArgs e)
        {
            lblRemoveSheetName.Text = txtBoxRemoveSheet.Text;
            DeleteSheetName = lblRemoveSheetName.Text;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelTricks xlTricks = new ExcelTricks();
                xlTricks.ExcelTricksRun(FilesToGenerate, DeleteSheetName);
                lblReport.Text = xlTricks.DeletedFilesInfo;
            }

            catch (Exception ex)
            {
                lblPathFromButton.Text = ex.ToString();
            }

        }

        private void lblPathFromButton_Click(object sender, EventArgs e)
        {

        }
    }
}