
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
            this.iDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.iDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.iDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quáTrìnhNângLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNguoiDung = new System.Windows.Forms.TextBox();
            this.txtThoiDiemDangNhap = new System.Windows.Forms.TextBox();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.iDanhMuc,
            this.iNghiepVu,
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
            this.chươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDangNhap,
            this.iDangXuat,
            this.dữLiệuToolStripMenuItem});
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // iDangNhap
            // 
            this.iDangNhap.Name = "iDangNhap";
            this.iDangNhap.Size = new System.Drawing.Size(224, 26);
            this.iDangNhap.Text = "Đăng Nhập";
            this.iDangNhap.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // iDangXuat
            // 
            this.iDangXuat.Name = "iDangXuat";
            this.iDangXuat.Size = new System.Drawing.Size(224, 26);
            this.iDangXuat.Text = "Đăng Xuất";
            this.iDangXuat.Click += new System.EventHandler(this.iDangXuat_Click);
            // 
            // iDanhMuc
            // 
            this.iDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.iDanhMuc.Name = "iDanhMuc";
            this.iDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.iDanhMuc.Text = "Danh mục";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // iNghiepVu
            // 
            this.iNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngLươngToolStripMenuItem,
            this.quáTrìnhNângLươngToolStripMenuItem});
            this.iNghiepVu.Name = "iNghiepVu";
            this.iNghiepVu.Size = new System.Drawing.Size(91, 24);
            this.iNghiepVu.Text = "Nghiệp vụ";
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
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // txtNguoiDung
            // 
            this.txtNguoiDung.Location = new System.Drawing.Point(12, 84);
            this.txtNguoiDung.Name = "txtNguoiDung";
            this.txtNguoiDung.Size = new System.Drawing.Size(313, 22);
            this.txtNguoiDung.TabIndex = 1;
            // 
            // txtThoiDiemDangNhap
            // 
            this.txtThoiDiemDangNhap.Location = new System.Drawing.Point(331, 84);
            this.txtThoiDiemDangNhap.Name = "txtThoiDiemDangNhap";
            this.txtThoiDiemDangNhap.Size = new System.Drawing.Size(285, 22);
            this.txtThoiDiemDangNhap.TabIndex = 2;
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // dữLiệuToolStripMenuItem
            // 
            this.dữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.phụcHồiToolStripMenuItem});
            this.dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            this.dữLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dữLiệuToolStripMenuItem.Text = "Dữ Liệu";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saoLưuToolStripMenuItem.Text = "Sao Lưu";
            this.saoLưuToolStripMenuItem.Click += new System.EventHandler(this.saoLưuToolStripMenuItem_Click);
            // 
            // phụcHồiToolStripMenuItem
            // 
            this.phụcHồiToolStripMenuItem.Name = "phụcHồiToolStripMenuItem";
            this.phụcHồiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phụcHồiToolStripMenuItem.Text = "Phục Hồi";
            this.phụcHồiToolStripMenuItem.Click += new System.EventHandler(this.phụcHồiToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.txtThoiDiemDangNhap);
            this.Controls.Add(this.txtNguoiDung);
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
        private System.Windows.Forms.ToolStripMenuItem iDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quáTrìnhNângLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDangNhap;
        private System.Windows.Forms.ToolStripMenuItem iDangXuat;
        private System.Windows.Forms.TextBox txtNguoiDung;
        private System.Windows.Forms.TextBox txtThoiDiemDangNhap;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
    }
}