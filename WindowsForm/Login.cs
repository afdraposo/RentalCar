using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_username.Text.Trim(); //Trim() - remove any white space
                string password = tb_password.Text;

                string hashed_password = Utils.HashPassword(password);

                using (dbDataContext db = new dbDataContext())
                {
                    var user = (from u in db.users
                                where u.username == username && u.password == hashed_password && u.isActive == 1
                                 select u).FirstOrDefault();

                    if (user == null)
                    {
                        MessageBox.Show("Credentials incorrect!");
                    }
                    else
                    {
                        MainWindow mainWindow = new MainWindow(this, user);
                        mainWindow.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex.ToString());
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
