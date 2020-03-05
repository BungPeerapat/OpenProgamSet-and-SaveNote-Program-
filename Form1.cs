using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                textBox2.BackgroundImage = Properties.Resources.Login;
                panel1.ForeColor = Color.FromArgb(0, 255, 0);
                textBox2.ForeColor = Color.FromArgb(0, 255, 0);
        }
        private void ETEXT_TextChanged(object sender, EventArgs e)
        {
            ETEXT.BackgroundImage = Properties.Resources.Login;
            panel1.ForeColor = Color.FromArgb(0, 255, 0);
            ETEXT.ForeColor = Color.FromArgb(0, 255, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PCC OpenPCC = new PCC();
            if (Passtext.Text == "74122541")
            {
                OpenPCC.Show();
                this.Hide();
            }
        }
    }
}