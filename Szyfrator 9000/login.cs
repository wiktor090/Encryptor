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
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "weksel";
            if (haslo.Text == password)
            {
                Console.WriteLine("Sukcess");
                MessageBox.Show("Zalogowano", "Sukcess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Szyfrator().Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Puk Puk kto tam ZŁE HASŁO", "Hasło było złe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void haslo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
