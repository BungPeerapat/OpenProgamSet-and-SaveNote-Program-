using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProgamSet
{
    public partial class PCC : Form
    {
        public PCC()
        {
            InitializeComponent();
            PlayFile(@"C:\Users\BungK\source\repos\OpenProgamSet\OpenProgamSet\Sound\Loading Sound.wma");
        }
        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Rpsgame = new ProcessStartInfo();
            Rpsgame.FileName = @"C:\Users\BungK\source\repos\OpenProgamSet\Rock-Paper-Scissors Game.exe";
            Process.Start(Rpsgame);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Solar = new ProcessStartInfo();
            ProcessStartInfo Minecraft = new ProcessStartInfo();
            ProcessStartInfo tluncher = new ProcessStartInfo();
            ///////////////////////////////////////////
            //Open FIle Program!
            Solar.FileName = @"C:\Users\BungK\AppData\Roaming\Solar-PuTTY-v4\Solar-PuTTY.exe";
            Minecraft.FileName = @"C:\Users\BungK\AppData\Roaming\.minecraft";
            tluncher.FileName = @"C:\Users\BungK\AppData\Roaming\.minecraft\TLauncher.exe";
            Solar.Arguments = "header.h";
            Minecraft.Arguments = "header.h";
            tluncher.Arguments = "header.h";
            Process.Start(Solar);
            Process.Start(tluncher);
            Process.Start(Minecraft);
            ///////////////////////////////////////////
            //Open Taskmanager!

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            /////////////////////// Create Processer For GamePack\\\\\\\\\\\\\\\
            ProcessStartInfo Steam = new ProcessStartInfo();
            ProcessStartInfo DragonCenter = new ProcessStartInfo();
            /////////////////////// Start Program \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            Steam.FileName = @"E:\Program Files (x86)\Steam\Steam.exe";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\BungK\source\repos\OpenProgamSet\OpenProgamSet\Soundfahsai_hallo.mp3");
            player.Play();
            /////////////////////// Open Program \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            System.Diagnostics.Process.Start("https://www.facebook.com/");
            System.Diagnostics.Process.Start("https://www.google.com/");
            Process.Start(Steam);
        }

        private void Calucator_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("calc");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());

        }

        private void ExitPCC_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 OpenForm1 = new Form1();
            OpenForm1.Show();
        }

        WMPLib.WindowsMediaPlayer Player;
        private void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.play();
            Player.settings.volume = 20;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PlayFile(@"C:\Users\BungK\source\repos\OpenProgamSet\OpenProgamSet\Sound\TestFile.wma");
        }
        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {

            }
        }
        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
        }

        private void PCC_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client OpenForm3 = new Client();
            OpenForm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\BungK\source\repos\OpenProgamSet\RemoteDesktopServer\bin\Debug\RemoteDesktopServer.exe");
        }
    }
}
