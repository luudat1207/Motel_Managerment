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
    public partial class FormQuanLyPhongTro : Form
    {
        public FormQuanLyPhongTro()
        {
            InitializeComponent();
        }
        bool ktThem;
        string MaPhongcu;
        DataGridViewCellMouseEventArgs vt;

        List<Phongtro> phongtros = new List<Phongtro>();
        private void FormQuanLyPhongTro_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public void loadData()
        {
            using (var context = new DBNhaTroContext())
            {
                dataGridViewPhongTro.DataSource = (from tt in context.Tinhtrangs
                                                   join phong in context.Phongtros
                                                   on tt.MaTinhTrang equals phong.MaTinhTrang
                                                   select new
                                                   {
                                                       phong.MaPhong,
                                                       phong.GiaPhong,
                                                       phong.ThongTin,
                                                       phong.GhiChu,
                                                       tt.TinhTrang1
                                                   }).OrderBy(x => x.MaPhong).ToList();

                comboBoxTinhTrang.DataSource = context.Tinhtrangs.ToList();
                comboBoxTinhTrang.DisplayMember = "TinhTrang";
                comboBoxTinhTrang.ValueMember = "TinhTrang1";
            }
        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            using (var context = new DBNhaTroContext())
            {
                if (string.IsNullOrEmpty(textBoxTimKiem.Text))
                {
                    dataGridViewPhongTro.DataSource = (from tt in context.Tinhtrangs
                                                       join phong in context.Phongtros
                                                       on tt.MaTinhTrang equals phong.MaTinhTrang
                                                       select new
                                                       {
                                                           phong.MaPhong,
                                                           phong.GiaPhong,
                                                           phong.ThongTin,
                                                           phong.GhiChu,
                                                           tt.TinhTrang1
                                                       }).OrderBy(x => x.MaPhong).ToList();
                }
                else
                {

                    dataGridViewPhongTro.DataSource = (from tt in context.Tinhtrangs
                                                       join phong in context.Phongtros
                                                       on tt.MaTinhTrang equals phong.MaTinhTrang
                                                       where (
                                                       phong.MaPhong.Contains(textBoxTimKiem.Text) ||
                                                       phong.GiaPhong.Equals(textBoxTimKiem.Text) ||
                                                       tt.TinhTrang1.Contains(textBoxTimKiem.Text)
                                                       )
                                                       select new
                                                       {
                                                           phong.MaPhong,
                                                           phong.GiaPhong,
                                                           phong.ThongTin,
                                                           phong.GhiChu,
                                                           tt.TinhTrang1
                                                       }).OrderBy(x => x.MaPhong).ToList();
                }

            }
        }

        public void XoaTrang()
        {
            textBoxMaPhong.Text = "";
            textBoxGiaPhong.Text = "";
            textBoxGhiChu.Text = "";
            textBoxThongTin.Text = "";


        }
        public void KeyOpen(bool open)
        {
            dataGridViewPhongTro.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;

            textBoxTimKiem.ReadOnly = !open;
            textBoxMaPhong.ReadOnly = open;
            textBoxGiaPhong.ReadOnly = open;
            textBoxGhiChu.ReadOnly = open;
            textBoxThongTin.ReadOnly = open;
            comboBoxTinhTrang.Enabled = !open;

        }

        private void dataGridViewPhongTro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewPhongTro.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dataGridViewPhongTro.Rows[e.RowIndex];
                textBoxMaPhong.Text = row.Cells[0].Value.ToString();
                textBoxGiaPhong.Text = row.Cells[1].Value.ToString();
                textBoxThongTin.Text = row.Cells[2].Value.ToString();
                comboBoxTinhTrang.SelectedValue = row.Cells[3].Value.ToString();
                textBoxGhiChu.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
