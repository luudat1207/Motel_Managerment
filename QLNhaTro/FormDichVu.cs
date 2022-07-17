using QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro
{
    public partial class FormDichVu : Form
    {
        bool ktThem;
        int IDcu;
        DataGridViewCellEventArgs vt;
        public FormDichVu()
        {
            InitializeComponent();
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public void loadData()
        {

            List<Dichvu> lstDV = Logics.DichVuManager.GetAllDichVu();
            dataGridViewDichVu.DataSource = lstDV.Select(x => new
            {
                x.MaDv,
                x.TenDv,
                x.SoTien,
                x.GhiChu
            }).ToList();


        }
        public void XoaTrang()
        {
            textBoxID.Text = "";
            textDichVu.Text = "";
            textGiaTien.Text = "";
            textGhiChu.Text = "";
        }
        public void KeyOpen(bool open)
        {
            dataGridViewDichVu.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxID.ReadOnly = open;
            textDichVu.ReadOnly = open;
            textGiaTien.ReadOnly = open;
            textGhiChu.ReadOnly = open;
        }

        private void dataGridViewDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewDichVu.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewDichVu.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewDichVu.Rows[selectedrowindex];

                string cellvalue = Convert.ToString(selectedRow.Cells["IDDV"].Value);

                if (!string.IsNullOrEmpty(cellvalue))
                {
                    vt = e;
                    using (var context = new DBNhaTroContext())
                    {
                        int dvID = Convert.ToInt32(cellvalue);

                        Dichvu dv = context.Dichvus.FirstOrDefault(x => x.MaDv == dvID);
                        // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

                        textBoxID.Text = dv.MaDv.ToString();
                        textDichVu.Text = dv.TenDv.ToString();
                        textGiaTien.Text = dv.SoTien.ToString();
                        textGhiChu.Text = dv.GhiChu.ToString();
                        
                    }
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textDichVu.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            int.TryParse(textBoxID.Text, out IDcu);
            textDichVu.Focus();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxID.Text, out IDcu);
            using (var context = new DBNhaTroContext())
            {
                if (textBoxID.Text == "") return;
                if (MessageBox.Show("Bạn có muốn xóa [" + textDichVu.Text + "] không ?", "Thông báo ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Dichvu dv = context.Dichvus.Where(x => x.MaDv == IDcu).SingleOrDefault();
                    context.Dichvus.Remove(dv);
                    MessageBox.Show("Đã xóa thành công ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    XoaTrang();
                    textBoxID.Text = "";
                    KeyOpen(true);

                }
            }
            loadData();
        }

        private void buttonGhi_Click(object sender, EventArgs e)
        {
            if (textDichVu.Text == "")
            {
                MessageBox.Show("Tên dịch vụ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDichVu.Focus();
                return;
            }
            else if (textGiaTien.Text == "")
            {
                MessageBox.Show("Giá tiền trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textGiaTien.Focus();
                return;
            }

            using (var context = new DBNhaTroContext())
            {


                if (ktThem == true)
                {
                    String tendichvu = textDichVu.Text;
                    String giatien = textGiaTien.Text;
                    String ghichu = textGhiChu.Text;

                    Dichvu dv = new Dichvu() { TenDv = tendichvu, SoTien = Convert.ToDouble( giatien),  GhiChu = ghichu };
                    context.Dichvus.Add(dv);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Dichvu dv = context.Dichvus.Where(x => x.MaDv == IDcu).SingleOrDefault();

                    dv.TenDv = textDichVu.Text;
                    dv.SoTien = Convert.ToDouble(textGiaTien.Text);
                    
                    dv.GhiChu = textGhiChu.Text;

                    context.Dichvus.Update(dv);
                    MessageBox.Show("Đã sửa thành công ", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                context.SaveChanges();
                KeyOpen(true);
            }
            loadData();

        }

        private void buttonKhongGhi_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KeyOpen(true);
                dataGridViewDichVu_CellContentClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
