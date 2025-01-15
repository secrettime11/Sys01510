using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys01510.Model
{
    class _sqlite
    {
        public SQLiteConnection OpenConnection(string database)
        {
            var conntion = new SQLiteConnection()
            {
                ConnectionString = $@"Data Source={database};Version=3;New=False;Compress=True;"
            };
            ConShutdown(conntion);
            conntion.Open();
            return conntion;
        }
        /// <summary>建立新資料庫</summary>
        /// <param name="database">資料庫名稱</param>
        public void CreateDatabase(string database)
        {
            var connection = new SQLiteConnection()
            {
                ConnectionString = $"Data Source={database};Version=3;New=True;Compress=True;"
            };
            connection.Open();
            ConShutdown(connection);
        }
        /// <summary>建立新資料表</summary>
        /// <param name="database">資料庫名稱</param>
        /// <param name="sqlCreateTable">建立資料表的 SQL 語句</param>
        public bool CreateTable(string database, string sqlCreateTable)
        {
            var connection = OpenConnection(database);
            //connection.Open();
            var command = new SQLiteCommand(sqlCreateTable, connection);
            var mySqlTransaction = connection.BeginTransaction();
            try
            {
                command.Transaction = mySqlTransaction;
                command.ExecuteNonQuery();
                mySqlTransaction.Commit();
            }
            catch (Exception)
            {
                mySqlTransaction.Rollback();
                return false;
            }
            ConShutdown(connection);
            return true;
        }
        /// <summary>新增\修改\刪除資料</summary>
        /// <param name="database">資料庫名稱</param>
        /// <param name="sqlManipulate">資料操作的 SQL 語句</param>
        public bool Manipulate(string database, string sqlManipulate)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectString()))
            {
                connection.Open();
                var command = new SQLiteCommand(sqlManipulate, connection);
                var mySqlTransaction = connection.BeginTransaction();
                try
                {
                    command.Transaction = mySqlTransaction;
                    command.ExecuteNonQuery();
                    mySqlTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    mySqlTransaction.Rollback();
                    return false;
                }
                ConShutdown(connection);
            }
        }
        /// <summary>讀取資料</summary>
        /// <param name="database">資料庫名稱</param>
        /// <param name="sqlQuery">資料查詢的 SQL 語句</param>
        /// <returns></returns>
        public DataTable GetDataTable(string database, string sqlQuery)
        {
            var connection = OpenConnection(database);
            var dataAdapter = new SQLiteDataAdapter(sqlQuery, connection);
            var myDataTable = new DataTable();
            var myDataSet = new DataSet();
            myDataSet.Clear();
            dataAdapter.Fill(myDataSet);
            myDataTable = myDataSet.Tables[0];
            if (connection.State == ConnectionState.Open) connection.Close();
            return myDataTable;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="datapath">database</param>
        /// <param name="header_">header list</param>
        /// <param name="data_">data list</param>
        public void Add(List<string> datapath, List<string> header_, Dictionary<string, string> data_, string insertstring)
        {
            int header_count = header_.Count();
            int counter = 1;
            // 建立 SQLite 資料庫
            if (!File.Exists(datapath[0]))
            {
                CreateDatabase(datapath[0]);
                // 建立資料表 TestTable
                var createtablestring = $@"CREATE TABLE {datapath[1]} (";

                foreach (var header in header_)
                {
                    if (counter == header_count)
                        createtablestring += $"{header} VARCHAR(32));";
                    else
                        createtablestring += $"{header} VARCHAR(32),";
                    counter++;
                }
                CreateTable(datapath[0], createtablestring);
            }

            // FINAL STRING WHICH IS GOING TO SEND TO SQLITE
            foreach (var data in data_)
            {
                counter = 1;

                insertstring += $@"INSERT INTO {datapath[1]} (";
                foreach (var header in header_)
                {
                    if (counter == header_count)
                        insertstring += $"{header})";
                    else
                        insertstring += $"{header}, ";
                    counter++;
                }
                insertstring += $" VALUES ('{data.Key}', ";

                string[] value = data.Value.Split(new string[] { "__" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < value.Count(); i++)
                {
                    if (i == value.Count() - 1)
                        insertstring += $"'{value[i]}');" + Environment.NewLine;
                    else
                        insertstring += $"'{value[i]}', ";
                }

            }
            // 插入資料到 TestTable 表中
            Manipulate(datapath[0], insertstring);
        }
        /// <summary>
        /// 檢查資料表存不存在 True = 存在
        /// </summary>
        /// <param name="database">database</param>
        /// <param name="tableName">table name</param>
        /// <returns></returns>
        public bool CheckDatatable(string tableName)
        {
            var connection = OpenConnection(_path.db);
            SQLiteCommand mDbCmd = connection.CreateCommand();
            mDbCmd.CommandText = $"SELECT COUNT(*) FROM sqlite_master where type='table' and name='{tableName}';";
            if (0 == Convert.ToInt32(mDbCmd.ExecuteScalar()))
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                return false;
            }
            else
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                return true;
            }
        }
        /// <summary>
        /// 檢查資料表有沒該日期資料 false = 沒有
        /// </summary>
        /// <param name="database"></param>
        /// <param name="tableName"></param>
        /// <param name="date">20200828</param>
        /// <returns></returns>
        public bool CheckDateExist(string database, string tableName, string date)
        {
            var connection = OpenConnection(database);
            SQLiteCommand mDbCmd = connection.CreateCommand();
            mDbCmd.CommandText = $"SELECT * FROM {tableName} where Date = '{date}' LIMIT 1;";
            if (mDbCmd.ExecuteScalar() == null)
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                return false;
            }
            else
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                return true;
            }
        }

        #region Employee

        public bool EmployeeDataAdd(string database, string tableName, List<string> header_, List<_employee> data_)
        {
            string insertString = String.Empty;
            int header_count = header_.Count();
            int counter = 1;
            int data_counter = 0;

            // Final string send to SQL

            insertString += $@"INSERT INTO {tableName} (";
            foreach (var header in header_)
            {
                // Last column
                if (counter == header_count)
                    insertString += $"{header})";
                else
                    insertString += $"{header}, ";
                counter++;
            }
            insertString += $" VALUES ";
            foreach (var item in data_)
            {
                if (data_counter == data_.Count() - 1)
                    insertString += $"('{item.Id}','{item.Name}','{item.Team}','{item.Title}','{item.PCId}','{item.Ip}','{item.Extension}');" + Environment.NewLine;
                else
                    insertString += $"('{item.Id}','{item.Name}','{item.Team}','{item.Title}','{item.PCId}','{item.Ip}','{item.Extension}'),";
                data_counter++;
            }
            if (Manipulate(database, insertString))
                return true;
            else
                return false;

        }
        public bool EmployeeDataDelete(string database, string tableName, string idList)
        {
            string insertString = String.Empty;

            // Final string send to SQL
            insertString += $@"DELETE FROM {tableName} WHERE ID IN({idList})";
            if (Manipulate(database, insertString))
                return true;
            else
                return false;
        }
        public bool EmployeeDataUpdate(string database, string tableName, List<string> header_, _employee data_, int id_)
        {
            string insertString = String.Empty;
            // Final string send to SQL
            insertString += $@"UPDATE {tableName} SET Id={data_.Id},Name='{data_.Name}',Team='{data_.Team}',Title='{data_.Title}',PCId='{data_.PCId}',Ip='{data_.Ip}',Extension='{data_.Extension}' WHERE Id = {id_}";
            if (Manipulate(database, insertString))
                return true;
            else
                return false;
        }
        #endregion

        #region Server
        public bool ServerDataAdd(string database, string tableName, List<string> header_, List<_server> data_)
        {
            string insertString = String.Empty;
            int header_count = header_.Count();
            int counter = 1;
            int data_counter = 0;

            // Final string send to SQL

            insertString += $@"INSERT INTO {tableName} (";
            foreach (var header in header_)
            {
                // Last column
                if (counter == header_count)
                    insertString += $"{header})";
                else
                    insertString += $"{header}, ";
                counter++;
            }
            insertString += $" VALUES ";
            foreach (var item in data_)
            {
                if (data_counter == data_.Count() - 1)
                    insertString += $"('{item.Name}','{item.Ip}','{item.Account}','{item.Password}','{item.Remark}');" + Environment.NewLine;
                else
                    insertString += $"('{item.Name}','{item.Ip}','{item.Account}','{item.Password}','{item.Remark}'),";
                data_counter++;
            }
            if (Manipulate(database, insertString))
                return true;
            else
                return false;

        }
        public bool ServerDataDelete(string database, string tableName, string ip)
        {
            string insertString = String.Empty;

            // Final string send to SQL
            insertString += $@"DELETE FROM {tableName} WHERE Ip= '{ip}'";
            if (Manipulate(database, insertString))
                return true;
            else
                return false;
        }

        public bool ServerDataUpdate(string database, string tableName, List<string> header_, _server data_, string Ip_)
        {
            string insertString = String.Empty;
            // Final string send to SQL
            insertString += $@"UPDATE {tableName} SET Name='{data_.Name}',Ip='{data_.Ip}',Account='{data_.Account}',Password='{data_.Password}',Remark='{data_.Remark}' WHERE Ip = '{Ip_}'";
            if (Manipulate(database, insertString))
                return true;
            else
                return false;
        }
        #endregion

        #region Others
        public bool OthersDataAdd(string database, string tableName, List<string> header_, List<_others> data_)
        {
            string insertString = String.Empty;
            int header_count = header_.Count();
            int counter = 1;
            int data_counter = 0;

            // Final string send to SQL

            insertString += $@"INSERT INTO {tableName} (";
            foreach (var header in header_)
            {
                // Last column
                if (counter == header_count)
                    insertString += $"{header})";
                else
                    insertString += $"{header}, ";
                counter++;
            }
            insertString += $" VALUES ";
            foreach (var item in data_)
            {
                if (data_counter == data_.Count() - 1)
                    insertString += $"('{item.Name}','{item.type}','{item.Account}','{item.Password}','{item.Remark}');" + Environment.NewLine;
                else
                    insertString += $"('{item.Name}','{item.type}','{item.Account}','{item.Password}','{item.Remark}'),";
                data_counter++;
            }
            if (Manipulate(database, insertString))
                return true;
            else
                return false;

        }
        public bool OthersDataDelete(string database, string tableName, string Name)
        {
            string insertString = String.Empty;

            // Final string send to SQL
            insertString += $@"DELETE FROM {tableName} WHERE Name= '{Name}'";
            if (Manipulate(database, insertString))
                return true;
            else
                return false;
        }
        #region Folder
        public bool FolderDataAdd(string database, string tableName, List<string> header_, List<_folder> data_)
        {
            string insertString = String.Empty;
            int header_count = header_.Count();
            int counter = 1;
            int data_counter = 0;

            // Final string send to SQL

            insertString += $@"INSERT INTO {tableName} (";
            foreach (var header in header_)
            {
                // Last column
                if (counter == header_count)
                    insertString += $"{header})";
                else
                    insertString += $"{header}, ";
                counter++;
            }
            insertString += $" VALUES ";
            foreach (var item in data_)
            {
                if (data_counter == data_.Count() - 1)
                    insertString += $"('{item.Item}','{item.Path}','{item.Fre}');" + Environment.NewLine;
                else
                    insertString += $"('{item.Item}','{item.Path}','{item.Fre}'),";
                data_counter++;
            }
            if (Manipulate(database, insertString))
                return true;
            else
                return false;

        }
        public bool FolderDataDelete(string database, string tableName, string Item)
        {
            string insertString = String.Empty;

            // Final string send to SQL
            insertString += $@"DELETE FROM {tableName} WHERE Item= '{Item}'";
            if (Manipulate(database, insertString))
                return true;
            else
                return false;
        }
        #endregion
        public bool OthersDataUpdate(string database, string tableName, List<string> header_, _others data_, string Name)
        {
            string insertString = String.Empty;
            // Final string send to SQL
            insertString += $@"UPDATE {tableName} SET Name='{data_.Name}',Type='{data_.type}',Account='{data_.Account}',Password='{data_.Password}',Remark='{data_.Remark}' WHERE Name = '{Name}'";
            if (Manipulate(database, insertString))
                return true;
            else
                return false;
        }
        #endregion

        public string CreateTableString(string tableName, List<string> header_)
        {
            int header_count = header_.Count();
            int counter = 1;
            // 建立資料表 TestTable
            var createtablestring = $@"CREATE TABLE {tableName} (";

            foreach (var header in header_)
            {
                if (counter == header_count)
                    createtablestring += $"{header} VARCHAR(32));";
                else
                    createtablestring += $"{header} VARCHAR(32),";
                counter++;
            }
            return createtablestring;
        }

        private void ConShutdown(SQLiteConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
        string GetConnectString()
        {
            return $@"Data Source={_path.db};Version=3;New=False;Compress=True;";
        }
    }
}
