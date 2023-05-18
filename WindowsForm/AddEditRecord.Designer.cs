namespace WindowsForm
{
    partial class AddEditRecord
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
            this.label_addEditVehicle = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_customer = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_dateReturned = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_car = new System.Windows.Forms.ComboBox();
            this.dtp_dateRented = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_addEditVehicle
            // 
            this.label_addEditVehicle.AutoSize = true;
            this.label_addEditVehicle.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addEditVehicle.Location = new System.Drawing.Point(299, 23);
            this.label_addEditVehicle.Name = "label_addEditVehicle";
            this.label_addEditVehicle.Size = new System.Drawing.Size(0, 50);
            this.label_addEditVehicle.TabIndex = 9;
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(330, 159);
            this.tb_cost.MaxLength = 50;
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(322, 22);
            this.tb_cost.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Returned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Rented";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // tb_customer
            // 
            this.tb_customer.Location = new System.Drawing.Point(330, 3);
            this.tb_customer.MaxLength = 100;
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(322, 22);
            this.tb_customer.TabIndex = 9;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(573, 376);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(157, 52);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(75, 376);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(157, 52);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtp_dateReturned, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_cost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_customer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_car, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtp_dateRented, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 262);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dtp_dateReturned
            // 
            this.dtp_dateReturned.Location = new System.Drawing.Point(330, 107);
            this.dtp_dateReturned.Name = "dtp_dateReturned";
            this.dtp_dateReturned.Size = new System.Drawing.Size(322, 22);
            this.dtp_dateReturned.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Car";
            // 
            // cb_car
            // 
            this.cb_car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_car.FormattingEnabled = true;
            this.cb_car.Location = new System.Drawing.Point(330, 211);
            this.cb_car.Name = "cb_car";
            this.cb_car.Size = new System.Drawing.Size(322, 24);
            this.cb_car.TabIndex = 14;
            // 
            // dtp_dateRented
            // 
            this.dtp_dateRented.Location = new System.Drawing.Point(330, 55);
            this.dtp_dateRented.Name = "dtp_dateRented";
            this.dtp_dateRented.Size = new System.Drawing.Size(322, 22);
            this.dtp_dateRented.TabIndex = 15;
            // 
            // AddEditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_addEditVehicle);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditRentalRecord";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_addEditVehicle;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_customer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtp_dateReturned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_car;
        private System.Windows.Forms.DateTimePicker dtp_dateRented;
    }
}

