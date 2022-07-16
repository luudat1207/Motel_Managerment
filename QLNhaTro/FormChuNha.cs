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
            dataGridViewChuNha.DataSource = Logics.ChuNhaManager.GetAllChuNha();


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
            buttonKhongGhi.Enabled= !open;
            

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
            ktThem = false;
            XoaTrang();
            KeyOpen(false);
            IDcu = Convert.ToInt32(textBoxID.Text);
            textHoTen.Focus();

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
        private void buttonGhi_Click(object sender, EventArgs e)
        {
            if(textHoTen.Text == "")
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
              
                String hoten = textHoTen.Text;
                String sdt = textSoDT.Text;
                String diachi = textDiaChi.Text;
                String ghichu = textGhiChu.Text;

                Chunha cn = new Chunha() { HoTen = "sds", Sdt = "43523454", DiaChi = "erwer", GhiChu = "rrwth" };
                //Chunha cn = new Chunha() { HoTen = hoten, Sdt = sdt , DiaChi = diachi, GhiChu = ghichu};
                context.Chunhas.Add(cn);
                context.SaveChanges();

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
            }catch (Exception ex) { }
        }

        

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
