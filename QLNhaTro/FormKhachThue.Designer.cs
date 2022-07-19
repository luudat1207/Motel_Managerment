namespace QLNhaTro
{
    partial class FormKhachThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachThue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKhachThue = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTinKhac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQueQuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSoDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxThongTinKhac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonKetThuc = new System.Windows.Forms.Button();
            this.buttonKhongGhi = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachThue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxTimKiem
            // 
            resources.ApplyResources(this.textBoxTimKiem, "textBoxTimKiem");
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dataGridViewKhachThue
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewKhachThue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ThongTinKhac,
            this.GhiChu});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKhachThue.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.dataGridViewKhachThue, "dataGridViewKhachThue");
            this.dataGridViewKhachThue.Name = "dataGridViewKhachThue";
            this.dataGridViewKhachThue.RowTemplate.Height = 50;
            this.dataGridViewKhachThue.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKhachThue_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CCCD";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "QueQuan";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // ThongTinKhac
            // 
            this.ThongTinKhac.DataPropertyName = "ThongTinKhac";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThongTinKhac.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.ThongTinKhac, "ThongTinKhac");
            this.ThongTinKhac.Name = "ThongTinKhac";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GhiChu.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.GhiChu, "GhiChu");
            this.GhiChu.Name = "GhiChu";
            // 
            // textBoxHoTen
            // 
            resources.ApplyResources(this.textBoxHoTen, "textBoxHoTen");
            this.textBoxHoTen.Name = "textBoxHoTen";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxQueQuan
            // 
            resources.ApplyResources(this.textBoxQueQuan, "textBoxQueQuan");
            this.textBoxQueQuan.Name = "textBoxQueQuan";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxCCCD
            // 
            resources.ApplyResources(this.textBoxCCCD, "textBoxCCCD");
            this.textBoxCCCD.Name = "textBoxCCCD";
            this.textBoxCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCCCD_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxDiaChi
            // 
            resources.ApplyResources(this.textBoxDiaChi, "textBoxDiaChi");
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxSoDT
            // 
            resources.ApplyResources(this.textBoxSoDT, "textBoxSoDT");
            this.textBoxSoDT.Name = "textBoxSoDT";
            this.textBoxSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoDT_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxThongTinKhac
            // 
            resources.ApplyResources(this.textBoxThongTinKhac, "textBoxThongTinKhac");
            this.textBoxThongTinKhac.Name = "textBoxThongTinKhac";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBoxGhiChu
            // 
            resources.ApplyResources(this.textBoxGhiChu, "textBoxGhiChu");
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
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
            // FormKhachThue
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonKetThuc);
            this.Controls.Add(this.buttonKhongGhi);
            this.Controls.Add(this.buttonGhi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxGhiChu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxThongTinKhac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSoDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCCCD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxQueQuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewKhachThue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKhachThue";
            this.Load += new System.EventHandler(this.FormKhachThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewKhachThue;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQueQuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSoDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxThongTinKhac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTinKhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}