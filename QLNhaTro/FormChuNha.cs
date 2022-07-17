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
    public partial class FormChuNha : Form
    {
        bool ktThem;
        int IDcu;
        DataGridViewCellEventArgs vt;
        public FormChuNha()
        {
            InitializeComponent();
        }

        private void FormChuNha_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }



        public void loadData()
        {

            List<Chunha> lstCN = Logics.ChuNhaManager.GetAllChuNha();
            dataGridViewChuNha.DataSource = lstCN.Select(x => new
            {
                x.Idcn,
                x.HoTen,
                x.Sdt,
                x.DiaChi,
                x.GhiChu
            }).ToList();


        }
        public void XoaTrang()
        {
            textBoxID.Text = "";
            textHoTen.Text = "";
            textSoDT.Text = "";
            textDiaChi.Text = "";
            textGhiChu.Text = "";
        }
        public void KeyOpen(bool open)
        {
            dataGridViewChuNha.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxID.ReadOnly = open;
            textHoTen.ReadOnly = open;
            textSoDT.ReadOnly = open;
            textDiaChi.ReadOnly = open;
            textGhiChu.ReadOnly = open;

        }

        private void dataGridViewChuNha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewChuNha.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewChuNha.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewChuNha.Rows[selectedrowindex];

                string cellvalue = Convert.ToString(selectedRow.Cells["ID"].Value);

                if (!string.IsNullOrEmpty(cellvalue))
                {
                    vt = e;
                    using (var context = new DBNhaTroContext())
                    {
                        int cnID = Convert.ToInt32(cellvalue);

                        Chunha cn = context.Chunhas.FirstOrDefault(x => x.Idcn == cnID);
                        // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

                        textBoxID.Text = cn.Idcn.ToString();
                        textHoTen.Text = cn.HoTen.ToString();
                        textSoDT.Text = cn.Sdt.ToString();
                        textDiaChi.Text = cn.DiaChi.ToString();
                        textGhiChu.Text = cn.GhiChu.ToString();
                    }
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textHoTen.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            int.TryParse(textBoxID.Text, out IDcu);
            textHoTen.Focus();

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxID.Text, out IDcu);
            using (var context = new DBNhaTroContext())
            {
                if (textBoxID.Text == "") return;
                if (MessageBox.Show("Bạn có muốn xóa [" + textHoTen.Text + "] không ?", "Thông báo ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Chunha chn = context.Chunhas.Where(x => x.Idcn == IDcu).SingleOrDefault();
                    context.Chunhas.Remove(chn);
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
            if (textHoTen.Text == "")
            {
                MessageBox.Show("Họ tên trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textHoTen.Focus();
                return;
            }
            else if (textSoDT.Text == "")
            {
                MessageBox.Show("Số điện thoại trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSoDT.Focus();
                return;
            }

            using (var context = new DBNhaTroContext())
            {


                if (ktThem == true)
                {
                    String hoten = textHoTen.Text;
                    String sdt = textSoDT.Text;
                    String diachi = textDiaChi.Text;
                    String ghichu = textGhiChu.Text;

                    Chunha cn = new Chunha() { HoTen = hoten, Sdt = sdt, DiaChi = diachi, GhiChu = ghichu };
                    context.Chunhas.Add(cn);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Chunha chn = context.Chunhas.Where(x => x.Idcn == IDcu).SingleOrDefault();

                    chn.HoTen = textHoTen.Text;
                    chn.Sdt = textSoDT.Text;
                    chn.DiaChi = textDiaChi.Text;
                    chn.GhiChu = textGhiChu.Text;

                    context.Chunhas.Update(chn);
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
                dataGridViewChuNha_CellContentClick(sender, vt);
            }
            catch (Exception ex) { }
        }



        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
