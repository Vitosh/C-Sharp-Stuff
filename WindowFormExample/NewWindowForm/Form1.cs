using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace NewWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "Please, select a file.";
            lblPath.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excel = null;
            excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbook wkb = null;

            wkb = Open(excel, lblPath.Text);            
            Excel.Range searchedRange = excel.get_Range("A1", "XFD1048576");
            Excel.Range currentFind = searchedRange.Find(tbInput.Text);
            string displayResult = "";

            if (currentFind != null)
            {
                displayResult = "Found at \ncolumn - " + currentFind.Column + 
                                            "\nrow - " + currentFind.Row;
            }
            else
            {
                displayResult = "The searched string \"" + tbInput.Text +
                        "\" is not found.";
            }
            lblResult.Text = displayResult;
            wkb.Close(true);
            excel.Quit();
        }

        public static Excel.Workbook Open(Excel.Application excelInstance,
                        string fileName, bool readOnly = false, bool editable = true,
                        bool updateLinks = true)
        {
            Excel.Workbook book = excelInstance.Workbooks.Open(
                fileName, updateLinks, readOnly,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, editable, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            return book;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = choofdlog.FileName;
                lblResult.Text = "File is selected. Now enter a word and press the \"GO\" button.";      
            }
        }
    }
}
