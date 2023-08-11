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
    public partial class addserverF : Form
    {
        public addserverF()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _sqlite _Sqlite = new _sqlite();
            List<_server> data = new List<_server>();
            _server server = new _server();
            var name = txt_name.Text.Trim();
            var ip = txt_ip.Text.Trim();
            var account = txt_account.Text.Trim();
            var password = txt_pwd.Text.Trim();
            var remark = txt_remark.Text.Trim();

            server.Name = name;
            server.Ip = ip;
            server.Account = account;
            server.Password = password;
            server.Remark = remark;
            data.Add(server);

            if (_Sqlite.ServerDataAdd(_path.db, "server", _sql_header.Server, data))
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
