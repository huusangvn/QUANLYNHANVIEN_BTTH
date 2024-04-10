
namespace GUI
{
    partial class frmNhanVien
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
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.txtTimHoLot = new System.Windows.Forms.TextBox();
            this.radTimTheoHoTen = new System.Windows.Forms.RadioButton();
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radTimTheoMA = new System.Windows.Forms.RadioButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(12, 350);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersWidth = 51;
            this.dtgvNhanVien.RowTemplate.Height = 24;
            this.dtgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhanVien.Size = new System.Drawing.Size(595, 319);
            this.dtgvNhanVien.TabIndex = 0;
            this.dtgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellContentClick);
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(310, 40);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(171, 24);
            this.cbChucVu.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(243, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Chức Vụ";
            this.label.Click += new System.EventHandler(this.cbChucVu_Click);
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(93, 40);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(100, 22);
            this.txtMaSo.TabIndex = 3;
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(93, 68);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(232, 22);
            this.txtHoLot.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(331, 68);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 22);
            this.txtTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Số";
            this.label1.Click += new System.EventHandler(this.cbChucVu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            this.label2.Click += new System.EventHandler(this.cbChucVu_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(518, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 27);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(518, 58);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 27);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(518, 91);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 27);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(93, 110);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 5;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(157, 110);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 5;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phái";
            this.label3.Click += new System.EventHandler(this.cbChucVu_Click);
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.Location = new System.Drawing.Point(291, 110);
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.Size = new System.Drawing.Size(190, 22);
            this.dNgaySinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            this.label4.Click += new System.EventHandler(this.cbChucVu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimTen);
            this.groupBox1.Controls.Add(this.txtTimHoLot);
            this.groupBox1.Controls.Add(this.radTimTheoHoTen);
            this.groupBox1.Controls.Add(this.radTimTheoTen);
            this.groupBox1.Controls.Add(this.radTimTheoMA);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(342, 106);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(100, 22);
            this.txtTimTen.TabIndex = 8;
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // txtTimHoLot
            // 
            this.txtTimHoLot.Location = new System.Drawing.Point(17, 106);
            this.txtTimHoLot.Name = "txtTimHoLot";
            this.txtTimHoLot.Size = new System.Drawing.Size(296, 22);
            this.txtTimHoLot.TabIndex = 7;
            this.txtTimHoLot.TextChanged += new System.EventHandler(this.txtTimHoLot_TextChanged);
            // 
            // radTimTheoHoTen
            // 
            this.radTimTheoHoTen.AutoSize = true;
            this.radTimTheoHoTen.Location = new System.Drawing.Point(50, 79);
            this.radTimTheoHoTen.Name = "radTimTheoHoTen";
            this.radTimTheoHoTen.Size = new System.Drawing.Size(140, 21);
            this.radTimTheoHoTen.TabIndex = 6;
            this.radTimTheoHoTen.TabStop = true;
            this.radTimTheoHoTen.Text = "Tìm Theo Họ Tên";
            this.radTimTheoHoTen.UseVisualStyleBackColor = true;
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(50, 53);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(118, 21);
            this.radTimTheoTen.TabIndex = 6;
            this.radTimTheoTen.TabStop = true;
            this.radTimTheoTen.Text = "Tìm Theo Tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radTimTheoMA
            // 
            this.radTimTheoMA.AutoSize = true;
            this.radTimTheoMA.Location = new System.Drawing.Point(50, 21);
            this.radTimTheoMA.Name = "radTimTheoMA";
            this.radTimTheoMA.Size = new System.Drawing.Size(112, 21);
            this.radTimTheoMA.TabIndex = 6;
            this.radTimTheoMA.TabStop = true;
            this.radTimTheoMA.Text = "Tìm Theo Mã";
            this.radTimTheoMA.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(200, 38);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(265, 22);
            this.txtTim.TabIndex = 3;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = true;
            this.btnTim.Location = new System.Drawing.Point(471, 36);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 27);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dNgaySinh);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.dtgvNhanVien);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radTimTheoMA;
        private System.Windows.Forms.RadioButton radTimTheoHoTen;
        private System.Windows.Forms.TextBox txtTimHoLot;
        private System.Windows.Forms.TextBox txtTimTen;
    }
}