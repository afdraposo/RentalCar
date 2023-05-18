using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_username.Text;
                string password = tb_password.Text;
                string reenterPassword = tb_reenterPassword.Text;

                int roleID = Convert.ToInt32(cb_role.SelectedValue);

                bool isValid = true;
                string errorMessage = "";

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(reenterPassword))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n";
                }

                if (!string.IsNullOrWhiteSpace(username))
                {
                    if (username.Length < 5 || username.Length > 50)
                    {
                        isValid = false;
                        errorMessage += "Error: Please enter a username with more than 5 characters and less than 50.\n";
                    }
                    else
                    {
                        using (dbDataContext db = new dbDataContext())
                        {
                            var user = (from u in db.users
                                        where u.username == username
                                        select u).FirstOrDefault();

                            if (user != null)
                            {
                                isValid = false;
                                errorMessage += "Error: This username already exists.\n";
                            }
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(reenterPassword))
                {
                    if (password.Length < 5 || password.Length > 50)
                    {
                        isValid = false;
                        errorMessage += "Error: Please enter a password with more than 5 characters and less than 50.\n";
                    }

                    if (password != reenterPassword)
                    {
                        isValid = false;
                        errorMessage += "Error: Please repeat the same password.\n";
                    }
                }

                if (isValid)
                {
                    string hashed_password = Utils.HashPassword(password);

                    using (dbDataContext db = new dbDataContext())
                    {
                        user user = new user();

                        user.username = username;
                        user.password = hashed_password;
                        user.isActive = 1;
                        user.roleID = roleID;

                        db.users.InsertOnSubmit(user);

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

        private void AddUser_Load(object sender, EventArgs e)
        {
            using (dbDataContext db = new dbDataContext())
            {
                var roles = (from r in db.roles
                               select r).ToList();

                cb_role.DataSource = roles;
                cb_role.DisplayMember = "name";
                cb_role.ValueMember = "id";
            }
        }
    }
}
