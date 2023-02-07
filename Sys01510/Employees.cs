using DataModels;
using Sys01510.Class;
using Sys01510.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sys01510
{
    public partial class Employees : Form
    {
        _sqlite _Sqlite = new _sqlite();
        _func _Func = new _func();

        public Employees()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            GetEmpAll();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            GetEmpAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //FEdit frm = new FEdit();
            //frm.Render();
            //frm.ShowDialogWithMask();
            //if (frm.IsOK)
            //{
            //    ShowSuccessDialog(frm.Person.ToString());
            //}

            //frm.Dispose();
        }

        /// <summary>
        /// 取得所有員工名單
        /// </summary>
        private void GetEmpAll()
        {
            using (var db = new MisDB())
            {
                var query =
                    (from c in db.Employees
                     select c).ToList();
                List<_employee> data = new List<_employee>();
                foreach (var item in query)
                {
                    _employee temp = new _employee();
                    temp.Id = Convert.ToInt32(item.Id);
                    temp.Name = item.Name;
                    temp.Title = item.Title;
                    temp.Team = item.Team;
                    temp.PCId = item.PCId;
                    temp.Ip = item.Ip;
                    temp.Extension = item.Extension;
                    data.Add(temp);
                }
                DataTable OutputTable = _Func.empToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    dgv_employee.DataSource = OutputTable;
                });
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var id = txt_id.Text.Trim();
            var name = txt_name.Text.Trim();
            var pcid = txt_pcid.Text.Trim();
            var title = cmb_title.Text.Trim();
            var team = cmb_team.Text.Trim();
            var ip = txt_ip.Text.Trim();
            var extension = txt_extension.Text.Trim();

            using (var db = new MisDB())
            {
                var query =
                    (from c in db.Employees
                     where  c.Id.ToString().Contains(id) && c.Name.Contains(name)
                     select c).ToList();
                List<_employee> data = new List<_employee>();
                foreach (var item in query)
                {
                    _employee temp = new _employee();
                    temp.Id = Convert.ToInt32(item.Id);
                    temp.Name = item.Name;
                    temp.Title = item.Title;
                    temp.Team = item.Team;
                    temp.PCId = item.PCId;
                    temp.Ip = item.Ip;
                    temp.Extension = item.Extension;
                    data.Add(temp);
                }
                DataTable OutputTable = _Func.empToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    dgv_employee.DataSource = OutputTable;
                });
            }
        }
    }
}
