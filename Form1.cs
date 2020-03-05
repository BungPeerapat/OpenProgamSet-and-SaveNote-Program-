using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OpenProgamSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackgroundImage = Properties.Resources.Login;
            panel1.ForeColor = Color.FromArgb(0, 255, 0);
            textBox1.ForeColor = Color.FromArgb(0, 255, 0);
        }

        private void Passtext_TextChanged(object sender, EventArgs e)
        {
                Passtext.PasswordChar = '*';
                inputemail.BackgroundImage = Properties.Resources.Login;
                panel1.ForeColor = Color.FromArgb(0, 255, 0);
                inputemail.ForeColor = Color.FromArgb(0, 255, 0);
        }
        private void ETEXT_TextChanged(object sender, EventArgs e)
        {
            ETEXT.BackgroundImage = Properties.Resources.Login;
            panel1.ForeColor = Color.FromArgb(0, 255, 0);
            ETEXT.ForeColor = Color.FromArgb(0, 255, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "AdminCode") //ADMIN USER ONLY
            {
                if (Passtext.Text == "74122541")
                {
                    if (inputemail.Text == "Mashiro74122541@gmail.com")
                    {
                        PCC OpenPCC = new PCC();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void inputemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/?tab=wm1#inbox");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BungJuChicken?tab=repositories");
        }
    }
}