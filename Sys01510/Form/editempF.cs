using DataModels;
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
    public partial class editempF : Form
    {
        Employee empData;
        int id_; 
        public editempF(Employee _Employee)
        {
            InitializeComponent();
            empData = _Employee;
            txt_id.Text = empData.Id.ToString();
            txt_name.Text = empData.Name;
            txt_pcid.Text = empData.PCId;
            txt_extension.Text = empData.Extension;
            txt_ip.Text = empData.Ip;
            cmb_team.Text = empData.Team;
            cmb_title.Text = empData.Title;

            id_ = Convert.ToInt32(empData.Id);
        }

        private void editempF_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _sqlite _Sqlite = new _sqlite();
            _employee employee = new _employee();
            var id = txt_id.Text.Trim();
            var name = txt_name.Text.Trim();
            var pcid = txt_pcid.Text.Trim();
            var title = cmb_title.Text.Trim();
            var team = cmb_team.Text.Trim();
            var ip = txt_ip.Text.Trim();
            var extension = txt_extension.Text.Trim();

            employee.Id = Convert.ToInt32(id);
            employee.Name = name;
            employee.Title = title;
            employee.Team = team;
            employee.PCId = pcid;
            employee.Ip = ip;
            employee.Extension = extension;

            if (_Sqlite.EmployeeDataUpdate(_path.db, "employees", _sql_header.Employee, employee,id_))
            {
                MessageBox.Show("修改成功", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失敗", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
