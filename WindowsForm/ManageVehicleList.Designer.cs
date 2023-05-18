namespace WindowsForm
{
    partial class ManageVehicleList
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
            this.dg_VehicleList = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.btn_addNewCar = new System.Windows.Forms.Button();
            this.btn_editCar = new System.Windows.Forms.Button();
            this.btn_deleteCar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dg_VehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_VehicleList
            // 
            this.dg_VehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_VehicleList.Location = new System.Drawing.Point(29, 71);
            this.dg_VehicleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_VehicleList.Name = "dg_VehicleList";
            this.dg_VehicleList.RowHeadersWidth = 51;
            this.dg_VehicleList.RowTemplate.Height = 24;
            this.dg_VehicleList.Size = new System.Drawing.Size(813, 640);
            this.dg_VehicleList.TabIndex = 0;
            this.dg_VehicleList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_VehicleList_RowHeaderMouseDoubleClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(239, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(360, 50);
            this.label.TabIndex = 1;
            this.label.Text = "Manage Vehicle List";
            // 
            // btn_addNewCar
            // 
            this.btn_addNewCar.Location = new System.Drawing.Point(29, 737);
            this.btn_addNewCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addNewCar.Name = "btn_addNewCar";
            this.btn_addNewCar.Size = new System.Drawing.Size(157, 52);
            this.btn_addNewCar.TabIndex = 2;
            this.btn_addNewCar.Text = "Add New Car";
            this.btn_addNewCar.UseVisualStyleBackColor = true;
            this.btn_addNewCar.Click += new System.EventHandler(this.btn_addNewCar_Click);
            // 
            // btn_editCar
            // 
            this.btn_editCar.Location = new System.Drawing.Point(248, 737);
            this.btn_editCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editCar.Name = "btn_editCar";
            this.btn_editCar.Size = new System.Drawing.Size(157, 52);
            this.btn_editCar.TabIndex = 3;
            this.btn_editCar.Text = "Edit Car";
            this.btn_editCar.UseVisualStyleBackColor = true;
            this.btn_editCar.Click += new System.EventHandler(this.btn_editCar_Click);
            // 
            // btn_deleteCar
            // 
            this.btn_deleteCar.Location = new System.Drawing.Point(465, 737);
            this.btn_deleteCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteCar.Name = "btn_deleteCar";
            this.btn_deleteCar.Size = new System.Drawing.Size(157, 52);
            this.btn_deleteCar.TabIndex = 4;
            this.btn_deleteCar.Text = "Delete Car";
            this.btn_deleteCar.UseVisualStyleBackColor = true;
            this.btn_deleteCar.Click += new System.EventHandler(this.btn_deleteCar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(685, 737);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(157, 52);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(767, 33);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(76, 25);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ManageVehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 814);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_deleteCar);
            this.Controls.Add(this.btn_editCar);
            this.Controls.Add(this.btn_addNewCar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dg_VehicleList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageVehicleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicle List";
            this.Load += new System.EventHandler(this.ManageVehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_VehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_VehicleList;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_addNewCar;
        private System.Windows.Forms.Button btn_editCar;
        private System.Windows.Forms.Button btn_deleteCar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}