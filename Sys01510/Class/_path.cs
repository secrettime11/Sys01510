using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sys01510.Model
{
    public static class _path
    {
        public static string db = $@"{Application.StartupPath}\mis.db";
        public const string db_employee = "employees";
        public const string db_server = "server";
        public const string db_others = "others";
        public const string db_folder = "folder";
    }
}
