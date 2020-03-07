using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktopServer
{
    public partial class RemoteDesktopServer : Form
    {
        public RemoteDesktopServer()
        {
            InitializeComponent();
        }

        private void textPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlisten_Click(object sender, EventArgs e)
        {
            int port = int.Parse(textPort.Text);
            new DisplayScreen(port).Show();
        }
    }
}
