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
    public partial class newPassword : Form
    {

        private static string pass = "";

        public newPassword()
        {
            InitializeComponent();
        }

        private void NoweHasloTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoweHasloTextBox.Text.Length > 5)
            {
                Progressbar.Value = 100;
            }
            else
            {
                Progressbar.Value = (100 / 5) * NoweHasloTextBox.Text.Length;
            }
        }


        private void ShowPWD_MouseDown(object sender, MouseEventArgs e)
        {
            NoweHasloTextBox.UseSystemPasswordChar = false;
            PowtozNoweHasloTextBox.UseSystemPasswordChar = false;
            ShowPWD.Text = "Unsee Password";
        }

       

        private void ShowPWD_MouseLeave(object sender, EventArgs e)
        {
            NoweHasloTextBox.UseSystemPasswordChar = true;
            PowtozNoweHasloTextBox.UseSystemPasswordChar = true;
            ShowPWD.Text = "see Password";
        }

       

        private void ShowPWD_MouseUp(object sender, MouseEventArgs e)
        {
            NoweHasloTextBox.UseSystemPasswordChar = true;
            PowtozNoweHasloTextBox.UseSystemPasswordChar = true;
            ShowPWD.Text = "See Password";
        }

        private void SetPwd_Click(object sender, EventArgs e)
        {
            if (NoweHasloTextBox.Text == PowtozNoweHasloTextBox.Text)
            {
                pass = NoweHasloTextBox.Text;
                this.Close();
            }
            else if (NoweHasloTextBox.Text.Length < 6)
            {
                MessageBox.Show("Too Short Password!", "Short Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Passwords Are Not the same!", "Wrong Passwords!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPWD_Click(object sender, EventArgs e)
        {
            
        }
        public static string getPassword()
        {
            return pass;
        }
    }
}