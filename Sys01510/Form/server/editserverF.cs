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
    public partial class editserverF : Form
    {

        Server serverData;
        string ip_ = string.Empty;
        public editserverF(Server _server)
        {
            InitializeComponent();
            serverData = _server;
            txt_name.Text = serverData.NAME;
            txt_ip.Text = serverData.Ip;
            txt_account.Text = serverData.Account;
            txt_pwd.Text = serverData.Password;
            txt_remark.Text = serverData.Remark;

            ip_ = serverData.Ip;
        }

        private void editserverF_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _sqlite _Sqlite = new _sqlite();
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

            if (_Sqlite.ServerDataUpdate(_path.db, _path.db_server, _sql_header.Server, server, ip_))
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
