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
using Microsoft.Office.Interop.Excel;

namespace ParsingExcelData
{ 
    enum Letters {A = 1, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z};
    public partial class MainWindow : Form
    {
        int SheetNumber;
        int lustNumRow;
        int lustNumColumn;
        int firstNumCell;

        public MainWindow()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //We subscribe to the event handler methods
            this.Resize += WindowResize;
            progressBarLoadData.Location = new System.Drawing.Point { X = 10, Y = 40 };
            progressBarLoadData.Width = this.Width - 40;

            dataGridViewExcel.Location = new System.Drawing.Point { X = 10, Y = 60 };
            dataGridViewExcel.Size = new Size
            {
                Height = this.Height - 105,
                Width = this.Width - 35
            };
        }

        private void WindowResize(object sender, EventArgs e)
        {
            progressBarLoadData.Location = new System.Drawing.Point { X = 10, Y = 40 };
            progressBarLoadData.Width = this.Width - 40;

            dataGridViewExcel.Location = new System.Drawing.Point { X = 10, Y = 60 };
            dataGridViewExcel.Size = new Size
            {
                Height = this.Height - 105,
                Width = this.Width - 35
            };
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog browseFile = new OpenFileDialog())
            {
                browseFile.Filter = "xls|*.xls|xlsx|*.xlsx";
                browseFile.InitialDirectory = Directory.GetCurrentDirectory();
                browseFile.Title = "Select excel file";
                DialogResult result = browseFile.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if(result == DialogResult.OK)
                {
                    dataGridViewExcel.DataSource = GetExcelData(browseFile);
                }
            }
        }

        private System.Data.DataTable GetExcelData(OpenFileDialog browseFile)
        {
            var MyExcel = new Microsoft.Office.Interop.Excel.Application();
            Workbook MyWorkBook = MyExcel.Workbooks.Open(browseFile.FileName, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            //Choosing first sheet
            SheetNumber = 1;
            Worksheet MyWorkSheeet = MyWorkBook.Sheets[SheetNumber];

            firstNumCell = 1;
            lustNumRow = MyWorkSheeet.UsedRange.Rows.Count;
            lustNumColumn = MyWorkSheeet.UsedRange.Columns.Count;
            progressBarLoadData.Minimum = firstNumCell;
            progressBarLoadData.Maximum = lustNumRow;

            labelPath.Text = browseFile.FileName;

            var table = new System.Data.DataTable();

            for (int i = firstNumCell; i < lustNumRow; i++)
            {
                if (i == 1)
                {
                    string letter;
                    object name;
                    for (int j = firstNumCell; j <= lustNumColumn; j++)
                    {
                        letter = Enum.ToObject(typeof(Letters), j).ToString();
                        Range range = MyWorkSheeet.get_Range(letter + i.ToString(), letter + i.ToString());
                        name = range.Cells.Value;
                        if (range.Cells.Value != null) table.Columns.Add(range.Cells.Value);
                        else table.Columns.Add();
                    }
                }
                else
                {
                    Range range;
                    List<object> rowList = new List<object>();
                    string letter;
                    for (int j = firstNumCell; j <= lustNumColumn; j++)
                    {
                        letter = Enum.ToObject(typeof(Letters), j).ToString();
                        range = MyWorkSheeet.get_Range(letter + i.ToString(), letter + i.ToString());
                        rowList.Add(range.Columns.Value);
                    }
                    table.Rows.Add(rowList.ToArray());
                }
                progressBarLoadData.Value = i;
                System.Windows.Forms.Application.DoEvents();
            }
            MyExcel.Quit();
            return table;
        }

        private void progressBarLoadData_Click(object sender, EventArgs e)
        {
            progressBarLoadData.Value = firstNumCell;
        }
    }
}
