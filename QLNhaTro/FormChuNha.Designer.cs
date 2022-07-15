namespace QLNhaTro
{
    partial class FormChuNha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuNha));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.textSoDT = new System.Windows.Forms.TextBox();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            this.textGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN CHỦ NHÀ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 458);
            this.dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 640);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số ĐT  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(497, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(495, 646);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ghi chú :";
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(165, 565);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(313, 44);
            this.textHoTen.TabIndex = 6;
            // 
            // textSoDT
            // 
            this.textSoDT.Location = new System.Drawing.Point(165, 630);
            this.textSoDT.MaxLength = 10;
            this.textSoDT.Name = "textSoDT";
            this.textSoDT.Size = new System.Drawing.Size(313, 44);
            this.textSoDT.TabIndex = 7;
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(644, 568);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(487, 44);
            this.textDiaChi.TabIndex = 8;
            // 
            // textGhiChu
            // 
            this.textGhiChu.Location = new System.Drawing.Point(644, 630);
            this.textGhiChu.Name = "textGhiChu";
            this.textGhiChu.Size = new System.Drawing.Size(487, 44);
            this.textGhiChu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ Tên :";
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThem.Location = new System.Drawing.Point(144, 694);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(128, 40);
            this.buttonThem.TabIndex = 11;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCapNhat.Location = new System.Drawing.Point(497, 694);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(128, 40);
            this.buttonCapNhat.TabIndex = 12;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXoa.Location = new System.Drawing.Point(865, 694);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(128, 40);
            this.buttonXoa.TabIndex = 13;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // FormChuNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 756);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textGhiChu);
            this.Controls.Add(this.textDiaChi);
            this.Controls.Add(this.textSoDT);
            this.Controls.Add(this.textHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChuNha";
            this.Text = "Quản lý thông tin chủ nhà";
            this.Load += new System.EventHandler(this.FormChuNha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textSoDT;
        private System.Windows.Forms.TextBox textDiaChi;
        private System.Windows.Forms.TextBox textGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonXoa;
    }
}