using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data;

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
        public Excel(string path,int sheet)
        {
            this.path = path;   
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
            xlRange = (Range)ws.Cells[ws.Rows.Count, 1];
            lastRow = (long)xlRange.get_End(XlDirection.xlUp).Row;
            lastRow++;
        }
        public bool CheckInExcel(int col,string name)
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

                if(value == name)
                {
                       return true;
                }
                i++;  
            }
            return false;
        }
        public void WriteInExcel(int col , string name)
        {
            ws.Cells[lastRow, col].Value = name;
            lastRow++;
        }
        public void WriteRangeInExcel(int col, string[] names)
        {
            Range range = (Range)ws.Range[ws.Cells[lastRow, 1],ws.Cells[lastRow, col]];
            range.Value2 = names;
            lastRow++;
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

    }
}
