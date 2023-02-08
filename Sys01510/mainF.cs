using Sys01510.Class;
using Sys01510.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sys01510
{
    public partial class mainF : Form
    {
        _sqlite _Sqlite = new _sqlite();
        public mainF()
        {
            InitializeComponent();

            // 建立資料庫
            if (!File.Exists(_path.db))
                _Sqlite.CreateDatabase(_path.db);
        }

        private void uiHeaderButton6_Click(object sender, EventArgs e)
        {

        }

        private void hbtn_database_Click(object sender, EventArgs e)
        {
            Process DbOpener = new Process();
            DbOpener.StartInfo.FileName = $@"{Application.StartupPath}/mis.db";
            DbOpener.Start();
        }

        private void hbtn_test_Click(object sender, EventArgs e)
        {
            _excel excel = new _excel();
            _employee _Employee = new _employee();
            var data = excel.ReadExcel(@"D:\478646資料檔\Desktop\電腦清單(20221213).xlsx");
            string insertString = "";
            if (_Sqlite.EmployeeDataAdd(_path.db, _path.db_employee, _sql_header.Employee, data))
            {
                Console.WriteLine("Finish");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private void hbtn_employees_Click(object sender, EventArgs e)
        {
            EmployeesF employees = new EmployeesF();
            employees.Show();
        }
    }
}
