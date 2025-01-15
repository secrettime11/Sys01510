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
    public partial class editothersF : Form
    {
        Others othersData;
        string name_ = string.Empty;
        public editothersF(Others _others)
        {
            InitializeComponent();
            othersData = _others;
            txt_name.Text = othersData.Name;
            txt_type.Text = othersData.Type;
            txt_account.Text = othersData.Account;
            txt_pwd.Text = othersData.Password;
            txt_remark.Text = othersData.Remark;

            name_ = _others.Name;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _sqlite _Sqlite = new _sqlite();
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

            if (_Sqlite.OthersDataUpdate(_path.db, _path.db_others, _sql_header.Others, others, name))
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
