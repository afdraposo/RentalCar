using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class ImportFile : Form
    {
        private OpenFileDialog _openFileDialog;
        private string _tableName;
        public ImportFile(OpenFileDialog openFileDialog)
        {
            InitializeComponent();
            _openFileDialog = openFileDialog;
        }

        private void PopulateTable()
        {
            dg_FileList.DataSource = Utils.DataTableFromFile(_openFileDialog.FileName);
            _tableName = Utils.GetTableName(_openFileDialog.FileName);
            dg_FileList.Columns["Line"].Visible = false;
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbDataContext db = new dbDataContext())
                {
                    if (_tableName == "Carros")
                    {
                        foreach (DataGridViewRow dr in dg_FileList.Rows)
                        {
                            if (dr.Cells["Name"].Value != null)
                            {
                                string errorMessage = $"Linha {dr.Cells["Line"].Value}:";
                                DateTime currentDateTime = DateTime.Now;
                                bool isValid = true;
                                string licencePlatePattern = @"([A-Z][A-Z]|\d\d)-([A-Z][A-Z]|\d\d)-([A-Z][A-Z]|\d\d)";


                                if (string.IsNullOrWhiteSpace(dr.Cells["Name"].Value.ToString()) || string.IsNullOrWhiteSpace(dr.Cells["Model"].Value.ToString()) || string.IsNullOrWhiteSpace(dr.Cells["Year"].Value.ToString()) || string.IsNullOrWhiteSpace(dr.Cells["License Plate"].Value.ToString()))
                                {
                                    isValid = false;
                                    errorMessage += " Um ou mais campos não estão preenchidos!";
                                }

                                if (!string.IsNullOrWhiteSpace(dr.Cells["Year"].Value.ToString()))
                                {
                                    if (Regex.IsMatch(dr.Cells["Year"].Value.ToString(), @"^\d{4}"))
                                    {
                                        int year = Convert.ToInt32(dr.Cells["Year"].Value);
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

                                if (!string.IsNullOrWhiteSpace(dr.Cells["License Plate"].Value.ToString()))
                                {
                                    if (!(Regex.IsMatch(dr.Cells["License Plate"].Value.ToString(), licencePlatePattern)))
                                    {
                                        isValid = false;
                                        errorMessage += " Matrícula inválida!";
                                    }
                                }

                                if (isValid)
                                {
                                    typeCar car = new typeCar();
                                    car.name = dr.Cells["Name"].Value.ToString();
                                    car.model = dr.Cells["Model"].Value.ToString();
                                    car.year = Convert.ToInt32(dr.Cells["Year"].Value);
                                    car.licensePlate = dr.Cells["License Plate"].Value.ToString();

                                    db.typeCars.InsertOnSubmit(car);
                                }
                                else
                                {
                                    errorInsertData eid = new errorInsertData();
                                    eid.errorLine = $"{dr.Cells["Name"].Value};{dr.Cells["Model"].Value};{dr.Cells["Year"].Value};{dr.Cells["License Plate"].Value}";
                                    eid.errorTable = "typeCars";
                                    eid.errorMessage = errorMessage;
                                    eid.namefile = Path.GetFileName(_openFileDialog.FileName);
                                    eid.errorDate = currentDateTime;

                                    db.errorInsertDatas.InsertOnSubmit(eid);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (_tableName == "Records")
                        {
                            foreach (DataGridViewRow dr in dg_FileList.Rows)
                            {
                                if (dr.Cells["Customer"].Value != null)
                                {
                                    string errorMessage = $"Linha {dr.Cells["Line"].Value}:";
                                    DateTime currentDateTime = DateTime.Now;
                                    bool isValid = true;

                                    if (string.IsNullOrWhiteSpace(dr.Cells["Customer"].Value.ToString()) || string.IsNullOrWhiteSpace(dr.Cells["Date Rented"].Value.ToString()) || string.IsNullOrWhiteSpace(dr.Cells["Date Returned"].Value.ToString()) || string.IsNullOrWhiteSpace(dr.Cells["Cost"].Value.ToString()) || string.IsNullOrWhiteSpace(dr.Cells["Type Car"].Value.ToString()))
                                    {
                                        isValid = false;
                                        errorMessage += " Um ou mais campos não estão preenchidos!";
                                    }

                                    DateTime temp;
                                    if (DateTime.TryParse(dr.Cells["Date Rented"].Value.ToString(), out temp) && DateTime.TryParse(dr.Cells["Date Returned"].Value.ToString(), out temp))
                                    {
                                        DateTime dateRented = Convert.ToDateTime(dr.Cells["Date Rented"].Value);
                                        DateTime dateReturned = Convert.ToDateTime(dr.Cells["Date Returned"].Value);
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

                                    if (!string.IsNullOrWhiteSpace(dr.Cells["Cost"].Value.ToString()))
                                    {
                                        if (dr.Cells["Cost"].Value.ToString().All(char.IsDigit))
                                        {
                                            double cost = Convert.ToDouble(dr.Cells["Cost"].Value);
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

                                    if (!string.IsNullOrWhiteSpace(dr.Cells["Type Car"].Value.ToString()))
                                    {
                                        if (dr.Cells["Type Car"].Value.ToString().All(char.IsDigit))
                                        {
                                            int typeCarID = Convert.ToInt32(dr.Cells["Type Car"].Value);

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

                                    if (isValid)
                                    {
                                        rentalRecord record = new rentalRecord();
                                        record.customerName = dr.Cells["Customer"].Value.ToString();
                                        record.dateRented = Convert.ToDateTime(dr.Cells["Date Rented"].Value);
                                        record.dateReturned = Convert.ToDateTime(dr.Cells["Date Returned"].Value);
                                        record.cost = Convert.ToDecimal(dr.Cells["Cost"].Value);
                                        record.typeCarID = Convert.ToInt32(dr.Cells["Type Car"].Value);

                                        db.rentalRecords.InsertOnSubmit(record);
                                    }
                                    else
                                    {
                                        errorInsertData eid = new errorInsertData();
                                        eid.errorLine = $"{dr.Cells["Customer"].Value};{dr.Cells["Date Rented"].Value};{dr.Cells["Date Returned"].Value};{dr.Cells["Cost"].Value};{dr.Cells["Type Car"].Value}";
                                        eid.errorTable = "rentalRecords";
                                        eid.errorMessage = errorMessage;
                                        eid.namefile = Path.GetFileName(_openFileDialog.FileName);
                                        eid.errorDate = currentDateTime;

                                        db.errorInsertDatas.InsertOnSubmit(eid);
                                    }
                                }
                            }
                        }
                    }

                    db.SubmitChanges();
                }
                Close();
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_deleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                bool selectRow = false;
                var deleteRows = new List<DataGridViewRow>();

                if (dg_FileList.SelectedRows.Count > 0)
                {
                    dg_FileList.Rows.Remove(dg_FileList.SelectedRows[0]);

                    selectRow = true;
                }

                foreach (DataGridViewRow dr in dg_FileList.Rows)
                {
                    bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                    if (chkboxSelected)
                    {
                        deleteRows.Add(dr);

                        selectRow = true;
                    }
                }

                foreach (DataGridViewRow dr in deleteRows)
                {
                    dg_FileList.Rows.Remove(dr);
                }

                if (!selectRow)
                {
                    MessageBox.Show("Select a row first!");
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImportFile_Load(object sender, EventArgs e)
        {
            PopulateTable();
            tb_fileName.Text = _openFileDialog.FileName;

            DataGridViewCheckBoxColumn chkboxColumn = new DataGridViewCheckBoxColumn();
            chkboxColumn.HeaderText = "";
            chkboxColumn.Width = 30;
            chkboxColumn.Name = "chkboxColumn";
            dg_FileList.Columns.Insert(0, chkboxColumn);
        }
    }
}
