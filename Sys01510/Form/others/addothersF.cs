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
    public partial class addothersF : Form
    {
        public addothersF()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _sqlite _Sqlite = new _sqlite();
            List<_others> data = new List<_others>();
            _others others = new _others();
            var name = txt_name.Text.Trim();
            var type = txt_type.Text.Trim();
            var account = txt_account.Text.Trim();
            var password = txt_pwd.Text.Trim();
            var remark = txt_remark.Text.Trim();

            others.Name = name;
            others.type = type;
            others.Account = account;
            others.Password = password;
            others.Remark = remark;
            data.Add(others);

            if (_Sqlite.OthersDataAdd(_path.db, "others", _sql_header.Others, data))
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
    }
}
