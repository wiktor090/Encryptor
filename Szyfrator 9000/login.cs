using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrator_9000
{
    public partial class login : Form
    {
        private static string pass;

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pass = haslo.Text;
            this.Close();
        }

        public static string getPassword()
        {
            return pass;

        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void haslo_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new newPassword().Show();
        }
    }
}
