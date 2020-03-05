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
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\BungK\Desktop\Roblox\fahsai_hallo.mp3");
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
    }
}
