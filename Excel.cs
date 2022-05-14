using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Windows.Forms;

namespace QA_Projects
{
    internal class Excel
    {
        Range xlRange;
        long lastRow;
        string path = "";
        _Excel.Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
            xlRange = (Range)ws.Cells[ws.Rows.Count, 1];
            lastRow = (long)xlRange.get_End(XlDirection.xlUp).Row;
            lastRow++;
        }
        public bool CheckInExcel(int col, string name)
        {
            bool flag = true;
            int i = 2;
            string value = null;
            while (flag)
            {
                value = ws.Cells[i, col].Value;
                if (value == null)
                {
                    flag = false;
                    return false;
                }

                if (ws.Cells[i, col].Value.GetType() != typeof(string))
                {
                    value = ws.Cells[i, col].Value.ToString();
                }

                if (value == name)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
        public void WriteInExcel(int col,int row, string name)
        {
            if (row < 0)
            {
                ws.Cells[lastRow, col].Value = name;
                lastRow++;
            }
            else
            {
                ws.Cells[row, col].Value = name;
            }
        }
        public void WriteRangeInExcel(int col, string[] names)
        {
            Range range = (Range)ws.Range[ws.Cells[lastRow, 1], ws.Cells[lastRow, col]];
            range.Value2 = names;
            lastRow++;
        }
        public string ReadExcel(int col, int row)
        {                        
            if (ws.Cells[row, col].Value.GetType() != typeof(string))
            {
                return ws.Cells[row, col].Value.ToString();
            }
            return ws.Cells[row, col].Value; 
        }


        public void Close()
        {
            wb.Save();
            wb.Close();
        }
        public void Open()
        {
            wb = excel.Workbooks.Open(path);
        }
        public void Save()
        {
            wb.Save();
        }
        public void Saveas(string path)
        {
            wb.SaveAs(path);
        }

    }
}
