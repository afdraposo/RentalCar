// See https://aka.ms/new-console-template for more information
using RentalCarConsole;
using System.Linq;
using System.IO;
using System;
using System.Text.RegularExpressions;


namespace ConsoleRentalCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = "C:\\RentalCar\\Ficheiros\\Enviar";

            string[] files = Directory.GetFiles(sourcePath);

            if (files.Length > 0)
            {
                using (dbDataContext db = new dbDataContext())
                {
                    foreach (string file in files)
                    {
                        string extension = Path.GetExtension(file);
                        string fileName = Path.GetFileName(file);
                        string sourcePathFile = $"C:\\RentalCar\\Ficheiros\\Enviar\\{fileName}";

                        if (extension == ".csv")
                        {
                            try
                            {
                                string[] lineArray = File.ReadAllLines(sourcePathFile);

                                if (lineArray[0] == "Carros")
                                {
                                    for (int i = 2; i < lineArray.Length; i++)
                                    {
                                        string[] values = lineArray[i].Split(';');
                                        string errorMessage = $"Linha {i}:";
                                        DateTime currentDateTime = DateTime.Now;
                                        bool isValid = true;
                                        string licencePlatePattern = @"([A-Z][A-Z]|\d\d)-([A-Z][A-Z]|\d\d)-([A-Z][A-Z]|\d\d)";

                                        if (values.Length != 4)
                                        {
                                            isValid = false;
                                            errorMessage += " Não possuí 4 campos necessários!";
                                        }
                                        else
                                        {
                                            if (string.IsNullOrWhiteSpace(values[0]) || string.IsNullOrWhiteSpace(values[1]) || string.IsNullOrWhiteSpace(values[2]) || string.IsNullOrWhiteSpace(values[3]))
                                            {
                                                isValid = false;
                                                errorMessage += " Um ou mais campos não estão preenchidos!";
                                            }

                                            if (!string.IsNullOrWhiteSpace(values[2]))
                                            {
                                                if (Regex.IsMatch(values[2], @"^\d{4}"))
                                                {
                                                    int year = Convert.ToInt32(values[2]);
                                                    int nowYear = DateTime.Now.Year;

                                                    if (year < 1932 || year > nowYear)
                                                    {
                                                        isValid = false;
                                                        errorMessage += " Data inválida!";
                                                    }
                                                }
                                                else
                                                {
                                                    isValid = false;
                                                    errorMessage += " Data inválida!";
                                                }
                                            }

                                            if (!string.IsNullOrWhiteSpace(values[3]))
                                            {
                                                if (!(Regex.IsMatch(values[3], licencePlatePattern)))
                                                {
                                                    isValid = false;
                                                    errorMessage += " Matrícula inválida!";
                                                }
                                            }
                                        }

                                        if (isValid)
                                        {
                                            typeCar car = new typeCar();
                                            car.name = values[0];
                                            car.model = values[1];
                                            car.year = Convert.ToInt32(values[2]);
                                            car.licensePlate = values[3];

                                            db.typeCars.InsertOnSubmit(car);
                                        }
                                        else
                                        {
                                            errorInsertData eid = new errorInsertData();
                                            eid.errorLine = lineArray[i];
                                            eid.errorTable = "typeCars";
                                            eid.errorMessage = errorMessage;
                                            eid.namefile = fileName;
                                            eid.errorDate = currentDateTime;

                                            db.errorInsertDatas.InsertOnSubmit(eid);
                                        }
                                    }
                                }
                                else
                                {
                                    if (lineArray[0] == "Records")
                                    {
                                        for (int i = 2; i < lineArray.Length; i++)
                                        {
                                            string[] values = lineArray[i].Split(';');
                                            string errorMessage = $"Linha {i}:";
                                            DateTime currentDateTime = DateTime.Now;
                                            bool isValid = true;

                                            if (values.Length != 5)
                                            {
                                                isValid = false;
                                                errorMessage += " Não possuí 5 campos necessários!";
                                            }
                                            else
                                            {
                                                if (string.IsNullOrWhiteSpace(values[0]) || string.IsNullOrWhiteSpace(values[1]) || string.IsNullOrWhiteSpace(values[2]) || string.IsNullOrWhiteSpace(values[3]) || string.IsNullOrWhiteSpace(values[4]))
                                                {
                                                    isValid = false;
                                                    errorMessage += " Um ou mais campos não estão preenchidos!";
                                                }

                                                DateTime temp;
                                                if (DateTime.TryParse(values[1], out temp) && DateTime.TryParse(values[2], out temp))
                                                {
                                                    DateTime dateRented = Convert.ToDateTime(values[1]);
                                                    DateTime dateReturned = Convert.ToDateTime(values[2]);
                                                    if (dateRented > dateReturned)
                                                    {
                                                        isValid = false;
                                                        errorMessage += " Data inválida!";
                                                    }
                                                }
                                                else
                                                {
                                                    isValid = false;
                                                    errorMessage += " Data inválida!";
                                                }

                                                if (!string.IsNullOrWhiteSpace(values[3]))
                                                {
                                                    if (values[3].All(char.IsDigit))
                                                    {
                                                        double cost = Convert.ToDouble(values[3]);
                                                        if (cost < 0)
                                                        {
                                                            isValid = false;
                                                            errorMessage += " Custo Inválido!";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        errorMessage += " Custo Inválido!";
                                                    }
                                                }

                                                if (!string.IsNullOrWhiteSpace(values[4]))
                                                {
                                                    if (values[4].All(char.IsDigit))
                                                    {
                                                        int typeCarID = Convert.ToInt32(values[4]);

                                                        bool fkDependent = (from r in db.typeCars
                                                                            where r.id == typeCarID
                                                                            select r).Any();

                                                        if (!fkDependent)
                                                        {
                                                            isValid = false;
                                                            errorMessage += " Carro Inválido!";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        errorMessage += " Carro Inválido!";
                                                    }
                                                }
                                            }

                                            if (isValid)
                                            {
                                                rentalRecord record = new rentalRecord();
                                                record.customerName = values[0];
                                                record.dateRented = Convert.ToDateTime(values[1]);
                                                record.dateReturned = Convert.ToDateTime(values[2]);
                                                record.cost = Convert.ToInt32(values[3]);
                                                record.typeCarID = Convert.ToInt32(values[4]);

                                                db.rentalRecords.InsertOnSubmit(record);
                                            }
                                            else
                                            {
                                                errorInsertData eid = new errorInsertData();
                                                eid.errorLine = lineArray[i];
                                                eid.errorTable = "rentalRecords";
                                                eid.errorMessage = errorMessage;
                                                eid.namefile = fileName;
                                                eid.errorDate = currentDateTime;

                                                db.errorInsertDatas.InsertOnSubmit(eid);
                                            }
                                        }
                                    }
                                }

                                db.SubmitChanges();

                                string destinationPath = "C:\\RentalCar\\Ficheiros\\Importados";
                                string destinationPathFile = $"C:\\RentalCar\\Ficheiros\\Importados\\{fileName}";

                                Utils.MoveFile(sourcePathFile, destinationPath, destinationPathFile);
                            }
                            catch (Exception ex)
                            {
                                string destinationPath = "C:\\RentalCar\\Ficheiros\\Recebidos";
                                string destinationPathFile = $"C:\\RentalCar\\Ficheiros\\Recebidos\\{fileName}";

                                Utils.MoveFile(sourcePathFile, destinationPath, destinationPathFile);

                                Utils.LogError(ex.ToString());
                            }
                        }
                        else
                        {
                            string destinationPath = "C:\\RentalCar\\Ficheiros\\Recebidos";
                            string destinationPathFile = $"C:\\RentalCar\\Ficheiros\\Recebidos\\{fileName}";

                            Utils.MoveFile(sourcePathFile, destinationPath, destinationPathFile);
                        }
                    }
                }
            }
        }
    }
}