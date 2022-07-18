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
    public partial class FormKhachThue : Form
    {
        public FormKhachThue()
        {
            InitializeComponent();
        }

        bool ktThem;
        string CCCDcu;
        DataGridViewCellMouseEventArgs vt;

        List<Khachthue> khachthues = new List<Khachthue>();
        private void FormKhachThue_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public void loadData()
        {
            khachthues = Logics.KhachThueManager.GetAllKhachThue();
            dataGridViewKhachThue.DataSource = khachthues.Select(x => new
            {
                x.Cccd,
                x.HoTen,
                x.Sdt,
                x.QueQuan,
                x.DiaChi,
                x.ThongTinKhac,
                x.GhiChu
            }).ToList();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTimKiem.Text))
            {
                khachthues = Logics.KhachThueManager.GetAllKhachThue();
            }
            else
            {
                using (var context = new DBNhaTroContext())
                {
                    khachthues = context.Khachthues.Where(x => 
                    x.Cccd.Contains(textBoxTimKiem.Text) || 
                    x.HoTen.Contains(textBoxTimKiem.Text) ||
                    x.QueQuan.Contains(textBoxTimKiem.Text) ||
                    x.DiaChi.Contains(textBoxTimKiem.Text) 
                    ).OrderBy(x => x.HoTen).ToList();
                }
            }
            dataGridViewKhachThue.DataSource = khachthues.Select(x => new
            {
                x.Cccd,
                x.HoTen,
                x.Sdt,
                x.QueQuan,
                x.DiaChi,
                x.ThongTinKhac,
                x.GhiChu
            }).ToList();
        }

        public void XoaTrang()
        {
            textBoxCCCD.Text = "";
            textBoxHoTen.Text = "";
            textBoxSoDT.Text = "";
            textBoxQueQuan.Text = "";
            textBoxDiaChi.Text = "";
            textBoxThongTinKhac.Text = "";
            textBoxGhiChu.Text = "";

        }
        public void KeyOpen(bool open)
        {
            dataGridViewKhachThue.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxCCCD.ReadOnly = open;
            textBoxHoTen.ReadOnly = open;
            textBoxSoDT.ReadOnly = open;
            textBoxQueQuan.ReadOnly = open;
            textBoxDiaChi.ReadOnly = open;
            textBoxThongTinKhac.ReadOnly = open;
            textBoxGhiChu.ReadOnly = open;

        }

        private void dataGridViewKhachThue_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewKhachThue.RowCount <= 0) return;
            if(e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dataGridViewKhachThue.Rows[e.RowIndex];
                textBoxCCCD.Text = row.Cells[0].Value.ToString();
                textBoxHoTen.Text = row.Cells[1].Value.ToString();
                textBoxSoDT.Text = row.Cells[2].Value.ToString();
                textBoxDiaChi.Text = row.Cells[4].Value.ToString();
                textBoxGhiChu.Text = row.Cells[6].Value.ToString();
                textBoxQueQuan.Text = row.Cells[3].Value.ToString();
                textBoxThongTinKhac.Text = row.Cells[5].Value.ToString();
            }
        }

        //private void dataGridViewKhachThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        //    if (dataGridViewKhachThue.SelectedCells.Count > 0)
        //    {
        //        int selectedrowindex = dataGridViewKhachThue.SelectedCells[0].RowIndex;

        //        DataGridViewRow selectedRow = dataGridViewKhachThue.Rows[selectedrowindex];

        //        string cellvalue = Convert.ToString(selectedRow.Cells["CCCD"].Value);

        //        if (!string.IsNullOrEmpty(cellvalue))
        //        {
        //            vt = e;
        //            using (var context = new DBNhaTroContext())
        //            {
        //                string CCCD = cellvalue;

        //                Khachthue kt = context.Khachthues.FirstOrDefault(x => x.Cccd.Equals(CCCD));
        //                // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

        //                textBoxCCCD.Text = kt.Cccd.ToString();
        //                textBoxHoTen.Text = kt.HoTen.ToString();
        //                textBoxSoDT.Text = kt.Sdt.ToString();
        //                textBoxDiaChi.Text = kt.DiaChi.ToString();
        //                textBoxGhiChu.Text = kt.GhiChu.ToString();
        //                textBoxQueQuan.Text = kt.QueQuan.ToString();
        //                textBoxThongTinKhac.Text = kt.ThongTinKhac.ToString();
        //            }
        //        }
        //    }
        //}

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void buttonGhi_Click(object sender, EventArgs e)
        {

        }

        private void buttonKhongGhi_Click(object sender, EventArgs e)
        {

        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {

        }

        
    }
}
