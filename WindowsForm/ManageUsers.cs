using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void PopulateTable()
        {
            using (dbDataContext db = new dbDataContext())
            {
                var users = (from u in db.users
                            join r in db.roles on u.roleID equals r.id
                            select new {u.id, u.username, u.isActive, r.name}).ToList();

                dg_UserList.DataSource = users;
                dg_UserList.Columns["id"].Visible = false;
                dg_UserList.Columns["username"].HeaderText = "Username";
                dg_UserList.Columns["isActive"].HeaderText = "Active";
                dg_UserList.Columns["name"].HeaderText = "Role";

                dg_UserList.Refresh();
            }
        }

        private void btn_addNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            PopulateTable();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            try
            {
                bool selectRow = false;

                foreach (DataGridViewRow dr in dg_UserList.Rows)
                {
                    bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                    if (chkboxSelected)
                    {
                        int id = Convert.ToInt32(dr.Cells["id"].Value);

                        ChangePassword changePassword = new ChangePassword(id);
                        changePassword.ShowDialog();

                        selectRow = true;
                    }
                }

                if (dg_UserList.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dg_UserList.SelectedRows[0].Cells["id"].Value);

                    ChangePassword changePassword = new ChangePassword(id);
                    changePassword.ShowDialog();

                    selectRow = true;
                }

                if (selectRow)
                {
                    PopulateTable();
                }
                else
                {
                    MessageBox.Show("Select a user first!");
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void changeActiveMode(dbDataContext db, int id)
        {
            user user = (from u in db.users
                         where u.id == id
                         select u).FirstOrDefault();

            user.isActive = user.isActive == 1 ? 0 : 1;
        }

        private void btn_activateDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbDataContext db = new dbDataContext())
                {
                    bool selectRow = false;

                    foreach (DataGridViewRow dr in dg_UserList.Rows)
                    {
                        bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                        if (chkboxSelected)
                        {
                            int id = Convert.ToInt32(dr.Cells["id"].Value);

                            changeActiveMode(db, id);

                            selectRow = true;
                        }
                    }

                    if (dg_UserList.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(dg_UserList.SelectedRows[0].Cells["id"].Value);

                        changeActiveMode(db, id);

                        selectRow = true;
                    }

                    if (!selectRow)
                    {
                        MessageBox.Show("Select a user first!");
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

        private void deleteUser(dbDataContext db, int id)
        {
            user user = (from u in db.users
                           where u.id == id
                           select u).FirstOrDefault();

            DialogResult dialogR = MessageBox.Show($"Do you want to delete this user: {user.username}?", "Remove Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dialogR)
            {
                db.users.DeleteOnSubmit(user);
            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbDataContext db = new dbDataContext())
                {
                    bool selectRow = false;

                    foreach (DataGridViewRow dr in dg_UserList.Rows)
                    {
                        bool chkboxSelected = Convert.ToBoolean(dr.Cells["chkboxColumn"].Value);

                        if (chkboxSelected)
                        {
                            int id = Convert.ToInt32(dr.Cells["id"].Value);

                            deleteUser(db, id);

                            selectRow = true;
                        }
                    }

                    if (dg_UserList.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(dg_UserList.SelectedRows[0].Cells["id"].Value);

                        deleteUser(db, id);

                        selectRow = true;
                    }

                    if (!selectRow)
                    {
                        MessageBox.Show("Select a user first!");
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateTable();

            DataGridViewCheckBoxColumn chkboxColumn = new DataGridViewCheckBoxColumn();
            chkboxColumn.HeaderText = "";
            chkboxColumn.Width = 30;
            chkboxColumn.Name = "chkboxColumn";
            dg_UserList.Columns.Insert(0, chkboxColumn);
        }
    }
}
