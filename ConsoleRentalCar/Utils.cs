using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarConsole
{
    internal class Utils
    {
        public static void MoveFile(string sourcePathFile, string destinationPath, string destinationPathFile)
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

            // Move the file.  
            File.Move(sourcePathFile, destinationPathFile);
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
    }
}
