using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class ManageRentalRecords : Form
    {
        private user _userLogin;
        public ManageRentalRecords(user userLogin)
        {
            InitializeComponent();
            _userLogin = userLogin;
        }
        private void PopulateTable()
        {
            using (dbDataContext db = new dbDataContext())
            {
                var records = (from rr in db.rentalRecords
                               join tc in db.typeCars on rr.typeCarID equals tc.id
                            select new { rr.id, rr.customerName, rr.dateRented, rr.dateReturned, Cost = rr.cost + "€", rr.typeCarID, Car = $"{tc.name} {tc.model}, {tc.year}" }).ToList();

                dg_RecordsList.DataSource = records;
                dg_RecordsList.Columns["id"].Visible = false;
                dg_RecordsList.Columns["typeCarID"].Visible = false;
                dg_RecordsList.Columns["customerName"].HeaderText = "Customer";
                dg_RecordsList.Columns["dateRented"].HeaderText = "Date Rented";
                dg_RecordsList.Columns["dateReturned"].HeaderText = "Date Returned";

                dg_RecordsList.Refresh();
            }
        }

        /*
        private void PopulateComboBox()
        {
            foreach (DataGridViewRow dr in dg_RecordsList.Rows)
            {
                dr.Cells[6].Value = dr.Cells["typeCarID"].Value;
            }
        }
        */

        private void btn_addNewRecord_Click(object sender, EventArgs e)
        {
            AddEditRecord addRecord = new AddEditRecord();
            addRecord.ShowDialog();
            PopulateTable();
        }

        private void btn_editRecord_Click(object sender, EventArgs e)
        {
            try
            {
                bool selectRow = false;

                foreach (DataGridViewRow dr in dg_RecordsList.Rows)
                {
                    bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                    if (chkboxSelected)
                    {
                        int id = Convert.ToInt32(dr.Cells["id"].Value);

                        AddEditRecord addEditRecord = new AddEditRecord(id);
                        addEditRecord.ShowDialog();

                        selectRow = true;
                    }
                }

                if (dg_RecordsList.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dg_RecordsList.SelectedRows[0].Cells["id"].Value);

                    AddEditRecord addEditRecord = new AddEditRecord(id);
                    addEditRecord.ShowDialog();

                    selectRow = true;
                }

                if (!selectRow)
                {
                    MessageBox.Show("Select a record first!");
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

        private void deleteRecord(dbDataContext db, int id)
        {
            rentalRecord record = (from rr in db.rentalRecords
                           where rr.id == id
                           select rr).FirstOrDefault();

            DialogResult dialogR = MessageBox.Show($"Do you want to delete this record: {record.customerName}?\n({record.dateRented}) - ({record.dateReturned})", "Remove Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dialogR)
            {
                db.rentalRecords.DeleteOnSubmit(record);
            }
        }

        private void btn_deleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbDataContext db = new dbDataContext())
                {
                    bool selectRow = false;

                    foreach (DataGridViewRow dr in dg_RecordsList.Rows)
                    {
                        bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                        if (chkboxSelected)
                        {
                            int id = Convert.ToInt32(dr.Cells["id"].Value);

                            deleteRecord(db, id);

                            selectRow = true;
                        }
                    }

                    if (dg_RecordsList.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(dg_RecordsList.SelectedRows[0].Cells["id"].Value);

                        deleteRecord(db, id);

                        selectRow = true;
                    }

                    if (!selectRow)
                    {
                        MessageBox.Show("Select a record first!");
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
        private void dg_RecordsList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dg_RecordsList.SelectedRows[0].Cells["id"].Value);

                AddEditRecord addEditRecord = new AddEditRecord(id);
                addEditRecord.ShowDialog();

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

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            PopulateTable();

            DataGridViewCheckBoxColumn chkboxColumn = new DataGridViewCheckBoxColumn();
            chkboxColumn.HeaderText = "";
            chkboxColumn.Width = 30;
            chkboxColumn.Name = "chkboxColumn";
            dg_RecordsList.Columns.Insert(0, chkboxColumn);

            /*
            DataGridViewComboBoxColumn comboBoxCar = new DataGridViewComboBoxColumn();
            using (dbDataContext db = new dbDataContext())
            {
                var cars = (from tc in db.typeCars
                            select new { tc.id, Car = $"{tc.name} {tc.model}, {tc.year}" }).ToList();

                comboBoxCar.DataSource = cars;
                comboBoxCar.HeaderText = "Car";
                comboBoxCar.DisplayMember = "Car";
                comboBoxCar.ValueMember = "id";
            }
            dg_RecordsList.Columns.Insert(6, comboBoxCar);
            
            PopulateComboBox();
            */

            if (_userLogin.roleID == 3)
            {
                btn_addNewRecord.Visible = false;
                btn_editRecord.Visible = false;
                btn_deleteRecord.Visible = false;
                label.Text = "Rental Records List";
            }
        }
    }
}
