namespace WindowsForm
{
    partial class AddEditVehicle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_licensePlate = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label_addEditVehicle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_licensePlate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_year, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_model, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_licensePlate
            // 
            this.tb_licensePlate.Location = new System.Drawing.Point(330, 198);
            this.tb_licensePlate.MaxLength = 8;
            this.tb_licensePlate.Name = "tb_licensePlate";
            this.tb_licensePlate.Size = new System.Drawing.Size(322, 22);
            this.tb_licensePlate.TabIndex = 12;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(330, 133);
            this.tb_year.MaxLength = 4;
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(322, 22);
            this.tb_year.TabIndex = 11;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(330, 68);
            this.tb_model.MaxLength = 50;
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(322, 22);
            this.tb_model.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "License Plate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(330, 3);
            this.tb_name.MaxLength = 50;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(322, 22);
            this.tb_name.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(74, 374);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(157, 52);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(572, 374);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(157, 52);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label_addEditVehicle
            // 
            this.label_addEditVehicle.AutoSize = true;
            this.label_addEditVehicle.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addEditVehicle.Location = new System.Drawing.Point(298, 21);
            this.label_addEditVehicle.Name = "label_addEditVehicle";
            this.label_addEditVehicle.Size = new System.Drawing.Size(0, 50);
            this.label_addEditVehicle.TabIndex = 5;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_addEditVehicle);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditVehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_licensePlate;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_addEditVehicle;
    }
}