
namespace GUI
{
    partial class frm_QuaTrinhLuong
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
            this.dtgvQuaTrinhLuong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuaTrinhLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvQuaTrinhLuong
            // 
            this.dtgvQuaTrinhLuong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvQuaTrinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuaTrinhLuong.Location = new System.Drawing.Point(12, 146);
            this.dtgvQuaTrinhLuong.Name = "dtgvQuaTrinhLuong";
            this.dtgvQuaTrinhLuong.RowHeadersWidth = 51;
            this.dtgvQuaTrinhLuong.RowTemplate.Height = 24;
            this.dtgvQuaTrinhLuong.Size = new System.Drawing.Size(783, 292);
            this.dtgvQuaTrinhLuong.TabIndex = 0;
            this.dtgvQuaTrinhLuong.UseWaitCursor = true;
            this.dtgvQuaTrinhLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQuaTrinhLuong_CellContentClick);
            // 
            // frm_QuaTrinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvQuaTrinhLuong);
            this.Name = "frm_QuaTrinhLuong";
            this.Text = "frm_QuaTrinhLuong";
            this.Load += new System.EventHandler(this.frm_QuaTrinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuaTrinhLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvQuaTrinhLuong;
    }
}