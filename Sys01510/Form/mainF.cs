using DataModels;
using Sunny.UI;
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
        TextBox[] txtObj = new TextBox[20];
        public mainF()
        {
            InitializeComponent();

            // 建立資料庫
            if (!File.Exists(_path.db))
                _Sqlite.CreateDatabase(_path.db);

            ShowFolder();
        }
        private void hbtn_database_Click(object sender, EventArgs e)
        {
            Process DbOpener = new Process();
            DbOpener.StartInfo.FileName = $@"{Application.StartupPath}/mis.db";
            DbOpener.Start();
        }

        private void hbtn_test_Click(object sender, EventArgs e)
        {
            //_excel excel = new _excel();
            //_employee _Employee = new _employee();
            //var data = excel.ReadExcel(@"D:\478646資料檔\Desktop\電腦清單(20221213).xlsx");
            //if (_Sqlite.EmployeeDataAdd(_path.db, _path.db_employee, _sql_header.Employee, data))
            //    Console.WriteLine("Finish");
            //else
            //    Console.WriteLine("False.");
        }

        private void hbtn_employees_Click(object sender, EventArgs e)
        {
            AccountF employees = new AccountF();
            employees.Show();
        }

        private void hbtn_calendar_Click(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {

        }

        private void mainF_Load(object sender, EventArgs e)
        {

        }

        #region 資料夾快捷
        private void btn_freadd_Click(object sender, EventArgs e)
        {
            FolderAdd folder = new FolderAdd("Fre");
            folder.ShowDialog();
            ShowFolder();
        }
        private void btn_tempadd_Click(object sender, EventArgs e)
        {
            FolderAdd folder = new FolderAdd("temp");
            folder.ShowDialog();
            ShowFolder();
        }
        private void lib_frequent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 獲取雙擊位置的索引
            int index = lib_frequent.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                // 獲取雙擊的項目
                var selectedItem = lib_frequent.Items[index];

                using (var db = new MisDB())
                {
                    var query =
                        (from c in db.Folders
                         where c.Item == selectedItem.ToString()
                         select c.Path).FirstOrDefault();
                    Process.Start("explorer.exe", query);
                }
            }
        }
        private void lib_temp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 獲取雙擊位置的索引
            int index = lib_temp.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                // 獲取雙擊的項目
                var selectedItem = lib_temp.Items[index];

                using (var db = new MisDB())
                {
                    var query =
                        (from c in db.Folders
                         where c.Item == selectedItem.ToString()
                         select c.Path).FirstOrDefault();
                    Process.Start("explorer.exe", query);
                }
            }
        }
        private void btn_freremove_Click(object sender, EventArgs e)
        {
            var selectedItem = lib_frequent.SelectedItem;
            _Sqlite.FolderDataDelete(_path.db, "folder", selectedItem.ToString());
            ShowFolder();
        }
        private void btn_tempremove_Click(object sender, EventArgs e)
        {
            var selectedItem = lib_temp.SelectedItem;
            _Sqlite.FolderDataDelete(_path.db, "folder", selectedItem.ToString());
            ShowFolder();
        }
        private void ShowFolder()
        {
            lib_frequent.Items.Clear();
            lib_temp.Items.Clear();
            using (var db = new MisDB())
            {
                var query =
                    (from c in db.Folders
                     select c).ToList();
                List<_folder> data = new List<_folder>();
                foreach (var item in query)
                {
                    if (item.Fre == "Frequent")
                    {
                        lib_frequent.Items.Add(item.Item);
                    }
                    else
                    {
                        lib_temp.Items.Add(item.Item);
                    }
                }
            }
        }
        #endregion
    }
}
