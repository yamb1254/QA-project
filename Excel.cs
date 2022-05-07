using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace QA_Projects
{
    internal class Excel
    {
        string path = "";
        _Excel.Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel(string path,int sheet)
        {
            this.path = path;   
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
        public bool CheckInExcel(int col,string name)
        {
            
            bool flag = true;
            int i = 2;
            while (flag)
            {
                    if(ws.Cells[i,col] == name)
                    {
                       return true;
                    }
                    else if(ws.Cells[i, col].Value == null)
                    {
                        flag = false;
                    }
                    i++;  
            }
            return false;
        }
        public void WriteInExcel(int col , string name)
        {
            bool flag = true;
            int i = 2;
            while (flag)
            {
                if (ws.Cells[i, col].Value == null)
                {
                    ws.Cells[i, col].Value = name;
                    flag = false;
                }
                i++;
            }
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
