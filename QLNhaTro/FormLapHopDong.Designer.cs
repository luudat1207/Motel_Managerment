namespace QLNhaTro
{
    partial class FormLapHopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapHopDong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHopDong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonChuNha = new System.Windows.Forms.RadioButton();
            this.dataGridViewTraCuu = new System.Windows.Forms.DataGridView();
            this.radioButtonPhong = new System.Windows.Forms.RadioButton();
            this.radioButtonKhachThue = new System.Windows.Forms.RadioButton();
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.textBoxTimThongTin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCCCD = new System.Windows.Forms.TextBox();
            this.textBoxIDCN = new System.Windows.Forms.TextBox();
            this.labelKetthuc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonKetThuc = new System.Windows.Forms.Button();
            this.buttonXoaHopDong = new System.Windows.Forms.Button();
            this.buttonKetThucHopDong = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.buttonThemHopDong = new System.Windows.Forms.Button();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerDuKienTra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxGiaThue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxChuNha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxHopDongKetThuc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHopDong
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewHopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            resources.ApplyResources(this.dataGridViewHopDong, "dataGridViewHopDong");
            this.dataGridViewHopDong.Name = "dataGridViewHopDong";
            this.dataGridViewHopDong.RowTemplate.Height = 50;
            this.dataGridViewHopDong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHopDong_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoHopDong";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "htcn";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle15;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "htkh";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle16;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaPhong";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle17;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaThue";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle18;
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TuNgay";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DuKienTra";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DaKetThuc";
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonChuNha);
            this.groupBox1.Controls.Add(this.dataGridViewTraCuu);
            this.groupBox1.Controls.Add(this.radioButtonPhong);
            this.groupBox1.Controls.Add(this.radioButtonKhachThue);
            this.groupBox1.Controls.Add(this.buttonChon);
            this.groupBox1.Controls.Add(this.buttonTim);
            this.groupBox1.Controls.Add(this.textBoxTimThongTin);
            this.groupBox1.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButtonChuNha
            // 
            resources.ApplyResources(this.radioButtonChuNha, "radioButtonChuNha");
            this.radioButtonChuNha.Name = "radioButtonChuNha";
            this.radioButtonChuNha.TabStop = true;
            this.radioButtonChuNha.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTraCuu
            // 
            this.dataGridViewTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewTraCuu, "dataGridViewTraCuu");
            this.dataGridViewTraCuu.Name = "dataGridViewTraCuu";
            this.dataGridViewTraCuu.RowTemplate.Height = 29;
            this.dataGridViewTraCuu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTraCuu_CellMouseClick);
            // 
            // radioButtonPhong
            // 
            resources.ApplyResources(this.radioButtonPhong, "radioButtonPhong");
            this.radioButtonPhong.Name = "radioButtonPhong";
            this.radioButtonPhong.TabStop = true;
            this.radioButtonPhong.UseVisualStyleBackColor = true;
            // 
            // radioButtonKhachThue
            // 
            resources.ApplyResources(this.radioButtonKhachThue, "radioButtonKhachThue");
            this.radioButtonKhachThue.Name = "radioButtonKhachThue";
            this.radioButtonKhachThue.TabStop = true;
            this.radioButtonKhachThue.UseVisualStyleBackColor = true;
            // 
            // buttonChon
            // 
            resources.ApplyResources(this.buttonChon, "buttonChon");
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.UseVisualStyleBackColor = true;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click);
            // 
            // buttonTim
            // 
            resources.ApplyResources(this.buttonTim, "buttonTim");
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // textBoxTimThongTin
            // 
            resources.ApplyResources(this.textBoxTimThongTin, "textBoxTimThongTin");
            this.textBoxTimThongTin.Name = "textBoxTimThongTin";
            this.textBoxTimThongTin.TextChanged += new System.EventHandler(this.textBoxTimThongTin_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCCCD);
            this.groupBox2.Controls.Add(this.textBoxIDCN);
            this.groupBox2.Controls.Add(this.labelKetthuc);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonKetThuc);
            this.groupBox2.Controls.Add(this.buttonXoaHopDong);
            this.groupBox2.Controls.Add(this.buttonKetThucHopDong);
            this.groupBox2.Controls.Add(this.buttonGhi);
            this.groupBox2.Controls.Add(this.buttonThemHopDong);
            this.groupBox2.Controls.Add(this.dateTimePickerNgayTra);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateTimePickerDuKienTra);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePickerTuNgay);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxGiaThue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxPhong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxKhach);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxChuNha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxSoHD);
            this.groupBox2.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBoxCCCD
            // 
            resources.ApplyResources(this.textBoxCCCD, "textBoxCCCD");
            this.textBoxCCCD.Name = "textBoxCCCD";
            // 
            // textBoxIDCN
            // 
            resources.ApplyResources(this.textBoxIDCN, "textBoxIDCN");
            this.textBoxIDCN.Name = "textBoxIDCN";
            // 
            // labelKetthuc
            // 
            resources.ApplyResources(this.labelKetthuc, "labelKetthuc");
            this.labelKetthuc.Name = "labelKetthuc";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // buttonKetThuc
            // 
            resources.ApplyResources(this.buttonKetThuc, "buttonKetThuc");
            this.buttonKetThuc.Name = "buttonKetThuc";
            this.buttonKetThuc.UseVisualStyleBackColor = true;
            this.buttonKetThuc.Click += new System.EventHandler(this.buttonKetThuc_Click);
            // 
            // buttonXoaHopDong
            // 
            resources.ApplyResources(this.buttonXoaHopDong, "buttonXoaHopDong");
            this.buttonXoaHopDong.Name = "buttonXoaHopDong";
            this.buttonXoaHopDong.UseVisualStyleBackColor = true;
            this.buttonXoaHopDong.Click += new System.EventHandler(this.buttonXoaHopDong_Click);
            // 
            // buttonKetThucHopDong
            // 
            resources.ApplyResources(this.buttonKetThucHopDong, "buttonKetThucHopDong");
            this.buttonKetThucHopDong.Name = "buttonKetThucHopDong";
            this.buttonKetThucHopDong.UseVisualStyleBackColor = true;
            this.buttonKetThucHopDong.Click += new System.EventHandler(this.buttonKetThucHopDong_Click);
            // 
            // buttonGhi
            // 
            resources.ApplyResources(this.buttonGhi, "buttonGhi");
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.UseVisualStyleBackColor = true;
            this.buttonGhi.Click += new System.EventHandler(this.buttonGhi_Click);
            // 
            // buttonThemHopDong
            // 
            resources.ApplyResources(this.buttonThemHopDong, "buttonThemHopDong");
            this.buttonThemHopDong.Name = "buttonThemHopDong";
            this.buttonThemHopDong.UseVisualStyleBackColor = true;
            this.buttonThemHopDong.Click += new System.EventHandler(this.buttonThemHopDong_Click);
            // 
            // dateTimePickerNgayTra
            // 
            resources.ApplyResources(this.dateTimePickerNgayTra, "dateTimePickerNgayTra");
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // dateTimePickerDuKienTra
            // 
            resources.ApplyResources(this.dateTimePickerDuKienTra, "dateTimePickerDuKienTra");
            this.dateTimePickerDuKienTra.Name = "dateTimePickerDuKienTra";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // dateTimePickerTuNgay
            // 
            resources.ApplyResources(this.dateTimePickerTuNgay, "dateTimePickerTuNgay");
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // textBoxGiaThue
            // 
            resources.ApplyResources(this.textBoxGiaThue, "textBoxGiaThue");
            this.textBoxGiaThue.Name = "textBoxGiaThue";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBoxPhong
            // 
            resources.ApplyResources(this.textBoxPhong, "textBoxPhong");
            this.textBoxPhong.Name = "textBoxPhong";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxKhach
            // 
            resources.ApplyResources(this.textBoxKhach, "textBoxKhach");
            this.textBoxKhach.Name = "textBoxKhach";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxChuNha
            // 
            resources.ApplyResources(this.textBoxChuNha, "textBoxChuNha");
            this.textBoxChuNha.Name = "textBoxChuNha";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxSoHD
            // 
            resources.ApplyResources(this.textBoxSoHD, "textBoxSoHD");
            this.textBoxSoHD.Name = "textBoxSoHD";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // checkBoxHopDongKetThuc
            // 
            resources.ApplyResources(this.checkBoxHopDongKetThuc, "checkBoxHopDongKetThuc");
            this.checkBoxHopDongKetThuc.Name = "checkBoxHopDongKetThuc";
            this.checkBoxHopDongKetThuc.UseVisualStyleBackColor = true;
            this.checkBoxHopDongKetThuc.CheckedChanged += new System.EventHandler(this.checkBoxHopDongKetThuc_CheckedChanged);
            // 
            // FormLapHopDong
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxHopDongKetThuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewHopDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLapHopDong";
            this.Load += new System.EventHandler(this.FormLapHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHopDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimThongTin;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.RadioButton radioButtonKhachThue;
        private System.Windows.Forms.RadioButton radioButtonPhong;
        private System.Windows.Forms.DataGridView dataGridViewTraCuu;
        private System.Windows.Forms.RadioButton radioButtonChuNha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxChuNha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSoHD;
        private System.Windows.Forms.TextBox textBoxPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGiaThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuKienTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonKetThuc;
        private System.Windows.Forms.Button buttonXoaHopDong;
        private System.Windows.Forms.Button buttonKetThucHopDong;
        private System.Windows.Forms.Button buttonGhi;
        private System.Windows.Forms.Button buttonThemHopDong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxHopDongKetThuc;
        private System.Windows.Forms.Label labelKetthuc;
        private System.Windows.Forms.TextBox textBoxCCCD;
        private System.Windows.Forms.TextBox textBoxIDCN;
    }
}