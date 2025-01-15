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
    public partial class AccountF : Form
    {
        _sqlite _Sqlite = new _sqlite();
        _func _Func = new _func();
        MisDB db = new MisDB();
        int tab_index;
        public AccountF()
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
            switch (tab_index)
            {
                case 0:
                    addempF addempF = new addempF();
                    addempF.ShowDialog();
                    GetEmpAll();
                    break;
                case 1:
                    addserverF addserverF = new addserverF();
                    addserverF.ShowDialog();
                    GetServerAll();
                    break;
                case 2:
                    addothersF addothersF = new addothersF();
                    addothersF.ShowDialog();
                    GetOthersAll();
                    break;
            }
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
        /// <summary>
        /// 取得所有伺服器名單
        /// </summary>
        private void GetServerAll()
        {
            using (var db = new MisDB())
            {
                var query =
                    (from c in db.Servers
                     select c).ToList();
                List<_server> data = new List<_server>();
                foreach (var item in query)
                {
                    _server temp = new _server();
                    temp.Name = item.Name;
                    temp.Ip = item.Ip;
                    temp.Account = item.Account;
                    temp.Password = item.Password;
                    temp.Remark = item.Remark;
                    data.Add(temp);
                }
                DataTable OutputTable = _Func.serverToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    dgv_server.DataSource = OutputTable;
                });
            }
        }
        /// <summary>
        /// 取得所有其他名單
        /// </summary>
        private void GetOthersAll()
        {
            using (var db = new MisDB())
            {
                var query =
                    (from c in db.Others
                     select c).ToList();
                List<_others> data = new List<_others>();
                foreach (var item in query)
                {
                    _others temp = new _others();
                    temp.Name = item.Name;
                    temp.type = item.Type;
                    temp.Account = item.Account;
                    temp.Password = item.Password;
                    temp.Remark = item.Remark;
                    data.Add(temp);
                }
                DataTable OutputTable = _Func.othersToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    dgv_others.DataSource = OutputTable;
                });
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            var id = txt_id_e.Text.Trim();
            var name = txt_name_e.Text.Trim();
            var pcid = txt_pcid_e.Text.Trim();
            var title = cmb_title_e.Text.Trim();
            var team = cmb_team_e.Text.Trim();
            var ip = txt_ip_e.Text.Trim();
            var extension = txt_extension_e.Text.Trim();

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
            txt_id_e.Clear();
            txt_ip_e.Clear();
            txt_name_e.Clear();
            txt_pcid_e.Clear();
            cmb_team_e.Clear();
            cmb_title_e.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            switch (tab_index)
            {
                case 0:
                    string idList_emp = string.Empty;
                    // 取得選取rowID
                    foreach (DataGridViewRow row in dgv_employee.SelectedRows)
                    {
                        idList_emp += $"{row.Cells[0].Value},";
                    }
                    idList_emp = idList_emp.TrimEnd(',');
                    _Sqlite.EmployeeDataDelete(_path.db, _path.db_employee, idList_emp);

                    GetEmpAll();
                    break;
                case 1:
                    string Ip_server = string.Empty;
                    // 取得選取rowID
                    foreach (DataGridViewRow row in dgv_server.SelectedRows)
                    {
                        Ip_server += $"{row.Cells[1].Value},";
                    }
                    Ip_server = Ip_server.TrimEnd(',');
                    _Sqlite.ServerDataDelete(_path.db, _path.db_server, Ip_server);

                    GetServerAll();
                    break;
                case 2:
                    string Name_others = string.Empty;
                    // 取得選取rowName
                    foreach (DataGridViewRow row in dgv_others.SelectedRows)
                    {
                        Name_others += $"{row.Cells[0].Value},";
                    }
                    Name_others = Name_others.TrimEnd(',');
                    _Sqlite.OthersDataDelete(_path.db, _path.db_others, Name_others);

                    GetOthersAll();
                    break;
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            switch (tab_index)
            {
                case 0:
                    var id = Convert.ToInt32(dgv_employee.Rows[dgv_employee.SelectedIndex].Cells[0].Value);
                    var query = (from c in db.Employees where c.Id == id select c).FirstOrDefault();

                    editempF editempF = new editempF(query);
                    editempF.ShowDialog();

                    GetEmpAll();
                    break;
                case 1:
                    var ip = dgv_server.Rows[dgv_server.SelectedIndex].Cells[1].Value.ToString();
                    var query_server = (from c in db.Servers where c.Ip == ip select c).FirstOrDefault();

                    editserverF editserverF = new editserverF(query_server);
                    editserverF.ShowDialog();

                    GetServerAll();
                    break;
                case 2:
                    var name = dgv_others.Rows[dgv_others.SelectedIndex].Cells[0].Value.ToString();
                    var query_others = (from c in db.Others where c.Name == name select c).FirstOrDefault();

                    editothersF editothersF = new editothersF(query_others);
                    editothersF.ShowDialog();

                    GetOthersAll();
                    break;
            }

        }

        private void btn_search_s_Click(object sender, EventArgs e)
        {
            var name = txt_name_s.Text.Trim();
            var ip = txt_ip_s.Text.Trim();
            var account = txt_account_s.Text.Trim();
            var password = txt_password_s.Text.Trim();
            var remark = txt_remark_s.Text.Trim();
            using (var db = new MisDB())
            {
                var query =
                    (from c in db.Servers
                     where c.Name.ToString().Contains(name) && c.Ip.Contains(ip) && c.Account.Contains(account) && c.Password.Contains(password)
                     && c.Remark.Contains(remark)
                     select c).ToList();
                List<_server> data = new List<_server>();
                foreach (var item in query)
                {
                    _server temp = new _server();
                    temp.Name = item.Name;
                    temp.Ip = item.Ip;
                    temp.Account = item.Account;
                    temp.Password = item.Password;
                    temp.Remark = item.Remark;
                    data.Add(temp);
                }
                DataTable OutputTable = _Func.serverToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    dgv_server.DataSource = OutputTable;
                });
            }
        }

        private void uiTabControl1_Click(object sender, EventArgs e)
        {
            // tab_index 0(同仁) 1(伺服器) 2(其他)
            tab_index = this.uiTabControl1.SelectedIndex;
            switch (tab_index)
            {
                case 0:
                    GetEmpAll();
                    break;
                case 1:
                    GetServerAll();
                    break;
                case 2:
                    GetOthersAll();
                    break;
            }
        }

        private void btn_clear_s_Click(object sender, EventArgs e)
        {
            txt_name_s.Clear();
            txt_ip_s.Clear();
            txt_account_s.Clear();
            txt_password_s.Clear();
            txt_remark_s.Clear();
        }

        private void btn_search_o_Click(object sender, EventArgs e)
        {
            var name = txt_name_o.Text.Trim();
            var type = txt_type_o.Text.Trim();
            var account = txt_account_o.Text.Trim();
            var password = txt_password_o.Text.Trim();
            var remark = txt_remark_o.Text.Trim();
            using (var db = new MisDB())
            {
                var query =
                    (from c in db.Others
                     where c.Name.ToString().Contains(name) && c.Type.Contains(type) && c.Account.Contains(account) && c.Password.Contains(password)
                     && c.Remark.Contains(remark)
                     select c).ToList();
                List<_others> data = new List<_others>();
                foreach (var item in query)
                {
                    _others temp = new _others();
                    temp.Name = item.Name;
                    temp.type = item.Type;
                    temp.Account = item.Account;
                    temp.Password = item.Password;
                    temp.Remark = item.Remark;
                    data.Add(temp);
                }
                DataTable OutputTable = _Func.othersToView(data);
                this.Invoke((MethodInvoker)delegate
                {
                    dgv_others.DataSource = OutputTable;
                });
            }
        }

        private void btn_delete_o_Click(object sender, EventArgs e)
        {
            txt_name_o.Clear();
            txt_type_o.Clear();
            txt_account_o.Clear();
            txt_password_o.Clear();
            txt_remark_o.Clear();
        }
    }
}
