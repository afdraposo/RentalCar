namespace WindowsForm
{
    partial class RecoverRow
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.table_car = new System.Windows.Forms.TableLayoutPanel();
            this.tb_licensePlate = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_row = new System.Windows.Forms.TextBox();
            this.tb_table = new System.Windows.Forms.TextBox();
            this.table_record = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_dateReturned = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_customer = new System.Windows.Forms.TextBox();
            this.cb_car = new System.Windows.Forms.ComboBox();
            this.dtp_dateRented = new System.Windows.Forms.DateTimePicker();
            this.table_car.SuspendLayout();
            this.table_record.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(425, 303);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 42);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(52, 303);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 42);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // table_car
            // 
            this.table_car.ColumnCount = 2;
            this.table_car.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_car.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_car.Controls.Add(this.tb_licensePlate, 1, 3);
            this.table_car.Controls.Add(this.tb_year, 1, 2);
            this.table_car.Controls.Add(this.tb_model, 1, 1);
            this.table_car.Controls.Add(this.label7, 0, 3);
            this.table_car.Controls.Add(this.label5, 0, 2);
            this.table_car.Controls.Add(this.label3, 0, 1);
            this.table_car.Controls.Add(this.label1, 0, 0);
            this.table_car.Controls.Add(this.tb_name, 1, 0);
            this.table_car.Location = new System.Drawing.Point(52, 71);
            this.table_car.Margin = new System.Windows.Forms.Padding(2);
            this.table_car.Name = "table_car";
            this.table_car.RowCount = 4;
            this.table_car.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_car.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_car.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_car.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_car.Size = new System.Drawing.Size(491, 213);
            this.table_car.TabIndex = 5;
            // 
            // tb_licensePlate
            // 
            this.tb_licensePlate.Location = new System.Drawing.Point(247, 161);
            this.tb_licensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.tb_licensePlate.MaxLength = 8;
            this.tb_licensePlate.Name = "tb_licensePlate";
            this.tb_licensePlate.Size = new System.Drawing.Size(242, 20);
            this.tb_licensePlate.TabIndex = 12;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(247, 108);
            this.tb_year.Margin = new System.Windows.Forms.Padding(2);
            this.tb_year.MaxLength = 4;
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(242, 20);
            this.tb_year.TabIndex = 11;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(247, 55);
            this.tb_model.Margin = new System.Windows.Forms.Padding(2);
            this.tb_model.MaxLength = 50;
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(242, 20);
            this.tb_model.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "License Plate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(247, 2);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.MaxLength = 50;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(242, 20);
            this.tb_name.TabIndex = 9;
            // 
            // tb_row
            // 
            this.tb_row.Location = new System.Drawing.Point(146, 26);
            this.tb_row.Name = "tb_row";
            this.tb_row.ReadOnly = true;
            this.tb_row.Size = new System.Drawing.Size(397, 20);
            this.tb_row.TabIndex = 8;
            this.tb_row.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_table
            // 
            this.tb_table.Location = new System.Drawing.Point(52, 26);
            this.tb_table.Name = "tb_table";
            this.tb_table.ReadOnly = true;
            this.tb_table.Size = new System.Drawing.Size(88, 20);
            this.tb_table.TabIndex = 9;
            this.tb_table.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // table_record
            // 
            this.table_record.ColumnCount = 2;
            this.table_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_record.Controls.Add(this.dtp_dateReturned, 1, 2);
            this.table_record.Controls.Add(this.label2, 0, 4);
            this.table_record.Controls.Add(this.tb_cost, 1, 3);
            this.table_record.Controls.Add(this.label4, 0, 3);
            this.table_record.Controls.Add(this.label6, 0, 2);
            this.table_record.Controls.Add(this.label8, 0, 1);
            this.table_record.Controls.Add(this.label9, 0, 0);
            this.table_record.Controls.Add(this.tb_customer, 1, 0);
            this.table_record.Controls.Add(this.cb_car, 1, 4);
            this.table_record.Controls.Add(this.dtp_dateRented, 1, 1);
            this.table_record.Location = new System.Drawing.Point(50, 71);
            this.table_record.Margin = new System.Windows.Forms.Padding(2);
            this.table_record.Name = "table_record";
            this.table_record.RowCount = 5;
            this.table_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_record.Size = new System.Drawing.Size(491, 213);
            this.table_record.TabIndex = 10;
            // 
            // dtp_dateReturned
            // 
            this.dtp_dateReturned.Location = new System.Drawing.Point(247, 86);
            this.dtp_dateReturned.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dateReturned.Name = "dtp_dateReturned";
            this.dtp_dateReturned.Size = new System.Drawing.Size(242, 20);
            this.dtp_dateReturned.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Car";
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(247, 128);
            this.tb_cost.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cost.MaxLength = 50;
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(242, 20);
            this.tb_cost.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date Returned";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date Rented";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customer";
            // 
            // tb_customer
            // 
            this.tb_customer.Location = new System.Drawing.Point(247, 2);
            this.tb_customer.Margin = new System.Windows.Forms.Padding(2);
            this.tb_customer.MaxLength = 100;
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(242, 20);
            this.tb_customer.TabIndex = 9;
            // 
            // cb_car
            // 
            this.cb_car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_car.FormattingEnabled = true;
            this.cb_car.Location = new System.Drawing.Point(247, 170);
            this.cb_car.Margin = new System.Windows.Forms.Padding(2);
            this.cb_car.Name = "cb_car";
            this.cb_car.Size = new System.Drawing.Size(242, 21);
            this.cb_car.TabIndex = 14;
            // 
            // dtp_dateRented
            // 
            this.dtp_dateRented.Location = new System.Drawing.Point(247, 44);
            this.dtp_dateRented.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dateRented.Name = "dtp_dateRented";
            this.dtp_dateRented.Size = new System.Drawing.Size(242, 20);
            this.dtp_dateRented.TabIndex = 15;
            // 
            // RecoverRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.table_record);
            this.Controls.Add(this.tb_table);
            this.Controls.Add(this.tb_row);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.table_car);
            this.Name = "RecoverRow";
            this.Text = "Recover Row";
            this.Load += new System.EventHandler(this.RecoverRow_Load);
            this.table_car.ResumeLayout(false);
            this.table_car.PerformLayout();
            this.table_record.ResumeLayout(false);
            this.table_record.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TableLayoutPanel table_car;
        private System.Windows.Forms.TextBox tb_licensePlate;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_row;
        private System.Windows.Forms.TextBox tb_table;
        private System.Windows.Forms.TableLayoutPanel table_record;
        private System.Windows.Forms.DateTimePicker dtp_dateReturned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_customer;
        private System.Windows.Forms.ComboBox cb_car;
        private System.Windows.Forms.DateTimePicker dtp_dateRented;
    }
}