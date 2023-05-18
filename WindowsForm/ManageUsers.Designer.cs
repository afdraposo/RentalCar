namespace WindowsForm
{
    partial class ManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.btn_addNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_UserList = new System.Windows.Forms.DataGridView();
            this.btn_activateDeactivateUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(576, 35);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(57, 20);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(535, 603);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 42);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Location = new System.Drawing.Point(405, 603);
            this.btn_deleteUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(98, 42);
            this.btn_deleteUser.TabIndex = 11;
            this.btn_deleteUser.Text = "Delete User";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(149, 603);
            this.btn_changePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(98, 42);
            this.btn_changePassword.TabIndex = 10;
            this.btn_changePassword.Text = "Change Password";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // btn_addNewUser
            // 
            this.btn_addNewUser.Location = new System.Drawing.Point(23, 603);
            this.btn_addNewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addNewUser.Name = "btn_addNewUser";
            this.btn_addNewUser.Size = new System.Drawing.Size(98, 42);
            this.btn_addNewUser.TabIndex = 9;
            this.btn_addNewUser.Text = "Add New User";
            this.btn_addNewUser.UseVisualStyleBackColor = true;
            this.btn_addNewUser.Click += new System.EventHandler(this.btn_addNewUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Users";
            // 
            // dg_UserList
            // 
            this.dg_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_UserList.Location = new System.Drawing.Point(23, 65);
            this.dg_UserList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_UserList.Name = "dg_UserList";
            this.dg_UserList.RowHeadersWidth = 51;
            this.dg_UserList.RowTemplate.Height = 24;
            this.dg_UserList.Size = new System.Drawing.Size(610, 520);
            this.dg_UserList.TabIndex = 7;
            // 
            // btn_activateDeactivateUser
            // 
            this.btn_activateDeactivateUser.Location = new System.Drawing.Point(279, 603);
            this.btn_activateDeactivateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_activateDeactivateUser.Name = "btn_activateDeactivateUser";
            this.btn_activateDeactivateUser.Size = new System.Drawing.Size(98, 42);
            this.btn_activateDeactivateUser.TabIndex = 15;
            this.btn_activateDeactivateUser.Text = "Activate / Desactivate User";
            this.btn_activateDeactivateUser.UseVisualStyleBackColor = true;
            this.btn_activateDeactivateUser.Click += new System.EventHandler(this.btn_activateDeactivateUser_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 661);
            this.Controls.Add(this.btn_activateDeactivateUser);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.btn_addNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_UserList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Button btn_addNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_UserList;
        private System.Windows.Forms.Button btn_activateDeactivateUser;
    }
}