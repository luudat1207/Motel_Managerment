﻿using QLNhaTro.Models;
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
    public partial class FormLapHoanDon : Form
    {
        DataGridViewCellMouseEventArgs vtHopDong, vtHoaDon;
        bool ktHopDong, ktThem;
        int idHoaDon = -1, vtDichVu;
        public FormLapHoanDon()
        {
            InitializeComponent();
        }

        public void keyOpen(bool open)
        {
            textBoxTimKiem.ReadOnly = !open;
            checkBoxHopDongKetThuc.Enabled = open;

            dataGridViewHoaDon.Enabled = open;
            dataGridViewHopDong.Enabled = open;
            dateTimePickerNgayLap.Enabled = open;

            listViewDichVu.Enabled = !open;

            textBoxTienGiam.ReadOnly = open;
            textBoxTienPhat.ReadOnly = open;
            textBoxTongTien.ReadOnly = open;
            textBoxSoTienKhachTra.ReadOnly = open;

            comboBoxTinhTrangHoaDon.Enabled = !open;

            textBoxGhiChu.ReadOnly = open;
            buttonXoaSoLuong.Enabled = !open;
            buttonTinhTienHoaDon.Enabled = !open;

            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;
            buttonKhongGhi.Enabled = !open;
            buttonGhi.Enabled = !open;

        }

        public void loadData()
        {
            using (var context = new DBNhaTroContext())
            {
                comboBoxTinhTrangHoaDon.DataSource = context.Thanhtoans.OrderBy(x => x.Idtt).ToList();
                comboBoxTinhTrangHoaDon.DisplayMember = "LoaiThanhToan";
                comboBoxTinhTrangHoaDon.ValueMember = "Idtt";


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

        public void XoaTrang()
        {
            textBoxTienGiam.Text = "0";
            textBoxTienPhat.Text = "0";
            textBoxSoTienKhachTra.Text = "0";
            textBoxGhiChu.Text = "";
            textBoxTongTien.Text = "0";
            listViewDichVu.Items.Clear();

        }
        private void FormLapHoanDon_Load(object sender, EventArgs e)
        {
            keyOpen(true);
            loadData();
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
                                                      hd.SoHopDong.Contains(textBoxTimKiem.Text) || hd.MaPhong.Contains(textBoxTimKiem.Text)

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
                keyOpen(true);
                vtHopDong = e;
                DataGridViewRow row = dataGridViewHopDong.Rows[e.RowIndex];
                textBoxSoHD.Text = row.Cells[0].Value.ToString();
                textBoxKhach.Text = row.Cells[2].Value.ToString();
                textBoxPhong.Text = row.Cells[3].Value.ToString();
                textBoxGiaTienPhong.Text = row.Cells[4].Value.ToString();
                ktHopDong = (bool)row.Cells[8].Value;

                using (var context = new DBNhaTroContext())
                {
                    dataGridViewHoaDon.DataSource = context.Hoadons.Where(x => x.SoHopDong.Equals(textBoxSoHD.Text)).Select(x => new
                    {
                        x.Idhd,
                        x.Idtt,
                        x.SoHopDong,
                        x.NgayLap,
                        x.TienGiam,
                        x.TienPhat,
                        x.SoTienTra,
                        x.TongTien,
                        x.GhiChu
                    }).OrderBy(x => x.Idhd).ToList();
                }
                XoaTrang();
            }
        }
        public void getAllDichVu()
        {
            using (var context = new DBNhaTroContext())
            {
                var dl = context.Dichvus.Select(x => new { x.MaDv, x.TenDv, x.SoTien }).ToList();
                listViewDichVu.Items.Clear();
                for (int i = 0; i < dl.Count; i++)
                {
                    ListViewItem itemV = new ListViewItem(new[] { dl[i].MaDv.ToString(), dl[i].TenDv.ToString(),
                            dl[i].SoTien.ToString(), "0", "0"});
                    listViewDichVu.Items.Add(itemV);

                }
            }
        }
        public void getAllDichVuConLai()
        {
            using (var context = new DBNhaTroContext())
            {
                var dsMaDV = context.Cthoadons.Where(x => x.Idhd == idHoaDon).Select(x => x.MaDv).ToList();
                var dl = context.Dichvus.Where(x => !dsMaDV.Contains(x.MaDv)).ToList();
                for (int i = 0; i < dl.Count; i++)
                {
                    ListViewItem itemV = new ListViewItem(new[] { dl[i].MaDv.ToString(), dl[i].TenDv.ToString(),
                            dl[i].SoTien.ToString(), "0", "0"});
                    listViewDichVu.Items.Add(itemV);
                }
            }
        }



        private void buttonXoaSoLuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewDichVu.Items.Count; i++)
            {
                listViewDichVu.Items[i].SubItems[3].Text = "0";
                listViewDichVu.Items[i].SubItems[4].Text = "0";
            }
        }

        private void buttonTinhTienHoaDon_Click(object sender, EventArgs e)
        {
            if (textBoxTienPhat.Text == "") textBoxTienPhat.Text = "0";
            if (textBoxTienGiam.Text == "") textBoxTienGiam.Text = "0";
            if (textBoxSoTienKhachTra.Text == "") textBoxSoTienKhachTra.Text = "0";
            if (textBoxTongTien.Text == "") textBoxTongTien.Text = "0";

            double tienphong = Double.Parse(textBoxGiaTienPhong.Text);
            double tiengiam = Double.Parse(textBoxTienGiam.Text);
            double tienphat = Double.Parse(textBoxTienPhat.Text);

            double tiendv = 0, sotien = 0, soluong, dongia;
            for (int i = 0; i < listViewDichVu.Items.Count; i++)
            {
                soluong = double.Parse(listViewDichVu.Items[i].SubItems[3].Text);
                dongia = double.Parse(listViewDichVu.Items[i].SubItems[2].Text);
                listViewDichVu.Items[i].SubItems[4].Text = (soluong * dongia).ToString();
                tiendv = tiendv + (dongia * soluong);
            }
            sotien = tienphong + tienphat - tiengiam + tiendv;
            textBoxTongTien.Text = sotien.ToString();


        }

        private void textBoxSoLuong_Leave(object sender, EventArgs e)
        {
            listViewDichVu.Items[vtDichVu].SubItems[3].Text = textBoxSoLuong.Text;
            textBoxSoLuong.Visible = false;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (ktHopDong == true)
            {
                MessageBox.Show("Hợp đồng đã được kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (textBoxSoHD.Text == "") return;
            if (idHoaDon < 0) return;
            ktThem = false;
            keyOpen(false);
            getAllDichVuConLai();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhaTroContext())
            {
                if (ktHopDong == true)
                {
                    MessageBox.Show("Hợp đồng đã được kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (textBoxSoHD.Text == "") return;
                if (idHoaDon < 0) return;
                if (MessageBox.Show("Bạn có muốn xóa hóa đơn đã xem không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Hoadon hd = context.Hoadons.Where(x => x.Idhd == idHoaDon).FirstOrDefault();
                    context.Hoadons.Remove(hd);
                    context.SaveChanges();
                    XoaTrang();
                    idHoaDon = -1;

                    //getallhoadon
                    dataGridViewHoaDon.DataSource = context.Hoadons.Where(x => x.SoHopDong.Equals(textBoxSoHD.Text)).Select(x => new
                    {
                        x.Idhd,
                        x.Idtt,
                        x.SoHopDong,
                        x.NgayLap,
                        x.TienGiam,
                        x.TienPhat,
                        x.SoTienTra,
                        x.TongTien,
                        x.GhiChu
                    }).OrderBy(x => x.Idhd).ToList();
                }
            }
        }

        private void buttonGhi_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhaTroContext())
            {
                buttonTinhTienHoaDon_Click(sender, e);
                if (MessageBox.Show("Bạn có muốn ghi hóa đơn không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                if (ktThem == true)
                {
                    int IDTT = Int32.Parse(comboBoxTinhTrangHoaDon.SelectedValue.ToString());
                    string SoHopDong = textBoxSoHD.Text;
                    DateTime NgayLap = dateTimePickerNgayLap.Value;
                    double TienGiam = Double.Parse(textBoxTienGiam.Text);
                    double TienPhat = Double.Parse(textBoxTienPhat.Text);
                    double SoTienTra = Double.Parse(textBoxSoTienKhachTra.Text);
                    double TongTien = Double.Parse(textBoxTongTien.Text);
                    string GhiChu = textBoxGhiChu.Text;

                    Hoadon hoadon = new Hoadon()
                    {
                        Idtt = IDTT,
                        SoHopDong = SoHopDong,
                        NgayLap = NgayLap,
                        TienGiam = TienGiam,
                        TienPhat = TienPhat,
                        SoTienTra = SoTienTra,
                        TongTien = TongTien,
                        GhiChu = GhiChu
                    };
                    context.Hoadons.Add(hoadon);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    keyOpen(true);
                    //lay id hoa don moi vua nhap
                    Hoadon hd = context.Hoadons.OrderByDescending(p => p.Idhd).FirstOrDefault();
                    idHoaDon = hd.Idhd;
                }
                else 
                {
                    Hoadon hoadon = context.Hoadons.Where(x => x.Idhd == idHoaDon).FirstOrDefault();
                    int IDTT = Int32.Parse(comboBoxTinhTrangHoaDon.SelectedValue.ToString());
                    string SoHopDong = textBoxSoHD.Text;
                    DateTime NgayLap = dateTimePickerNgayLap.Value;
                    double TienGiam = Double.Parse(textBoxTienGiam.Text);
                    double TienPhat = Double.Parse(textBoxTienPhat.Text);
                    double SoTienTra = Double.Parse(textBoxSoTienKhachTra.Text);
                    double TongTien = Double.Parse(textBoxTongTien.Text);
                    string GhiChu = textBoxGhiChu.Text;

                    Hoadon hoadon1 = new Hoadon()
                    {
                        Idtt = IDTT,
                        SoHopDong = SoHopDong,
                        NgayLap = NgayLap,
                        TienGiam = TienGiam,
                        TienPhat = TienPhat,
                        SoTienTra = SoTienTra,
                        TongTien = TongTien,
                        GhiChu = GhiChu
                    };
                    context.Hoadons.Update(hoadon);
                    MessageBox.Show("Đã sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    keyOpen(true);

                    List<Cthoadon> ct = context.Cthoadons.Where(x => x.Idhd == idHoaDon).ToList();
                    for(int i = 0; i < ct.Count; i++)
                    {
                        context.Remove(ct[i]);
                    }
                    context.SaveChanges();
                }
                // vi cap nhat se co cai bo cai khong nen xoa het di ghi lai 1 luot
                double soluong, dongia;
                for(int i=0; i< listViewDichVu.Items.Count; i++)
                {
                    soluong = double.Parse(listViewDichVu.Items[i].SubItems[3].Text);
                    dongia = double.Parse(listViewDichVu.Items[i].SubItems[2].Text);
                    if(soluong > 0)
                    {
                        Cthoadon ct = new Cthoadon();
                        ct.Idhd = idHoaDon;
                        ct.MaDv = int.Parse(listViewDichVu.Items[i].Text);
                        ct.SoLuong = soluong;
                        ct.GiaTien = dongia;
                        context.Cthoadons.Add(ct);
                        context.SaveChanges();
                    }
                }

                //getallhoadon
                dataGridViewHoaDon.DataSource = context.Hoadons.Where(x => x.SoHopDong.Equals(textBoxSoHD.Text)).Select(x => new
                {
                    x.Idhd,
                    x.Idtt,
                    x.SoHopDong,
                    x.NgayLap,
                    x.TienGiam,
                    x.TienPhat,
                    x.SoTienTra,
                    x.TongTien,
                    x.GhiChu
                }).OrderBy(x => x.Idhd).ToList();

                //getallchitiethoadon
                var dl = (from dv in context.Dichvus
                          join ct in context.Cthoadons on dv.MaDv equals ct.MaDv
                          where ct.Idhd == idHoaDon
                          select new
                          {
                              dv.MaDv,
                              dv.TenDv,
                              ct.GiaTien,
                              ct.SoLuong
                          }).ToList();
                listViewDichVu.Items.Clear();
                for (int i = 0; i < dl.Count; i++)
                {
                    ListViewItem itemV = new ListViewItem(new[] { dl[i].MaDv.ToString(), dl[i].TenDv.ToString(),
                            dl[i].GiaTien.ToString(), dl[i].SoLuong.ToString(), (dl[i].SoLuong * dl[i].GiaTien).ToString()});
                    listViewDichVu.Items.Add(itemV);

                }
                loadData();
                
            }
        }

        private void buttonKhongGhi_Click(object sender, EventArgs e)
        {
            try
            {
                keyOpen(true);
                XoaTrang();
                dataGridViewHoaDon_CellMouseClick(sender, vtHoaDon);
            }
            catch (Exception ex) { }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (ktHopDong == true)
            {
                MessageBox.Show("Hợp đồng đã được kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (textBoxSoHD.Text == "") return;
            ktThem = true;
            keyOpen(false);
            XoaTrang();
            getAllDichVu();
            dateTimePickerNgayLap.Value = DateTime.Now;

        }

        private void dataGridViewHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewHoaDon.Rows.Count <= 0) return;
            if (e.RowIndex >= 0)
            {
                keyOpen(true);
                vtHoaDon = e;
                DataGridViewRow row = dataGridViewHoaDon.Rows[e.RowIndex];
                textBoxTienGiam.Text = row.Cells[4].Value.ToString();
                textBoxTienPhat.Text = row.Cells[5].Value.ToString();
                textBoxSoTienKhachTra.Text = row.Cells[6].Value.ToString();
                textBoxTongTien.Text = row.Cells[7].Value.ToString();
                dateTimePickerNgayLap.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                textBoxGhiChu.Text = row.Cells[8].Value.ToString();
                idHoaDon = int.Parse(row.Cells[0].Value.ToString());

                using (var context = new DBNhaTroContext())
                {
                    var dl = (from dv in context.Dichvus
                              join ct in context.Cthoadons on dv.MaDv equals ct.MaDv
                              where ct.Idhd == idHoaDon
                              select new
                              {
                                  dv.MaDv,
                                  dv.TenDv,
                                  ct.GiaTien,
                                  ct.SoLuong
                              }).ToList();
                    listViewDichVu.Items.Clear();
                    for (int i = 0; i < dl.Count; i++)
                    {
                        ListViewItem itemV = new ListViewItem(new[] { dl[i].MaDv.ToString(), dl[i].TenDv.ToString(),
                            dl[i].GiaTien.ToString(), dl[i].SoLuong.ToString(), (dl[i].SoLuong * dl[i].GiaTien).ToString()});
                        listViewDichVu.Items.Add(itemV);

                    }
                }
            }
        }

        private void listViewDichVu_MouseUp(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection itemSL = listViewDichVu.SelectedItems;
            if (itemSL.Count > 0)
            {
                ListViewHitTestInfo i = listViewDichVu.HitTest(e.X, e.Y); // tạo độ của dòng đó 
                int cellTop = listViewDichVu.Top + i.SubItem.Bounds.Top;
                textBoxSoLuong.Location = new Point(textBoxSoLuong.Left, cellTop);
                textBoxSoLuong.Text = itemSL[0].SubItems[3].Text;
                vtDichVu = itemSL[0].Index;
                textBoxSoLuong.Visible = true;
                textBoxSoLuong.Focus();
            }
        }
    }
}
