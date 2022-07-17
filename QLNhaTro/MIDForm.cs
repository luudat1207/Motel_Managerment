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
    public partial class MIDForm : Form
    {
        public bool boolExit = true;
        public event EventHandler DangXuat;
        public MIDForm()
        {
            InitializeComponent();
        }

        private void MIDForm_Load(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boolExit)
                Application.Exit();
        }

        private void thôngTinChủNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChuNha frm = new FormChuNha();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //boolExit = false;
            //this.Close();
            //FormLogin f = new FormLogin();
            //f.Show();

            DangXuat(this, new EventArgs());
        }

        private void MIDForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(boolExit)
            Application.Exit();
        }

        private void tìnhTrạngPhòngTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTinhTrangPhongTro frm = new FormTinhTrangPhongTro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dịchVụChoThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDichVu frm = new FormDichVu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
