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
using System.Windows.Forms;

namespace OpenProgamSet
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer PlayerLogin;
        private void LoginMusic(String url)
        {
            PlayerLogin = new WMPLib.WindowsMediaPlayer();
            PlayerLogin.URL = url;
            PlayerLogin.controls.play();
            PlayerLogin.settings.volume = 20;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Usernametext.BackgroundImage = Properties.Resources.Login;
            panel1.ForeColor = Color.FromArgb(0, 255, 0);
            if (Usernametext.Text == "AdminCode")
            {
                Usernametext.ForeColor = Color.FromArgb(0, 255, 0);
                Console.Beep();
            }
        }

        private void Passtext_TextChanged(object sender, EventArgs e)
        {
                Passtext.PasswordChar = '*';
                Emailtext.BackgroundImage = Properties.Resources.Login;
                panel1.ForeColor = Color.FromArgb(0, 255, 0);
                Emailtext.ForeColor = Color.FromArgb(0, 255, 0);
        }
        private void ETEXT_TextChanged(object sender, EventArgs e)
        {
            ETEXT.BackgroundImage = Properties.Resources.Login;
            panel1.ForeColor = Color.FromArgb(0, 255, 0);
            ETEXT.ForeColor = Color.FromArgb(0, 255, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Usernametext.Text == "AdminCode" && Passwordtext.Text == "74122541" && Emailtext.Text == "Mashiro74122541@gmail.com") //ADMIN USER ONLY
            {
                LoginMusic(@"C:\Users\BungK\source\repos\OpenProgamSet\OpenProgamSet\Sound\HelloLoginMusic.wav");
                PCC OpenAdminCode = new PCC();
                OpenAdminCode.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void inputemail_TextChanged(object sender, EventArgs e)
        {
            if (Emailtext.Text == "Mashiro74122541@gmail.com")
            {
                Emailtext.ForeColor = Color.FromArgb(0, 255, 0);
                Console.Beep();
            }
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Passwordtext.Text == "74122541")
            {
                Passwordtext.ForeColor = Color.FromArgb(0, 255, 0);
                Console.Beep();
            }
        }

        private void ExitPCC_Click(object sender, EventArgs e)
        {
         this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}