using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public user _userLogin;
        public MainWindow(Login login, user userLogin)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            _login = login;
            _userLogin = userLogin;
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVehicleList manageVehicleList = new ManageVehicleList(_userLogin);
            //manageVehicleList.MdiParent = this; --> Restrains from inside of parent form
            manageVehicleList.ShowDialog();

        }

        private void manageRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRentalRecords manageRentalRecords = new ManageRentalRecords(_userLogin);
            manageRentalRecords.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
        }

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Browse text file",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePathFile = openFileDialog.FileName;
                string fileName = Path.GetFileName(sourcePathFile);

                try
                {
                    ImportFile importFile = new ImportFile(openFileDialog);
                    importFile.ShowDialog();

                    string destinationPath = "C:\\RentalCar\\Ficheiros\\Importados";
                    string destinationPathFile = $"C:\\RentalCar\\Ficheiros\\Importados\\{fileName}";

                    Utils.CopyFile(sourcePathFile, destinationPath, destinationPathFile);
                }
                catch (Exception ex)
                {
                    string destinationPath = "C:\\RentalCar\\Ficheiros\\Recebidos";
                    string destinationPathFile = $"C:\\RentalCar\\Ficheiros\\Recebidos\\{fileName}";

                    Utils.CopyFile(sourcePathFile, destinationPath, destinationPathFile);

                    Utils.LogError(ex.ToString());
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void manageErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageErrors manageErrors = new ManageErrors();
            manageErrors.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ts_user.Text = $"Logged in as: {_userLogin.username}";
            if (_userLogin.roleID != 1)
            {
                manageUsersToolStripMenuItem.Visible = false;
                importFileToolStripMenuItem.Visible = false;
                manageErrorsToolStripMenuItem.Visible = false;
            }
        }
    }
}
