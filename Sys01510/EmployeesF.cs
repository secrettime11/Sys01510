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
    public partial class EmployeesF : Form
    {
        _sqlite _Sqlite = new _sqlite();
        _func _Func = new _func();
        MisDB db = new MisDB();
        public EmployeesF()
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
            addempF addempF = new addempF();
            addempF.ShowDialog();

            GetEmpAll();
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
                     where c.Id.ToString().Contains(id) && c.Name.Contains(name) && c.PCId.Contains(pcid) && c.Title.Contains(title)
                     && c.Team.Contains(team) && c.Ip.Contains(ip) && c.Extension.Contains(extension)
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_ip.Clear();
            txt_name.Clear();
            txt_pcid.Clear();
            cmb_team.Clear();
            cmb_title.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string idList = string.Empty;
            // 取得選取rowID
            foreach (DataGridViewRow row in dgv_employee.SelectedRows)
            {
                idList += $"{row.Cells[0].Value},";
            }
            idList = idList.TrimEnd(',');
            _Sqlite.EmployeeDataDelete(_path.db, _path.db_employee, idList);

            GetEmpAll();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //List<_employee> data = new List<_employee>();

            //for (int rows = 0; rows < dgv_employee.Rows.Count - 1; rows++)
            //{
            //    _employee temp = new _employee();
            //    temp.Id = Convert.ToInt32(dgv_employee.Rows[rows].Cells[0].Value.ToString());
            //    temp.Name = dgv_employee.Rows[rows].Cells[1].Value.ToString();
            //    temp.Team = dgv_employee.Rows[rows].Cells[2].Value.ToString();
            //    temp.Title = dgv_employee.Rows[rows].Cells[3].Value.ToString();
            //    temp.PCId = dgv_employee.Rows[rows].Cells[4].Value.ToString();
            //    temp.Ip = dgv_employee.Rows[rows].Cells[5].Value.ToString();
            //    temp.Extension = dgv_employee.Rows[rows].Cells[6].Value.ToString(); ;
            //    data.Add(temp);
            //}
            var id = Convert.ToInt32(dgv_employee.Rows[dgv_employee.SelectedIndex].Cells[0].Value);
            var query = (from c in db.Employees where c.Id == id select c).FirstOrDefault();

            editempF editempF = new editempF(query);
            editempF.ShowDialog();
        }
    }
}
