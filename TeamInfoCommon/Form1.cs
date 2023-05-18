using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace TeamInfoCommon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            openFD.Filter = @"C:\Users\cammaranol\source\repos\Excel\team_info_common.csv";
            openFD.ShowDialog();
            strFileName = openFD.FileName;

            if(strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                xlWorksheet = (Worksheet)xlWorkbook.Worksheets["team_info_common"];
                xlRange = xlWorksheet.UsedRange;

                int i = 0;

                for(xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    dgvTeamInfo.Rows.Add(i,
                                         xlRange.Cells[xlRow, 1],
                                         xlRange.Cells[xlRow, 2],
                                         xlRange.Cells[xlRow, 3],
                                         xlRange.Cells[xlRow, 4],
                                         xlRange.Cells[xlRow, 5],
                                         xlRange.Cells[xlRow, 6],
                                         xlRange.Cells[xlRow, 7],
                                         xlRange.Cells[xlRow, 8],
                                         xlRange.Cells[xlRow, 9],
                                         xlRange.Cells[xlRow, 10],
                                         xlRange.Cells[xlRow, 11],
                                         xlRange.Cells[xlRow, 12],
                                         xlRange.Cells[xlRow, 13],
                                         xlRange.Cells[xlRow, 14],
                                         xlRange.Cells[xlRow, 15],
                                         xlRange.Cells[xlRow, 16],
                                         xlRange.Cells[xlRow, 17],
                                         xlRange.Cells[xlRow, 18],
                                         xlRange.Cells[xlRow, 19],
                                         xlRange.Cells[xlRow, 20],
                                         xlRange.Cells[xlRow, 21]);
                }

            }
        }

        private void dgvTeamInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}