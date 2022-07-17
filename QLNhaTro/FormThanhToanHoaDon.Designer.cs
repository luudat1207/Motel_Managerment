namespace QLNhaTro
{
    partial class FormThanhToanHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToanHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonKetThuc = new System.Windows.Forms.Button();
            this.buttonKhongGhi = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textTinhTrang = new System.Windows.Forms.TextBox();
            this.dataGridViewThanhToan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            resources.ApplyResources(this.textBoxID, "textBoxID");
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textTinhTrang
            // 
            resources.ApplyResources(this.textTinhTrang, "textTinhTrang");
            this.textTinhTrang.Name = "textTinhTrang";
            // 
            // dataGridViewThanhToan
            // 
            resources.ApplyResources(this.dataGridViewThanhToan, "dataGridViewThanhToan");
            this.dataGridViewThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2});
            this.dataGridViewThanhToan.Name = "dataGridViewThanhToan";
            this.dataGridViewThanhToan.RowTemplate.Height = 60;
            this.dataGridViewThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThanhToan_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDTT";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoaiThanhToan";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormThanhToanHoaDon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonKetThuc);
            this.Controls.Add(this.buttonKhongGhi);
            this.Controls.Add(this.buttonGhi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTinhTrang);
            this.Controls.Add(this.dataGridViewThanhToan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThanhToanHoaDon";
            this.Load += new System.EventHandler(this.FormThanhToanHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonKetThuc;
        private System.Windows.Forms.Button buttonKhongGhi;
        private System.Windows.Forms.Button buttonGhi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTinhTrang;
        private System.Windows.Forms.DataGridView dataGridViewThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}