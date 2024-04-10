
namespace GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quáTrìnhNângLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngLươngToolStripMenuItem,
            this.quáTrìnhNângLươngToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // bảngLươngToolStripMenuItem
            // 
            this.bảngLươngToolStripMenuItem.Name = "bảngLươngToolStripMenuItem";
            this.bảngLươngToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.bảngLươngToolStripMenuItem.Text = "Bảng Lương";
            // 
            // quáTrìnhNângLươngToolStripMenuItem
            // 
            this.quáTrìnhNângLươngToolStripMenuItem.Name = "quáTrìnhNângLươngToolStripMenuItem";
            this.quáTrìnhNângLươngToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.quáTrìnhNângLươngToolStripMenuItem.Text = "Quá trình nâng lương";
            this.quáTrìnhNângLươngToolStripMenuItem.Click += new System.EventHandler(this.quáTrìnhNângLươngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quáTrìnhNângLươngToolStripMenuItem;
    }
}