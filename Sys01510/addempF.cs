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
    public partial class addempF : Form
    {
        public addempF()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _sqlite _Sqlite = new _sqlite();
            List<_employee> data = new List<_employee>();
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
            data.Add(employee);

            if (_Sqlite.EmployeeDataAdd(_path.db, "employees", _sql_header.Employee, data))
            {
                MessageBox.Show("新增成功", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                MessageBox.Show("新增失敗", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addempF_Load(object sender, EventArgs e)
        {

        }
    }
}
