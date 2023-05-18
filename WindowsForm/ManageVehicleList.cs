using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class ManageVehicleList : Form
    {
        private user _userLogin;
        public ManageVehicleList(user userLogin)
        {
            InitializeComponent();
            _userLogin = userLogin;
        }

        private void PopulateTable()
        {
            using (dbDataContext db = new dbDataContext())
            {
                var cars = (from tc in db.typeCars
                            select tc).ToList();

                dg_VehicleList.DataSource = cars;
                dg_VehicleList.Columns["id"].Visible = false;
                dg_VehicleList.Columns["name"].HeaderText = "Name";
                dg_VehicleList.Columns["model"].HeaderText = "Model";
                dg_VehicleList.Columns["year"].HeaderText = "Year";
                dg_VehicleList.Columns["licensePlate"].HeaderText = "License Plate";

                dg_VehicleList.Refresh();
            }
        }

        private void btn_addNewCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle();
            addEditVehicle.ShowDialog();
            PopulateTable();
        }

        private void btn_editCar_Click(object sender, EventArgs e)
        {
            try
            {
                bool selectRow = false;

                foreach (DataGridViewRow dr in dg_VehicleList.Rows)
                {
                    bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                    if (chkboxSelected)
                    {
                        int id = Convert.ToInt32(dr.Cells["id"].Value);

                        AddEditVehicle addEditVehicle = new AddEditVehicle(id);
                        addEditVehicle.ShowDialog();

                        selectRow = true;
                    }
                }

                if (dg_VehicleList.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dg_VehicleList.SelectedRows[0].Cells["id"].Value);

                    AddEditVehicle addEditVehicle = new AddEditVehicle(id);
                    addEditVehicle.ShowDialog();

                    selectRow = true;
                }

                if (!selectRow)
                {
                    MessageBox.Show("Select a car first!");
                }
                else
                {
                    PopulateTable();
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deleteCar(dbDataContext db, int id)
        {
            typeCar car = (from tc in db.typeCars
                       where tc.id == id
                       select tc).FirstOrDefault();

            DialogResult dialogR = MessageBox.Show($"Do you want to delete this car: {car.name} {car.model}?", "Remove Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dialogR)
            {
                db.typeCars.DeleteOnSubmit(car);
            }
        }

        private void btn_deleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbDataContext db = new dbDataContext())
                {
                    bool selectRow = false;

                    foreach (DataGridViewRow dr in dg_VehicleList.Rows)
                    {
                        bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                        if (chkboxSelected)
                        {
                            int id = Convert.ToInt32(dr.Cells["id"].Value);

                            bool fkDependent = (from r in db.rentalRecords
                                           where r.typeCarID == id
                                           select r).Any();

                            if (fkDependent)
                            {
                                MessageBox.Show("This car is related to records.");
                            }
                            else
                            {
                                deleteCar(db, id);
                            }

                            selectRow = true;
                        }
                    }

                    if (dg_VehicleList.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(dg_VehicleList.SelectedRows[0].Cells["id"].Value);

                        bool fkDependent = (from r in db.rentalRecords
                                            where r.typeCarID == id
                                            select r).Any();

                        if (fkDependent)
                        {
                            MessageBox.Show("This car is related to records.");
                        }
                        else
                        {
                            deleteCar(db, id);
                        }

                        selectRow = true;
                    }

                    if (!selectRow)
                    {
                        MessageBox.Show("Select a car first!");
                    }
                    else
                    {
                        db.SubmitChanges();
                        PopulateTable();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dg_VehicleList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dg_VehicleList.SelectedRows[0].Cells["id"].Value);

                AddEditVehicle addEditVehicle = new AddEditVehicle(id);
                addEditVehicle.ShowDialog();

                PopulateTable();
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageVehicleList_Load(object sender, EventArgs e)
        {
            PopulateTable();

            DataGridViewCheckBoxColumn chkboxColumn = new DataGridViewCheckBoxColumn();
            chkboxColumn.HeaderText = "";
            chkboxColumn.Width = 30;
            chkboxColumn.Name = "chkboxColumn";
            dg_VehicleList.Columns.Insert(0, chkboxColumn);

            if (_userLogin.roleID == 3)
            {
                btn_addNewCar.Visible = false;
                btn_editCar.Visible = false;
                btn_deleteCar.Visible = false;
                label.Text = "Vehicles List";
            }
        }
    }
}
