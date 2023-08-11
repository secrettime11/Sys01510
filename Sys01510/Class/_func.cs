using Sys01510.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys01510.Class
{
    public class _func
    {
        public DataTable empToView(List<_employee> result)
        {
            DataTable dataTable = new DataTable();
            if (result.Count > 0)
            {
                // Add column
                foreach (var item in _sql_header.Employee)
                    dataTable.Columns.Add(item);

                int rowC = 0;
                foreach (var item in result)
                {
                    dataTable.Rows.Add();
                    dataTable.Rows[rowC][0] = item.Id;
                    dataTable.Rows[rowC][1] = item.Name;
                    dataTable.Rows[rowC][2] = item.Team;
                    dataTable.Rows[rowC][3] = item.Title;
                    dataTable.Rows[rowC][4] = item.PCId;
                    dataTable.Rows[rowC][5] = item.Ip;
                    dataTable.Rows[rowC][6] = item.Extension;
                    rowC++;
                }
            }
            return dataTable;
        }
        public DataTable serverToView(List<_server> result)
        {
            DataTable dataTable = new DataTable();
            if (result.Count > 0)
            {
                // Add column
                foreach (var item in _sql_header.Server)
                    dataTable.Columns.Add(item);

                int rowC = 0;
                foreach (var item in result)
                {
                    dataTable.Rows.Add();
                    dataTable.Rows[rowC][0] = item.Name;
                    dataTable.Rows[rowC][1] = item.Ip;
                    dataTable.Rows[rowC][2] = item.Account;
                    dataTable.Rows[rowC][3] = item.Password;
                    dataTable.Rows[rowC][4] = item.Remark;
                    rowC++;
                }
            }
            return dataTable;
        }
    }
}
