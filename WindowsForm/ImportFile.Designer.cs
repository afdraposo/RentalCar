namespace WindowsForm
{
    partial class ImportFile
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_deleteRow = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.dg_FileList = new System.Windows.Forms.DataGridView();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_FileList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(768, 25);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(76, 25);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(687, 734);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(157, 52);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_deleteRow
            // 
            this.btn_deleteRow.Location = new System.Drawing.Point(357, 734);
            this.btn_deleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteRow.Name = "btn_deleteRow";
            this.btn_deleteRow.Size = new System.Drawing.Size(157, 52);
            this.btn_deleteRow.TabIndex = 11;
            this.btn_deleteRow.Text = "Delete Row";
            this.btn_deleteRow.UseVisualStyleBackColor = true;
            this.btn_deleteRow.Click += new System.EventHandler(this.btn_deleteRow_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(32, 734);
            this.btn_import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(157, 52);
            this.btn_import.TabIndex = 9;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // dg_FileList
            // 
            this.dg_FileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_FileList.Location = new System.Drawing.Point(31, 68);
            this.dg_FileList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_FileList.Name = "dg_FileList";
            this.dg_FileList.RowHeadersWidth = 51;
            this.dg_FileList.RowTemplate.Height = 24;
            this.dg_FileList.Size = new System.Drawing.Size(813, 640);
            this.dg_FileList.TabIndex = 7;
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(101, 26);
            this.tb_fileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.ReadOnly = true;
            this.tb_fileName.Size = new System.Drawing.Size(650, 22);
            this.tb_fileName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "File Path:";
            // 
            // ImportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 814);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_deleteRow);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.dg_FileList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImportFile";
            this.Text = "Import File";
            this.Load += new System.EventHandler(this.ImportFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_FileList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_deleteRow;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.DataGridView dg_FileList;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label label1;
    }
}