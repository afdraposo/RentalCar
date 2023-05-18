using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class ChangePassword : Form
    {
        private readonly int _id;

        public ChangePassword(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string password = tb_password.Text;
                string reenterPassword = tb_reenterPassword.Text;

                bool isValid = true;
                string errorMessage = "";

                if (string.IsNullOrWhiteSpace(password) && string.IsNullOrWhiteSpace(reenterPassword))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n";
                }

                if (password.Length < 5 && password.Length > 50)
                {
                    isValid = false;
                    errorMessage += "Error: Please enter a password with more than 5 characters and less than 50.\n";
                }

                if (password != reenterPassword)
                {
                    isValid = false;
                    errorMessage += "Error: Please repeat the same password.\n";
                }

                if (isValid)
                {
                    string hashed_password = Utils.HashPassword(password);

                    using (dbDataContext db = new dbDataContext())
                    {
                        user user = (from u in db.users
                                     where u.id == _id
                                     select u).FirstOrDefault();
                        user.password = hashed_password;

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
