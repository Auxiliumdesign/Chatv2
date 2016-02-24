using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SägHej
{
	public partial class KlientForm : Form
	{
		TcpClient klient = new TcpClient();

		public KlientForm( )
		{
			InitializeComponent();
            klient.NoDelay = true;
		}

		private void btnSägHej_Click( object sender, EventArgs e )
		{
            StartSending(tbxMessage.Text);
            tbxMessage.Clear();
		}

        public async void Connect ( )
        {
            IPAddress adress = IPAddress.Parse( tbxIPAdress.Text );
			int       port   = int.Parse( tbxPort.Text );

            try {
			    await klient.ConnectAsync( adress, port );
            }
            catch ( Exception error ) { MessageBox.Show( error.Message, "Klientfel" ); return; }

			btnSend.Enabled = true;
            btnAnslut.Enabled = false;
            StartSending(tbxUsername.Text);
        }
        public async void StartSending ( string message )
        {
            if ( klient.Connected )
            {
                byte[] utData = Encoding.Unicode.GetBytes(message);

                try {
				    await klient.GetStream().WriteAsync( utData, 0, utData.Length );
                }
                catch ( Exception error ) { MessageBox.Show( error.Message, "Klientfel" ); return; }
            }
        }

		private void KlientForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( klient != null )	klient.Close();
		}

        private void btnAnslut_Click( object sender, EventArgs e )
        {
            if ( ! klient.Connected ) Connect();
            
        }
        private void tbxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                StartSending(tbxMessage.Text);
                tbxMessage.Clear();
            }
        }

        /*metod för att läsa från servern??
        public async void StartReading(TcpClient k)
        {
            byte[] buffer = new byte[1024];

            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffer, 0, 1024);
            }
            catch (Exception error) { MessageBox.Show(error.Message, "Serverfel"); return; }

            tbxKlientData.AppendText(Encoding.Unicode.GetString(buffer, 0, n) + Environment.NewLine);
            StartReading(k);
        }
         */
	}
}
