using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class RecoverRow : Form
    {
        private readonly int _id;

        public RecoverRow(int id)
        {
            InitializeComponent();
            PopulateFields(id);
            _id = id;
        }
        private void PopulateComboBox()
        {
            using (dbDataContext db = new dbDataContext())
            {
                var cars = (from tc in db.typeCars
                            select new { tc.id, Car = $"id {tc.id}: {tc.name} {tc.model}, {tc.year}" }).ToList();

                cb_car.DataSource = cars;
                cb_car.DisplayMember = "Car";
                cb_car.ValueMember = "id";
            }
        }
        private void PopulateFields(int id)
        {
            using (dbDataContext db = new dbDataContext())
            {
                errorInsertData error = (from eid in db.errorInsertDatas
                                         where eid.id == id
                               select eid).FirstOrDefault();

                tb_table.Text = error.errorTable;
                tb_row.Text = error.errorLine;

                if (error.errorTable == "typeCars")
                {
                    table_record.Visible = false;
                }
                else
                {
                    if (error.errorTable == "rentalRecords")
                    {
                        table_car.Visible = false;
                        PopulateComboBox();
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_table.Text == "typeCars")
                {
                    string name = tb_name.Text;
                    string model = tb_model.Text;
                    string yearText = tb_year.Text;
                    string licensePlate = tb_licensePlate.Text;

                    bool isValid = true;
                    string errorMessage = "";
                    string licencePlatePattern = @"([A-Z][A-Z]|\d\d)-([A-Z][A-Z]|\d\d)-([A-Z][A-Z]|\d\d)";

                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(licensePlate) || string.IsNullOrWhiteSpace(yearText))
                    {
                        isValid = false;
                        errorMessage += "Error: Please enter missing data.\n";
                    }

                    if (!string.IsNullOrWhiteSpace(yearText))
                    {
                        if (Regex.IsMatch(yearText, @"^\d{4}"))
                        {
                            int year = Convert.ToInt32(yearText);
                            int nowYear = DateTime.Now.Year;

                            if (year < 1932 || year > nowYear)
                            {
                                isValid = false;
                                errorMessage += "Error: Please enter the correct year.\n";
                            }
                        }
                        else
                        {
                            isValid = false;
                            errorMessage += "Error: Please enter the correct year.\n";
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(licensePlate))
                    {
                        if (!(Regex.IsMatch(licensePlate, licencePlatePattern)))
                        {
                            isValid = false;
                            errorMessage += "Error: Please enter the correct License Plate.\n";
                        }
                    }

                    if (isValid)
                    {
                        using (dbDataContext db = new dbDataContext())
                        {
                            typeCar car = new typeCar();

                            car.name = name;
                            car.model = model;
                            car.year = Convert.ToInt32(yearText);
                            car.licensePlate = licensePlate;

                            db.typeCars.InsertOnSubmit(car);

                            errorInsertData error = (from eid in db.errorInsertDatas
                                                     where eid.id == _id
                                                     select eid).FirstOrDefault();
                            db.errorInsertDatas.DeleteOnSubmit(error);

                            db.SubmitChanges();
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
                else
                {
                    if (tb_table.Text == "rentalRecords")
                    {
                        string customerName = tb_customer.Text;
                        string costText = tb_cost.Text;

                        DateTime dateRanted = dtp_dateRented.Value;
                        DateTime dateReturned = dtp_dateReturned.Value;

                        int carTypeID = Convert.ToInt32(cb_car.SelectedValue);

                        bool isValid = true;
                        string errorMessage = "";

                        if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(costText))
                        {
                            isValid = false;
                            errorMessage += "Error: Please enter missing data.\n";
                        }

                        if (dateRanted > dateReturned)
                        {
                            isValid = false;
                            errorMessage += "Error: Illegal Date Selection.\n";
                        }

                        if (!string.IsNullOrWhiteSpace(costText))
                        {
                            if (costText.All(char.IsDigit))
                            {
                                double cost = Convert.ToDouble(costText);
                                if (cost < 0)
                                {
                                    isValid = false;
                                    errorMessage += "Error: Please enter the correct Cost.\n";
                                }
                            }
                            else
                            {
                                isValid = false;
                                errorMessage += "Error: Please enter the correct Cost.\n";
                            }
                        }

                        if (isValid)
                        {
                            using (dbDataContext db = new dbDataContext())
                            {
                                rentalRecord record = new rentalRecord();

                                record.customerName = customerName;
                                record.dateRented = dateRanted;
                                record.dateReturned = dateReturned;
                                record.cost = Convert.ToDecimal(costText);
                                record.typeCarID = carTypeID;

                                db.rentalRecords.InsertOnSubmit(record);

                                errorInsertData error = (from eid in db.errorInsertDatas
                                                         where eid.id == _id
                                                         select eid).FirstOrDefault();
                                db.errorInsertDatas.DeleteOnSubmit(error);

                                db.SubmitChanges();
                            }
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(errorMessage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RecoverRow_Load(object sender, EventArgs e)
        {
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
