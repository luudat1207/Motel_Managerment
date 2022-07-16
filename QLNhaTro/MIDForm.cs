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
        public MIDForm()
        {
            InitializeComponent();
        }

        private void MIDForm_Load(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinChủNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChuNha frm = new FormChuNha();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
