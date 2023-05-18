using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly int _id;

        public AddEditVehicle()
        {
            InitializeComponent();
            label_addEditVehicle.Text = "Add New Vehicle";
            isEditMode = false;
        }

        public AddEditVehicle(int id)
        {
            InitializeComponent();
            label_addEditVehicle.Text = "Edit Vehicle";
            isEditMode = true;
            PopulateFields(id);
            _id = id;
        }

        private void PopulateFields(int id)
        {
            using (dbDataContext db = new dbDataContext())
            {
                typeCar car = (from tc in db.typeCars
                            where tc.id == id
                            select tc).FirstOrDefault();

                tb_name.Text = car.name;
                tb_model.Text = car.model;
                tb_year.Text = car.year.ToString();
                tb_licensePlate.Text = car.licensePlate;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try 
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
                        typeCar car;

                        if (isEditMode)
                        {
                            car = (from tc in db.typeCars
                                       where tc.id == _id
                                       select tc).FirstOrDefault();
                        }
                        else
                        {
                            car = new typeCar();
                        }

                        car.name = name;
                        car.model = model;
                        car.year = Convert.ToInt32(yearText);
                        car.licensePlate = licensePlate;

                        if (!isEditMode)
                        {
                            db.typeCars.InsertOnSubmit(car);
                        }

                        db.SubmitChanges();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
