using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class AddEditRecord : Form
    {
        private bool isEditMode;
        private readonly int _id;

        public AddEditRecord()
        {
            InitializeComponent();
            label_addEditVehicle.Text = "Add New Record";
            isEditMode = false;
            PopulateComboBox();
        }

        public AddEditRecord(int id)
        {
            InitializeComponent();
            label_addEditVehicle.Text = "Edit Record";
            isEditMode = true;
            PopulateComboBox();
            PopulateFields(id);
            _id = id;
        }

        private void PopulateFields(int id)
        {
            using (dbDataContext db = new dbDataContext())
            {
                rentalRecord record = (from rr in db.rentalRecords
                                       where rr.id == id
                                       select rr).FirstOrDefault();

                tb_customer.Text = record.customerName;
                dtp_dateRented.Value = Convert.ToDateTime(record.dateRented);
                dtp_dateReturned.Value = Convert.ToDateTime(record.dateReturned);
                tb_cost.Text = record.cost.ToString();
                cb_car.SelectedValue = Convert.ToInt32(record.typeCarID);
            }
        }

        private void PopulateComboBox()
        {
            using (dbDataContext db = new dbDataContext())
            {
                var cars = (from tc in db.typeCars 
                                       select new {tc.id, Car = $"{tc.name} {tc.model}, {tc.year}"}).ToList();

                cb_car.DataSource = cars;
                cb_car.DisplayMember = "Car";
                cb_car.ValueMember = "id";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
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
                        rentalRecord record;

                        if (isEditMode)
                        {
                            record = (from rr in db.rentalRecords
                                    where rr.id == _id
                                    select rr).FirstOrDefault();
                        }
                        else
                        {
                            record = new rentalRecord();
                        }

                        record.customerName = customerName;
                        record.dateRented = dateRanted;
                        record.dateReturned = dateReturned;
                        record.cost = Convert.ToDecimal(costText);
                        record.typeCarID = carTypeID;

                        if (!isEditMode)
                        {
                            db.rentalRecords.InsertOnSubmit(record);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
