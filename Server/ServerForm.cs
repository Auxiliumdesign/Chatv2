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

namespace Server
{
	public partial class ServerForm : Form
	{
        //initierar lyssnare, och klient
		TcpListener	listener;
		TcpClient	client;
        //skapar en ny lista med användare
        List<User> users = new List<User>();
        IPAddress   hostAddress;
        // visar vår adress
		public ServerForm( )
		{
			InitializeComponent();
            string hostName = Dns.GetHostName();
            IPAddress[] hostAddresses = Dns.GetHostAddresses( hostName );
            foreach ( IPAddress address in hostAddresses )
            {
                if ( address.AddressFamily == AddressFamily.InterNetwork )
                {
                    hostAddress = address;
                    Text = hostName + ": " + address.ToString();
                }
            }
		}
        // Börjar lyssna efter anslutningar på vald port
		private void btnLyssna_Click( object sender, EventArgs e )
		{
			listener = new TcpListener( hostAddress, int.Parse( tbxPort.Text ) );
			listener.Start();
			StartAccepting();
		}
        //Börjar acceptera klienter
        public async void StartAccepting()
        {
            try
            {
                //väntar på en anslutande klient
                client = await listener.AcceptTcpClientAsync();
                //Skapar en ny user av klassen User
                User newUser = new User();
                newUser.client = client;
                //Lägger till newUser i listan users
                users.Add(newUser);
                //initierar metoden Läs
                Läs(newUser);
            }
            catch ( Exception error )
            {
                MessageBox.Show( error.Message, "Serverfel" );
                return;
            }
            //börjar om asyncen
            StartAccepting();
        }
        //private?
        private async void Läs(User u)
        {
            byte[] data = new byte[1024];
            await u.client.GetStream().ReadAsync(data, 0, 1024);
            //om det ej finns något användarnamn definierat så tilldelas det av första meddelandet
            if (u.username == null)
            {
                u.username = data.ToString();
            }
            StartReading(client);
        }
        //börjar läsa den skickade informationen från klienten
        public async void StartReading( TcpClient k )
        {
            byte[] buffer = new byte[1024];

			int n = 0;
            try {
                n = await k.GetStream().ReadAsync( buffer, 0, 1024 );
                }
            catch ( Exception error ) { MessageBox.Show( error.Message, "Serverfel" ); return;}
            
            tbxKlientData.AppendText(Encoding.Unicode.GetString( buffer, 0, n ) + Environment.NewLine);
            StartReading( k );
        }
        //Funktion för att skicka?
        /*public async void StartSending(string message)
        {
            for (int i = 0; users.Count > i; i++)
            {
                if (client.Connected)
                {
                    byte[] utData = Encoding.Unicode.GetBytes("Hej!");

                    try
                    {
                        await client.GetStream().WriteAsync(utData, 0, utData.Length);
                    }
                    catch (Exception error) { MessageBox.Show(error.Message, "Klientfel"); return; }
                } 

            }     
        }*/
	}
}
