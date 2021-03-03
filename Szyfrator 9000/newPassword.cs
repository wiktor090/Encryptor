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
        public newPassword()
        {
            InitializeComponent();
        }

        private void NoweHasloTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoweHasloTextBox.Text.Length > 6)
            {
                Progressbar.Value = 100 * NoweHasloTextBox.Text.Length;
            }
        }

        private void PowtozNoweHasloTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPWD_MouseDown(object sender, MouseEventArgs e)
        {
            NoweHasloTextBox.UseSystemPasswordChar = false;
            PowtozNoweHasloTextBox.UseSystemPasswordChar = true;
            ShowPWD.Text = "Unsee Password";
        }

        private void SetPwd_Click(object sender, EventArgs e)
        {

        }

        private void ShowPWD_MouseLeave(object sender, EventArgs e)
        {
            NoweHasloTextBox.UseSystemPasswordChar = false;
            PowtozNoweHasloTextBox.UseSystemPasswordChar = true;
            ShowPWD.Text = "Unsee Password";
        }
    }
}