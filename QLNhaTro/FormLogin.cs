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
    public partial class FormLogin : Form
    {
        
        List<User> users = new List<User>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(testLogIn(textBoxUsername.Text, textBoxPassword.Text)) { 
            MIDForm f = new MIDForm();
            f.Show();
            this.Hide();
            f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("the User name or password your entered incorrect!");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }
        }

        private void F_DangXuat(object? sender, EventArgs e)
        {
            (sender as MIDForm).boolExit = false;
            (sender as MIDForm).Close();
           this.Show(); 
        }

        bool testLogIn(string username, string password)
        {
            using(var context = new DBNhaTroContext())
            {
                users = context.Users.ToList();
            }
            for(int i = 0; i < users.Count; i++)
            {
                if(users[i].Username == username && users[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
