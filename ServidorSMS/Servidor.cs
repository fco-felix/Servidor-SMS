using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorSMS
{
    public partial class Servidor : Form
    {
        public Servidor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rT_LogSMS.AppendText("Iniciar servidor\n");
            try
            {
                IniciarServidor(Int32.Parse(tB_Porta.Text));
                bT_Iniciar.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor incorreto para porta.", "Erro", 0, MessageBoxIcon.Error);
            }
        }
        public void IniciarServidor(int porta)
        {
            rT_LogSMS.AppendText("Iniciar servidor na porta " + Convert.ToString(porta) );

            // Establish the local endpoint for the socket.  
            // The DNS name of the computer  
            // running the listener is "host.contoso.com".  
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    // Set the event to nonsignaled state.  
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.  
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Wait until a connection is made before continuing.  
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();


        }
    }

}
