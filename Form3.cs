using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProgamSet
{
    public partial class Client : Form
    {
        private TcpClient client = new TcpClient();
        private NetworkStream nsteam;
        private int portNumber;

        public Client()
        {
            InitializeComponent();
        }
        private static Image getDesktop()
        {
            Rectangle RegionScreen = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(RegionScreen.Width, RegionScreen.Height,System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphic = Graphics.FromImage(screenshot);
            graphic.CopyFromScreen(RegionScreen.X, RegionScreen.Y, 0, 0,RegionScreen.Size,CopyPixelOperation.SourceCopy);
            return screenshot;
        }

        public void sendDesktop()
        {
            BinaryFormatter bin = new BinaryFormatter();
            nsteam = client.GetStream();
            bin.Serialize(nsteam,getDesktop());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PORT_Click(object sender, EventArgs e)
        {
            
        }

        private void ConnetButton_Click(object sender, EventArgs e)
        {
            portNumber = int.Parse(PORTTEXT.Text);
            try
            {
                client.Connect(IPTEXT.Text, portNumber);
                MessageBox.Show("Conneted!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SSButton_Click(object sender, EventArgs e)
        {
            if (SSButton.Text.StartsWith("Show Screen"))
            {
                timer1.Start();
                SSButton.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                SSButton.Text = "Show Screen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sendDesktop();
        }
    }
}
