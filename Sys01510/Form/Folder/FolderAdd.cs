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
    public partial class FolderAdd : Form
    {
        string type = null;
        public FolderAdd(string Type)
        {
            InitializeComponent();
            type = Type;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _sqlite _Sqlite = new _sqlite();
            List<_folder> data = new List<_folder>();
            _folder folder = new _folder();
            var Item = txt_itemName.Text.Trim();
            var Path = txt_itemPath.Text.Trim();
            var Fre = "Frequent";
            if (type =="temp")
            {
                Fre = "temp";
            }
            

            folder.Item = Item;
            folder.Path = Path;
            folder.Fre = Fre;
            data.Add(folder);

            
            if (_Sqlite.FolderDataAdd(_path.db, "folder", _sql_header.Folder, data))
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
