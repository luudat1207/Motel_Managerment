namespace QLNhaTro
{
    partial class FormLapHoanDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapHoanDon));
            this.checkBoxHopDongKetThuc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHopDong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.textBoxSoHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonKetThuc = new System.Windows.Forms.Button();
            this.buttonKhongGhi = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.comboBoxTinhTrangHoaDon = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonTinhTienHoaDon = new System.Windows.Forms.Button();
            this.buttonXoaSoLuong = new System.Windows.Forms.Button();
            this.textBoxSoTienKhachTra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTienPhat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTienGiam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewDichVu = new System.Windows.Forms.ListView();
            this.columnHeaderMaDV = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDichVu = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderGiaTien = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSoLuong = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderThanhTien = new System.Windows.Forms.ColumnHeader();
            this.textBoxGiaTienPhong = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxHopDongKetThuc
            // 
            resources.ApplyResources(this.checkBoxHopDongKetThuc, "checkBoxHopDongKetThuc");
            this.checkBoxHopDongKetThuc.Name = "checkBoxHopDongKetThuc";
            this.checkBoxHopDongKetThuc.UseVisualStyleBackColor = true;
            this.checkBoxHopDongKetThuc.CheckedChanged += new System.EventHandler(this.checkBoxHopDongKetThuc_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxTimKiem
            // 
            resources.ApplyResources(this.textBoxTimKiem, "textBoxTimKiem");
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridViewHopDong
            // 
            this.dataGridViewHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            resources.ApplyResources(this.dataGridViewHopDong, "dataGridViewHopDong");
            this.dataGridViewHopDong.Name = "dataGridViewHopDong";
            this.dataGridViewHopDong.RowTemplate.Height = 29;
            this.dataGridViewHopDong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHopDong_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoHopDong";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "htcn";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "htkh";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaPhong";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GiaThue";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewHoaDon, "dataGridViewHoaDon");
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowTemplate.Height = 29;
            this.dataGridViewHoaDon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHoaDon_CellMouseClick);
            // 
            // textBoxSoHD
            // 
            resources.ApplyResources(this.textBoxSoHD, "textBoxSoHD");
            this.textBoxSoHD.Name = "textBoxSoHD";
            this.textBoxSoHD.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxPhong
            // 
            resources.ApplyResources(this.textBoxPhong, "textBoxPhong");
            this.textBoxPhong.Name = "textBoxPhong";
            this.textBoxPhong.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxKhach
            // 
            resources.ApplyResources(this.textBoxKhach, "textBoxKhach");
            this.textBoxKhach.Name = "textBoxKhach";
            this.textBoxKhach.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.textBoxGhiChu);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.buttonKetThuc);
            this.groupBox1.Controls.Add(this.buttonKhongGhi);
            this.groupBox1.Controls.Add(this.buttonGhi);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonCapNhat);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.comboBoxTinhTrangHoaDon);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.buttonTinhTienHoaDon);
            this.groupBox1.Controls.Add(this.buttonXoaSoLuong);
            this.groupBox1.Controls.Add(this.textBoxSoTienKhachTra);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxTongTien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxTienPhat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxTienGiam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listViewDichVu);
            this.groupBox1.Controls.Add(this.textBoxGiaTienPhong);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBoxSoLuong
            // 
            resources.ApplyResources(this.textBoxSoLuong, "textBoxSoLuong");
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Leave += new System.EventHandler(this.textBoxSoLuong_Leave);
            // 
            // textBoxGhiChu
            // 
            resources.ApplyResources(this.textBoxGhiChu, "textBoxGhiChu");
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // buttonKetThuc
            // 
            resources.ApplyResources(this.buttonKetThuc, "buttonKetThuc");
            this.buttonKetThuc.Name = "buttonKetThuc";
            this.buttonKetThuc.UseVisualStyleBackColor = true;
            this.buttonKetThuc.Click += new System.EventHandler(this.buttonKetThuc_Click);
            // 
            // buttonKhongGhi
            // 
            resources.ApplyResources(this.buttonKhongGhi, "buttonKhongGhi");
            this.buttonKhongGhi.Name = "buttonKhongGhi";
            this.buttonKhongGhi.UseVisualStyleBackColor = true;
            this.buttonKhongGhi.Click += new System.EventHandler(this.buttonKhongGhi_Click);
            // 
            // buttonGhi
            // 
            resources.ApplyResources(this.buttonGhi, "buttonGhi");
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.UseVisualStyleBackColor = true;
            this.buttonGhi.Click += new System.EventHandler(this.buttonGhi_Click);
            // 
            // buttonXoa
            // 
            resources.ApplyResources(this.buttonXoa, "buttonXoa");
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCapNhat
            // 
            resources.ApplyResources(this.buttonCapNhat, "buttonCapNhat");
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonThem
            // 
            resources.ApplyResources(this.buttonThem, "buttonThem");
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // comboBoxTinhTrangHoaDon
            // 
            this.comboBoxTinhTrangHoaDon.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxTinhTrangHoaDon, "comboBoxTinhTrangHoaDon");
            this.comboBoxTinhTrangHoaDon.Name = "comboBoxTinhTrangHoaDon";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // buttonTinhTienHoaDon
            // 
            resources.ApplyResources(this.buttonTinhTienHoaDon, "buttonTinhTienHoaDon");
            this.buttonTinhTienHoaDon.Name = "buttonTinhTienHoaDon";
            this.buttonTinhTienHoaDon.UseVisualStyleBackColor = true;
            this.buttonTinhTienHoaDon.Click += new System.EventHandler(this.buttonTinhTienHoaDon_Click);
            // 
            // buttonXoaSoLuong
            // 
            resources.ApplyResources(this.buttonXoaSoLuong, "buttonXoaSoLuong");
            this.buttonXoaSoLuong.Name = "buttonXoaSoLuong";
            this.buttonXoaSoLuong.UseVisualStyleBackColor = true;
            this.buttonXoaSoLuong.Click += new System.EventHandler(this.buttonXoaSoLuong_Click);
            // 
            // textBoxSoTienKhachTra
            // 
            resources.ApplyResources(this.textBoxSoTienKhachTra, "textBoxSoTienKhachTra");
            this.textBoxSoTienKhachTra.Name = "textBoxSoTienKhachTra";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxTongTien
            // 
            resources.ApplyResources(this.textBoxTongTien, "textBoxTongTien");
            this.textBoxTongTien.Name = "textBoxTongTien";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBoxTienPhat
            // 
            resources.ApplyResources(this.textBoxTienPhat, "textBoxTienPhat");
            this.textBoxTienPhat.Name = "textBoxTienPhat";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // textBoxTienGiam
            // 
            resources.ApplyResources(this.textBoxTienGiam, "textBoxTienGiam");
            this.textBoxTienGiam.Name = "textBoxTienGiam";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // listViewDichVu
            // 
            this.listViewDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaDV,
            this.columnHeaderDichVu,
            this.columnHeaderGiaTien,
            this.columnHeaderSoLuong,
            this.columnHeaderThanhTien});
            this.listViewDichVu.FullRowSelect = true;
            this.listViewDichVu.GridLines = true;
            this.listViewDichVu.HideSelection = false;
            this.listViewDichVu.LabelEdit = true;
            resources.ApplyResources(this.listViewDichVu, "listViewDichVu");
            this.listViewDichVu.Name = "listViewDichVu";
            this.listViewDichVu.UseCompatibleStateImageBehavior = false;
            this.listViewDichVu.View = System.Windows.Forms.View.Details;
            this.listViewDichVu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewDichVu_MouseUp);
            // 
            // columnHeaderMaDV
            // 
            this.columnHeaderMaDV.Tag = "MaDV";
            resources.ApplyResources(this.columnHeaderMaDV, "columnHeaderMaDV");
            // 
            // columnHeaderDichVu
            // 
            this.columnHeaderDichVu.Tag = "TenDV";
            resources.ApplyResources(this.columnHeaderDichVu, "columnHeaderDichVu");
            // 
            // columnHeaderGiaTien
            // 
            this.columnHeaderGiaTien.Tag = "GiaTien";
            resources.ApplyResources(this.columnHeaderGiaTien, "columnHeaderGiaTien");
            // 
            // columnHeaderSoLuong
            // 
            this.columnHeaderSoLuong.Tag = "SoLuong";
            resources.ApplyResources(this.columnHeaderSoLuong, "columnHeaderSoLuong");
            // 
            // columnHeaderThanhTien
            // 
            resources.ApplyResources(this.columnHeaderThanhTien, "columnHeaderThanhTien");
            // 
            // textBoxGiaTienPhong
            // 
            resources.ApplyResources(this.textBoxGiaTienPhong, "textBoxGiaTienPhong");
            this.textBoxGiaTienPhong.Name = "textBoxGiaTienPhong";
            this.textBoxGiaTienPhong.ReadOnly = true;
            // 
            // dateTimePickerNgayLap
            // 
            resources.ApplyResources(this.dateTimePickerNgayLap, "dateTimePickerNgayLap");
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // FormLapHoanDon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxKhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.dataGridViewHopDong);
            this.Controls.Add(this.checkBoxHopDongKetThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLapHoanDon";
            this.Load += new System.EventHandler(this.FormLapHoanDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxHopDongKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHopDong;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.TextBox textBoxSoHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox textBoxGiaTienPhong;
        private System.Windows.Forms.ListView listViewDichVu;
        private System.Windows.Forms.ColumnHeader columnHeaderSoLuong;
        private System.Windows.Forms.ColumnHeader columnHeaderGiaTien;
        private System.Windows.Forms.ColumnHeader columnHeaderThanhTien;
        private System.Windows.Forms.ColumnHeader columnHeaderMaDV;
        private System.Windows.Forms.ColumnHeader columnHeaderDichVu;
        private System.Windows.Forms.TextBox textBoxSoTienKhachTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTienPhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTienGiam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonXoaSoLuong;
        private System.Windows.Forms.Button buttonTinhTienHoaDon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxTinhTrangHoaDon;
        private System.Windows.Forms.Button buttonKetThuc;
        private System.Windows.Forms.Button buttonKhongGhi;
        private System.Windows.Forms.Button buttonGhi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBoxSoLuong;
    }
}