
namespace GUI
{
    partial class frmChucVu
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
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(12, 205);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.Size = new System.Drawing.Size(763, 233);
            this.dtgvChucVu.TabIndex = 0;
            this.dtgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChucVu_CellContentClick);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvChucVu);
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChucVu;
    }
}