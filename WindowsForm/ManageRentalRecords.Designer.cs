namespace WindowsForm
{
    partial class ManageRentalRecords
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
            this.btn_deleteRecord = new System.Windows.Forms.Button();
            this.btn_editRecord = new System.Windows.Forms.Button();
            this.btn_addNewRecord = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dg_RecordsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_RecordsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(576, 28);
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
            this.btn_cancel.Location = new System.Drawing.Point(515, 600);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 42);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_deleteRecord
            // 
            this.btn_deleteRecord.Location = new System.Drawing.Point(351, 600);
            this.btn_deleteRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deleteRecord.Name = "btn_deleteRecord";
            this.btn_deleteRecord.Size = new System.Drawing.Size(118, 42);
            this.btn_deleteRecord.TabIndex = 11;
            this.btn_deleteRecord.Text = "Delete Record";
            this.btn_deleteRecord.UseVisualStyleBackColor = true;
            this.btn_deleteRecord.Click += new System.EventHandler(this.btn_deleteRecord_Click);
            // 
            // btn_editRecord
            // 
            this.btn_editRecord.Location = new System.Drawing.Point(186, 600);
            this.btn_editRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_editRecord.Name = "btn_editRecord";
            this.btn_editRecord.Size = new System.Drawing.Size(118, 42);
            this.btn_editRecord.TabIndex = 10;
            this.btn_editRecord.Text = "Edit Record";
            this.btn_editRecord.UseVisualStyleBackColor = true;
            this.btn_editRecord.Click += new System.EventHandler(this.btn_editRecord_Click);
            // 
            // btn_addNewRecord
            // 
            this.btn_addNewRecord.Location = new System.Drawing.Point(23, 600);
            this.btn_addNewRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addNewRecord.Name = "btn_addNewRecord";
            this.btn_addNewRecord.Size = new System.Drawing.Size(118, 42);
            this.btn_addNewRecord.TabIndex = 9;
            this.btn_addNewRecord.Text = "Add New Record";
            this.btn_addNewRecord.UseVisualStyleBackColor = true;
            this.btn_addNewRecord.Click += new System.EventHandler(this.btn_addNewRecord_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(152, 9);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(331, 40);
            this.label.TabIndex = 8;
            this.label.Text = "Manage Rental Records";
            // 
            // dg_RecordsList
            // 
            this.dg_RecordsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_RecordsList.Location = new System.Drawing.Point(23, 60);
            this.dg_RecordsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_RecordsList.Name = "dg_RecordsList";
            this.dg_RecordsList.RowHeadersWidth = 51;
            this.dg_RecordsList.RowTemplate.Height = 24;
            this.dg_RecordsList.Size = new System.Drawing.Size(610, 520);
            this.dg_RecordsList.TabIndex = 7;
            this.dg_RecordsList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_RecordsList_RowHeaderMouseDoubleClick);
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(659, 661);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_deleteRecord);
            this.Controls.Add(this.btn_editRecord);
            this.Controls.Add(this.btn_addNewRecord);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dg_RecordsList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageRentalRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_RecordsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_deleteRecord;
        private System.Windows.Forms.Button btn_editRecord;
        private System.Windows.Forms.Button btn_addNewRecord;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dg_RecordsList;
    }
}