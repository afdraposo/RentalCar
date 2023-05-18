using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class ManageErrors : Form
    {
        public ManageErrors()
        {
            InitializeComponent();
        }

        private void PopulateTable()
        {
            using (dbDataContext db = new dbDataContext())
            {
                var errors = (from eid in db.errorInsertDatas
                            select eid).ToList();

                dg_ErrorList.DataSource = errors;
                dg_ErrorList.Columns["id"].Visible = false;
                dg_ErrorList.Columns["errorLine"].HeaderText = "Line";
                dg_ErrorList.Columns["errorTable"].HeaderText = "Table";
                dg_ErrorList.Columns["errorMessage"].HeaderText = "Message";
                dg_ErrorList.Columns["nameFile"].HeaderText = "FileName";
                dg_ErrorList.Columns["errorDate"].HeaderText = "Date";

                dg_ErrorList.Refresh();
            }
        }

        private void btn_recoverRow_Click(object sender, EventArgs e)
        {
            try
            {
                bool selectRow = false;

                foreach (DataGridViewRow dr in dg_ErrorList.Rows)
                {
                    bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                    if (chkboxSelected)
                    {
                        int id = Convert.ToInt32(dr.Cells["id"].Value);

                        RecoverRow recoverRow = new RecoverRow(id);
                        recoverRow.ShowDialog();

                        selectRow = true;
                    }
                }

                if (dg_ErrorList.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dg_ErrorList.SelectedRows[0].Cells["id"].Value);

                    RecoverRow recoverRow = new RecoverRow(id);
                    recoverRow.ShowDialog();

                    selectRow = true;
                }

                if (!selectRow)
                {
                    MessageBox.Show("Select a row first!");
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

        private void deleteError(dbDataContext db, int id)
        {
            errorInsertData error = (from eid in db.errorInsertDatas
                           where eid.id == id
                           select eid).FirstOrDefault();

            DialogResult dialogR = MessageBox.Show($"Do you want to delete this error: {error.errorLine}?", "Remove Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dialogR)
            {
                db.errorInsertDatas.DeleteOnSubmit(error);
            }
        }

        private void btn_deleteError_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbDataContext db = new dbDataContext())
                {
                    bool selectRow = false;

                    foreach (DataGridViewRow dr in dg_ErrorList.Rows)
                    {
                        bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                        if (chkboxSelected)
                        {
                            int id = Convert.ToInt32(dr.Cells["id"].Value);

                            deleteError(db, id);

                            selectRow = true;
                        }
                    }

                    if (dg_ErrorList.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(dg_ErrorList.SelectedRows[0].Cells["id"].Value);

                        deleteError(db, id);

                        selectRow = true;
                    }

                    if (!selectRow)
                    {
                        MessageBox.Show("Select a row first!");
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

        private void dg_ErrorList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dg_ErrorList.SelectedRows[0].Cells["id"].Value);

                RecoverRow recoverRow = new RecoverRow(id);
                recoverRow.ShowDialog();

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

        private void ManageErrors_Load(object sender, EventArgs e)
        {
            PopulateTable();

            DataGridViewCheckBoxColumn chkboxColumn = new DataGridViewCheckBoxColumn();
            chkboxColumn.HeaderText = "";
            chkboxColumn.Width = 30;
            chkboxColumn.Name = "chkboxColumn";
            dg_ErrorList.Columns.Insert(0, chkboxColumn);
        }
    }
}
