using System;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.IO;
using System.Globalization;
using System.Linq;

namespace WindowsForm
{
    public static class Utils
    {
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            //Convert the password to byte array and transform to hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //Create a Stringbuilder to collect the bytes
            //and create a string.
            StringBuilder sBuilder = new StringBuilder();

            //Loop through each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            var hashed_password = sBuilder.ToString();

            return hashed_password;
        }

        public static void CopyFile(string sourcePathFile, string destinationPath, string destinationPathFile)
        {
            // Ensure that the directory exist.  
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            // Ensure that the target does not exist.  
            if (File.Exists(destinationPathFile))
            {
                File.Delete(destinationPathFile);
            }

            // Copy the file.  
            File.Copy(sourcePathFile, destinationPathFile);
        }

        public static void LogError(string errorMessage)
        {
            string hoje = DateTime.Now.ToString("dd-MM-yyyy");
            string destinationPath = "C:\\RentalCar\\ErrorLogs";
            string destinationPathFile = $"C:\\RentalCar\\ErrorLogs\\{hoje}.txt";

            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            } 

            if (!File.Exists(destinationPathFile))
            {
                File.Create(destinationPathFile).Close();
            }

            using (StreamWriter w = File.AppendText(destinationPathFile))
            {
                w.WriteLine("\r\nLog Entry: ");
                w.Write(DateTime.Now.ToString(CultureInfo.InvariantCulture));
                w.WriteLine("\r\nError Message: ");
                w.WriteLine(errorMessage);
                w.WriteLine("\r\n====================================================================================================");
                w.Flush();
                w.Close();
            }
        }

        public static string GetTableName(string location)
        {
            string tableName = File.ReadAllLines(location).First();
            return tableName;
        }

        public static DataTable DataTableFromFile(string location, char delimiter = ';')
        {
            DataTable dt = new DataTable();

            string[] lineArray = File.ReadAllLines(location);

            AddColumnToTable(lineArray, delimiter, dt);
            AddRowToTable(lineArray, delimiter, dt);

            return dt;
        }

        private static void AddColumnToTable(string[] lineArray, char delimiter, DataTable dt)
        {
            string[] columns = lineArray[1].Split(delimiter);
            foreach (string columnName in columns)
            {
                DataColumn dc = new DataColumn(columnName, typeof(string));
                dt.Columns.Add(dc);
            }

            DataColumn dcl = new DataColumn("Line", typeof(string));
            dt.Columns.Add(dcl);
        }

        private static void AddRowToTable(string[] lineArray, char delimiter, DataTable dt)
        {
            for (int i = 2; i < lineArray.Length; i++)
            {
                string[] values = lineArray[i].Split(delimiter);

                DataRow dr = dt.NewRow();
                for (int j = 0; j < values.Length; j++)
                {
                    dr[j] = values[j];
                }
                dr["Line"] = i;

                dt.Rows.Add(dr);
            }
        }
    }
}
