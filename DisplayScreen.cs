using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktopServer
{
    public partial class DisplayScreen : Form
    {
        private TcpClient client;
        private TcpListener server;
        private Thread listening;
        private Thread getImage;
        private NetworkStream nSteam;
        private int port;

        public object IpAddress { get; private set; }

        public DisplayScreen(int port)
        {
            InitializeComponent();
            client = new TcpClient();
            listening = new Thread(startListening);
            getImage = new Thread(receiveImage);
            this.port = port;
        }
        private void receiveImage()
        {
            BinaryFormatter bin = new BinaryFormatter();
            while (client.Connected)
            {
                nSteam = client.GetStream();
                pictureBox1.Image = (Image)bin.Deserialize(nSteam);
            }
        }
        private void startListening()
        {
            while (!client.Connected)
            {
                server.Start();
                client = server.AcceptTcpClient();
            }
            getImage.Start();
        }

        private void DisplayScreen_Load(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, port);
            listening.Start();

        }

        private void DisplayScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopListening();
        }

        private void stopListening()
        {
            server.Stop();
            client = null;
            if (listening.IsAlive)
            {
                listening.Abort();
            }
            if (getImage.IsAlive)
            {
                getImage.Abort();
            }
        }
    }
}
