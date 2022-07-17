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
    public partial class FormThanhToanHoaDon : Form
    {
        bool ktThem;
        int IDcu;
        DataGridViewCellEventArgs vt;
        public FormThanhToanHoaDon()
        {
            InitializeComponent();
        }

        private void FormThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public void loadData()
        {
            List<Thanhtoan> lstTT = Logics.ThanhToanHoaDonManager.GetAllThanhToan();
            dataGridViewThanhToan.DataSource = lstTT.Select(x => new
            {
                x.Idtt,
                x.LoaiThanhToan
            }).ToList();


        }
        public void XoaTrang()
        {
            textBoxID.Text = "";
            textTinhTrang.Text = "";

        }
        public void KeyOpen(bool open)
        {
            dataGridViewThanhToan.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxID.ReadOnly = open;
            textTinhTrang.ReadOnly = open;


        }

        private void dataGridViewThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewThanhToan.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewThanhToan.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewThanhToan.Rows[selectedrowindex];

                string cellvalue = Convert.ToString(selectedRow.Cells["ID"].Value);

                if (!string.IsNullOrEmpty(cellvalue))
                {
                    vt = e;
                    using (var context = new DBNhaTroContext())
                    {
                        int ttID = Convert.ToInt32(cellvalue);

                        Thanhtoan tt = context.Thanhtoans.FirstOrDefault(x => x.Idtt == ttID);
                        // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

                        textBoxID.Text = tt.Idtt.ToString();
                        textTinhTrang.Text = tt.LoaiThanhToan.ToString();

                    }
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textTinhTrang.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            int.TryParse(textBoxID.Text, out IDcu);
            textTinhTrang.Focus();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxID.Text, out IDcu);
            using (var context = new DBNhaTroContext())
            {
                if (textBoxID.Text == "") return;
                if (MessageBox.Show("Bạn có muốn xóa [" + textTinhTrang.Text + "] không ?", "Thông báo ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Thanhtoan tt = context.Thanhtoans.Where(x => x.Idtt == IDcu).SingleOrDefault();
                    context.Thanhtoans.Remove(tt);
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
            if (textTinhTrang.Text == "")
            {
                MessageBox.Show("Tình trạng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTinhTrang.Focus();
                return;
            }


            using (var context = new DBNhaTroContext())
            {


                if (ktThem == true)
                {
                    String tinhtrang = textTinhTrang.Text;
                    Thanhtoan tt = new Thanhtoan() { LoaiThanhToan = tinhtrang };
                    context.Thanhtoans.Add(tt);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Thanhtoan tt = context.Thanhtoans.Where(x => x.Idtt == IDcu).SingleOrDefault();

                    tt.LoaiThanhToan = textTinhTrang.Text;

                    context.Thanhtoans.Update(tt);
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
                dataGridViewThanhToan_CellContentClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
