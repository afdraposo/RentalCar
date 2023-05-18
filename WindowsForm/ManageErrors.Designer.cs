namespace WindowsForm
{
    partial class ManageErrors
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
            this.btn_deleteError = new System.Windows.Forms.Button();
            this.btn_recoverRow = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dg_ErrorList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ErrorList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(772, 45);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(76, 25);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(690, 749);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(157, 52);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_deleteError
            // 
            this.btn_deleteError.Location = new System.Drawing.Point(363, 749);
            this.btn_deleteError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteError.Name = "btn_deleteError";
            this.btn_deleteError.Size = new System.Drawing.Size(157, 52);
            this.btn_deleteError.TabIndex = 11;
            this.btn_deleteError.Text = "Delete Error";
            this.btn_deleteError.UseVisualStyleBackColor = true;
            this.btn_deleteError.Click += new System.EventHandler(this.btn_deleteError_Click);
            // 
            // btn_recoverRow
            // 
            this.btn_recoverRow.Location = new System.Drawing.Point(34, 749);
            this.btn_recoverRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_recoverRow.Name = "btn_recoverRow";
            this.btn_recoverRow.Size = new System.Drawing.Size(157, 52);
            this.btn_recoverRow.TabIndex = 10;
            this.btn_recoverRow.Text = "Recover Row";
            this.btn_recoverRow.UseVisualStyleBackColor = true;
            this.btn_recoverRow.Click += new System.EventHandler(this.btn_recoverRow_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Adventure", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(244, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(339, 50);
            this.label.TabIndex = 8;
            this.label.Text = "Manage Error List";
            // 
            // dg_ErrorList
            // 
            this.dg_ErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ErrorList.Location = new System.Drawing.Point(34, 83);
            this.dg_ErrorList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_ErrorList.Name = "dg_ErrorList";
            this.dg_ErrorList.RowHeadersWidth = 51;
            this.dg_ErrorList.RowTemplate.Height = 24;
            this.dg_ErrorList.Size = new System.Drawing.Size(813, 640);
            this.dg_ErrorList.TabIndex = 7;
            this.dg_ErrorList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_ErrorList_RowHeaderMouseDoubleClick);
            // 
            // ManageErrors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 822);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_deleteError);
            this.Controls.Add(this.btn_recoverRow);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dg_ErrorList);
            this.Name = "ManageErrors";
            this.Text = "Manage Error List";
            this.Load += new System.EventHandler(this.ManageErrors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ErrorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_deleteError;
        private System.Windows.Forms.Button btn_recoverRow;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dg_ErrorList;
    }
}