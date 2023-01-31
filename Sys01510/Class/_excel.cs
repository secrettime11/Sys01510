using ExcelDataReader;
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
        public List<string> ReadExcel(string FilePath)
        {
            // Return list
            List<string> Result = new List<string>();
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
                                UseHeaderRow = false
                            }
                        });

                        // Show dataset
                        var table = ds.Tables[0];
                        for (int row = 0; row < table.Rows.Count; row++)
                        {
                            string data = "";
                            for (var col = 0; col < table.Columns.Count; col++)
                            {
                                data += table.Rows[row][col].ToString().Trim() + "_";
                            }
                            Result.Add(data + "_" + $"{row + 1}");
                        }
                    }
                }
                Console.WriteLine("End");
                return Result;
            }
            else
            {
                Console.WriteLine("File " + FilePath + " not exists!");
            }
            return Result;
        }
    }
}
