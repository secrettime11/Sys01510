﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys01510.Model
{
    public class _sql_header
    {
        public static List<string> Employee = new List<string> { "Id", "Name", "Team", "Title", "PCId", "Ip", "Extension" }; 
        public static List<string> Server = new List<string> { "Name", "Ip", "Account", "Password", "Remark" }; 
    }
}
