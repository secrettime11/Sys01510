using ExcelDataReader;
using Sys01510.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys01510.Class
{
    public class _excel
    {
        /// <summary>
        /// Read excel
        /// </summary>
        /// <param name="FilePath"> file path</param>
        /// <returns></returns>
        public List<_employee> ReadExcel(string FilePath)
        {
            // Return list
            List<_employee> Result = new List<_employee>();
            DataSet ds;

            if (File.Exists(FilePath))
            {
                var extension = Path.GetExtension(FilePath).ToLower();
                Console.WriteLine("Reading file：" + FilePath);
                using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    IExcelDataReader reader = null;

                    // Determine file format
                    if (extension == ".xls")
                    {
                        Console.WriteLine(" => XLS Format");
                        reader = ExcelReaderFactory.CreateBinaryReader(stream, new ExcelReaderConfiguration()
                        {
                            FallbackEncoding = Encoding.GetEncoding("big5")
                        });
                    }
                    else if (extension == ".xlsx")
                    {
                        Console.WriteLine(" => XLSX Format");
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else if (extension == ".csv")
                    {
                        Console.WriteLine(" => CSV Format");
                        reader = ExcelReaderFactory.CreateCsvReader(stream, new ExcelReaderConfiguration()
                        {
                            FallbackEncoding = Encoding.GetEncoding("big5")
                        });
                    }
                    else if (extension == ".txt")
                    {
                        Console.WriteLine(" => Text(Tab Separated) Format");
                        reader = ExcelReaderFactory.CreateCsvReader(stream, new ExcelReaderConfiguration()
                        {
                            FallbackEncoding = Encoding.GetEncoding("big5"),
                            AutodetectSeparators = new char[] { '\t' }
                        });
                    }

                    // No match file format
                    if (reader == null)
                    {
                        Console.WriteLine("Unkown file format：" + extension);
                        return null;
                    }

                    Console.WriteLine(" => File reading...");

                    using (reader)
                    {
                        ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            UseColumnDataType = false,
                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                            {
                                // Setting ignore header ?
                                // true = no header
                                UseHeaderRow = true
                            }
                        });
                    }
                    Result = EmployeeData(ds);
                }
                Console.WriteLine("Read end");
                return Result;
            }
            else
            {
                Console.WriteLine("File " + FilePath + " not exists!");
            }
            return Result;
        }

        private List<_employee> EmployeeData(DataSet ds)
        {
            List<_employee> Result = new List<_employee>();
            // Show dataset
            var table = ds.Tables[0];
            // row
            for (int row = 0; row < table.Rows.Count; row++)
            {
                _employee employee = new _employee();
                employee.Id = Convert.ToInt32(table.Rows[row][0].ToString().Trim());
                employee.Name = table.Rows[row][1].ToString().Trim();
                employee.Team = table.Rows[row][2].ToString().Trim();
                employee.Title = table.Rows[row][3].ToString().Trim();
                employee.PCId = table.Rows[row][4].ToString().Trim();
                employee.Ip = table.Rows[row][5].ToString().Trim();
                employee.Extension = table.Rows[row][6].ToString().Trim();
                Result.Add(employee);
            }
            return Result;
        }


    }
}
