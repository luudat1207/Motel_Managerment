using QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro
{
    public partial class FormLapHopDong : Form
    {
        DataGridViewCellMouseEventArgs vtHopDong, vtTimKiem;
        public FormLapHopDong()
        {
            InitializeComponent();
        }

        private void FormLapHopDong_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public void loadData()
        {
            using (var context = new DBNhaTroContext())
            {
                dataGridViewHopDong.DataSource = (from cn in context.Chunhas
                                                  join hd in context.Hopdongs on cn.Idcn equals hd.Idcn
                                                  join kh in context.Khachthues on hd.Cccd equals kh.Cccd
                                                  join ph in context.Phongtros on hd.MaPhong equals ph.MaPhong
                                                  where (checkBoxHopDongKetThuc.Checked == true ? true : hd.DaKetThuc == false
                                                  )
                                                  select new
                                                  {
                                                      hd.SoHopDong,
                                                      htcn = cn.HoTen,
                                                      htkh = kh.HoTen,
                                                      ph.MaPhong,
                                                      hd.GiaThue,
                                                      hd.TuNgay,
                                                      hd.DuKienTra,
                                                      hd.NgayTra,
                                                      hd.DaKetThuc,
                                                      cn.Idcn,
                                                      kh.Cccd,
                                                      ph.ThongTin
                                                  }).OrderBy(x => x.SoHopDong).ToList();
            }
        }
        public void KeyOpen(bool open)
        {
            buttonThemHopDong.Enabled = open;
            buttonKetThucHopDong.Enabled = open;
            buttonXoaHopDong.Enabled = open;
            buttonGhi.Enabled = !open;
            buttonChon.Enabled = !open;

            textBoxChuNha.Enabled = !open;
            textBoxGiaThue.Enabled = !open;
            textBoxSoHD.Enabled = !open;
            textBoxKhach.Enabled = !open;
            textBoxPhong.Enabled = !open;
            textBoxCCCD.Enabled = !open;
            textBoxIDCN.Enabled = !open;
            dateTimePickerDuKienTra.Enabled = !open;
            dateTimePickerNgayTra.Enabled = !open;
            dateTimePickerTuNgay.Enabled = !open;
        }
        public void XoaTrang()
        {
            textBoxCCCD.Text = "";
            textBoxKhach.Text = "";
            textBoxIDCN.Text = "";
            textBoxChuNha.Text = "";
            textBoxGiaThue.Text = "";
            textBoxPhong.Text = "";

        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            using (var context = new DBNhaTroContext())
            {

                if (string.IsNullOrEmpty(textBoxTimKiem.Text))
                {
                    dataGridViewHopDong.DataSource = (from cn in context.Chunhas
                                                      join hd in context.Hopdongs on cn.Idcn equals hd.Idcn
                                                      join kh in context.Khachthues on hd.Cccd equals kh.Cccd
                                                      join ph in context.Phongtros on hd.MaPhong equals ph.MaPhong
                                                      where (checkBoxHopDongKetThuc.Checked == true ? true : hd.DaKetThuc == false
                                                      )
                                                      select new
                                                      {
                                                          hd.SoHopDong,
                                                          htcn = cn.HoTen,
                                                          htkh = kh.HoTen,
                                                          ph.MaPhong,
                                                          hd.GiaThue,
                                                          hd.TuNgay,
                                                          hd.DuKienTra,
                                                          hd.NgayTra,
                                                          hd.DaKetThuc,
                                                          cn.Idcn,
                                                          kh.Cccd,
                                                          ph.ThongTin
                                                      }).OrderBy(x => x.SoHopDong).ToList();
                }
                else
                {

                    dataGridViewHopDong.DataSource = (from cn in context.Chunhas
                                                      join hd in context.Hopdongs on cn.Idcn equals hd.Idcn
                                                      join kh in context.Khachthues on hd.Cccd equals kh.Cccd
                                                      join ph in context.Phongtros on hd.MaPhong equals ph.MaPhong
                                                      where (
                                                      checkBoxHopDongKetThuc.Checked == true ? true : hd.DaKetThuc == false &&
                                                      hd.SoHopDong.Contains(textBoxTimKiem.Text)

                                                      )
                                                      select new
                                                      {
                                                          hd.SoHopDong,
                                                          htcn = cn.HoTen,
                                                          htkh = kh.HoTen,
                                                          ph.MaPhong,
                                                          hd.GiaThue,
                                                          hd.TuNgay,
                                                          hd.DuKienTra,
                                                          hd.NgayTra,
                                                          hd.DaKetThuc,
                                                          cn.Idcn,
                                                          kh.Cccd,
                                                          ph.ThongTin
                                                      }).OrderBy(x => x.SoHopDong).ToList();
                }

            }
        }

        private void checkBoxHopDongKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewHopDong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewHopDong.Rows.Count <= 0) return;
            if (e.RowIndex >= 0)
            {
                KeyOpen(true);
                vtHopDong = e;
                DataGridViewRow row = dataGridViewHopDong.Rows[e.RowIndex];
                textBoxSoHD.Text = row.Cells[0].Value.ToString();
                textBoxChuNha.Text = row.Cells[1].Value.ToString();
                textBoxKhach.Text = row.Cells[2].Value.ToString();
                textBoxPhong.Text = row.Cells[3].Value.ToString();
                textBoxGiaThue.Text = row.Cells[4].Value.ToString();

                if (row.Cells[5].Value != null)
                {
                    if (row.Cells[5].Value.ToString() != "")
                    {
                        dateTimePickerTuNgay.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                    }
                }
                else
                {
                    dateTimePickerTuNgay.Value = DateTime.Now;
                }
                if (row.Cells[6].Value != null)
                {
                    if (row.Cells[6].Value.ToString() != "")
                    {
                        dateTimePickerDuKienTra.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                    }
                }
                else
                {
                    dateTimePickerDuKienTra.Value = DateTime.Now;
                }
                if (row.Cells[7].Value != null)
                {
                    if (row.Cells[7].Value.ToString() != "")
                    {
                        dateTimePickerNgayTra.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                    }
                }
                else
                {
                    dateTimePickerNgayTra.Value = DateTime.Now;
                }

                bool ktKetThuc = (bool)row.Cells[8].Value;
                if (ktKetThuc == true)
                {
                    labelKetthuc.Text = "Đã kết thúc ";
                    labelKetthuc.Enabled = false;
                }
                else
                {
                    labelKetthuc.Text = "Chưa kết thúc ";
                    labelKetthuc.Enabled = true;
                    dateTimePickerNgayTra.Value = DateTime.Now;
                }



            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (radioButtonChuNha.Checked == true)
            {
                using (var context = new DBNhaTroContext())
                {
                    dataGridViewTraCuu.DataSource = context.Chunhas.Where(x => x.HoTen.Contains(textBoxTimThongTin.Text)).Select(x => new
                    {
                        x.Idcn,
                        x.HoTen,
                        x.Sdt
                    }).ToList();
                }
            }
            if (radioButtonKhachThue.Checked == true)
            {
                using (var context = new DBNhaTroContext())
                {
                    dataGridViewTraCuu.DataSource = context.Khachthues.Where(x => x.HoTen.Contains(textBoxTimThongTin.Text) ||
                    x.Sdt.Contains(textBoxTimThongTin.Text) ||
                    x.Cccd.Contains(textBoxTimThongTin.Text)
                    ).Select(x => new
                    {
                        x.Cccd,
                        x.HoTen,
                        x.Sdt
                    }).ToList();
                }
            }
            if (radioButtonPhong.Checked == true)
            {
                using (var context = new DBNhaTroContext())
                {
                    dataGridViewTraCuu.DataSource = context.Phongtros.Where(x => x.MaPhong.Contains(textBoxTimThongTin.Text)).Select(x => new
                    {
                        x.MaPhong,
                        x.GiaPhong,
                        x.GhiChu
                    }).ToList();
                }
            }
        }

        private void textBoxTimThongTin_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonChuNha.Checked == true)
            {
                using (var context = new DBNhaTroContext())
                {
                    dataGridViewTraCuu.DataSource = context.Chunhas.Where(x => x.HoTen.Contains(textBoxTimThongTin.Text)).Select(x => new
                    {
                        x.Idcn,
                        x.HoTen,
                        x.Sdt
                    }).ToList();
                }

            }
            if (radioButtonKhachThue.Checked == true)
            {
                using (var context = new DBNhaTroContext())
                {
                    dataGridViewTraCuu.DataSource = context.Khachthues.Where(x => x.HoTen.Contains(textBoxTimThongTin.Text) ||
                    x.Sdt.Contains(textBoxTimThongTin.Text) ||
                    x.Cccd.Contains(textBoxTimThongTin.Text)
                    ).Select(x => new
                    {
                        x.Cccd,
                        x.HoTen,
                        x.Sdt
                    }).ToList();
                }
            }
            if (radioButtonPhong.Checked == true)
            {
                using (var context = new DBNhaTroContext())
                {
                    dataGridViewTraCuu.DataSource = context.Phongtros.Where(x => x.MaPhong.Contains(textBoxTimThongTin.Text)).Select(x => new
                    {
                        x.MaPhong,
                        x.GiaPhong,
                        x.GhiChu
                    }).ToList();
                }
            }


        }

        private void buttonThemHopDong_Click(object sender, EventArgs e)
        {
            autogenSoHopDong();
            XoaTrang();
            dateTimePickerTuNgay.Value = DateTime.Now;
            dateTimePickerDuKienTra.Value = DateTime.Today.AddYears(1);
            dateTimePickerNgayTra.Enabled = false;
            KeyOpen(false);
        }

        private void buttonGhi_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhaTroContext())
            {
                if (textBoxChuNha.Text == "")
                {
                    MessageBox.Show("Chủ nhà trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxTimThongTin.Focus();
                    radioButtonChuNha.Checked = true;
                    return;
                }
                else if (textBoxKhach.Text == "")
                {
                    MessageBox.Show("Khách hàng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxTimThongTin.Focus();
                    radioButtonKhachThue.Checked = true;
                    return;
                }
                else if (textBoxPhong.Text == "")
                {
                    MessageBox.Show("Phòng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxTimThongTin.Focus();
                    radioButtonPhong.Checked = true;
                    return;
                }
                if (MessageBox.Show("Bạn có muốn thêm hợp đồng mới không?", " Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                //DateTime hentra;
                string sohd = textBoxSoHD.Text;
                int idcn = int.Parse(textBoxIDCN.Text);
                string cccd = textBoxCCCD.Text;
                string maphong = textBoxPhong.Text;
                double giathue = double.Parse(textBoxGiaThue.Text);
                DateTime tungay = DateTime.Now;
                DateTime hentra = dateTimePickerDuKienTra.Value;
                bool kt = false;
                Hopdong hd = new Hopdong() { SoHopDong = sohd, Idcn = idcn, Cccd = cccd, MaPhong = maphong, GiaThue = giathue, TuNgay = tungay,DuKienTra = hentra, DaKetThuc = kt };
                context.Hopdongs.Add(hd);
                MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                context.SaveChanges();
                KeyOpen(true);
            }
            loadData();
        }

        private void buttonKetThucHopDong_Click(object sender, EventArgs e)
        {
            if (textBoxSoHD.Text == "") return;
            if (MessageBox.Show("Bạn có muốn kết thúc hợp đồng không?", " Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (var context = new DBNhaTroContext())
            {
                Hopdong hd = context.Hopdongs.Where(x => x.SoHopDong.Equals(textBoxSoHD.Text)).SingleOrDefault();
                if (hd != null)
                {
                    hd.NgayTra = DateTime.Now;
                    hd.DaKetThuc = true;
                    context.SaveChanges();
                    MessageBox.Show("Đã kết thúc hợp đồng thành công ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void buttonXoaHopDong_Click(object sender, EventArgs e)
        {
            if (textBoxSoHD.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa hợp đồng không?", " Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (var context = new DBNhaTroContext())
            {
                Hopdong hd = context.Hopdongs.Where(x => x.SoHopDong.Equals(textBoxSoHD.Text)).SingleOrDefault();
                if (hd != null)
                {
                    context.Hopdongs.Remove(hd);
                    MessageBox.Show("Đã xóa thành công ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    loadData();
                    XoaTrang();
                    KeyOpen(true);
                }
            }
        }

        public void autogenSoHopDong()
        {
            long num = 1;
            using (var context = new DBNhaTroContext())
            {
                Hopdong hd = context.Hopdongs.OrderByDescending(x => x.SoHopDong).FirstOrDefault();
                if (hd != null)
                {
                    num = long.Parse(hd.SoHopDong.ToString()) + 1;
                }

                textBoxSoHD.Text = num.ToString("0000000000");
            }
        }

        private void dataGridViewTraCuu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewTraCuu.Rows.Count <= 0) return;
            if (e.RowIndex >= 0)
            {
                KeyOpen(false);
                vtTimKiem = e;

            }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            if (buttonGhi.Enabled == false) return;
            try
            {
                DataGridViewRow row = dataGridViewTraCuu.Rows[vtTimKiem.RowIndex];
                if (radioButtonChuNha.Checked == true)
                {
                    textBoxChuNha.Text = row.Cells[1].Value.ToString();
                    textBoxIDCN.Text = row.Cells[0].Value.ToString();
                }
                if (radioButtonKhachThue.Checked == true)
                {
                    textBoxKhach.Text = row.Cells[1].Value.ToString();
                    textBoxCCCD.Text = row.Cells[0].Value.ToString();
                }
                if (radioButtonPhong.Checked == true)
                {
                    textBoxPhong.Text = row.Cells[0].Value.ToString();
                    textBoxGiaThue.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex) { }
        }


    }
}
