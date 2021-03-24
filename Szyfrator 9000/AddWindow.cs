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
    public partial class AddWindow : Form
    {
        public password NewItem;

        public AddWindow()
        {
            InitializeComponent();
        }


        private void AddWindow_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            NewItem = new password();
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Enter A Service Name", "Incomplete Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (LoginTextBox.Text == "")
            {
                MessageBox.Show("Enter A Login ", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((EmailTextBox.Text == "") || (!EmailTextBox.Text.Contains('@')))
            {
                MessageBox.Show("Enter A Email / @ ", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Enter A Password", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NewItem.Name = NameTextBox.Text;
                NewItem.Login = LoginTextBox.Text;
                NewItem.Email = EmailTextBox.Text;
                NewItem.Password = PasswordTextBox.Text;
                NewItem.Notes = NotesTextBox.Text;
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ShowPWD_Click(object sender, EventArgs e)
        {
           // PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;

            //if (PasswordTextBox.UseSystemPasswordChar)
           // {
           //     ShowPWD.Text = "Show Password";
            //}
           // else
           // {
             //   ShowPWD.Text = "Unshow Password";
            //}
        }

        private void ShowPWD_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
            ShowPWD.Text = "Unshow Password";
        }

        private void ShowPWD_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            ShowPWD.Text = "Show Password";
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
