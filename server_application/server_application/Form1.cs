using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace server_application
{
    public partial class Form1 : Form
    {

        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> clientSockets = new List<Socket>();

        bool terminating = false;
        bool listening = false;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button1_listen_Click(object sender, EventArgs e)
        {
            int serverPort;

            if (Int32.TryParse(textBox1_port.Text, out serverPort))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(3);

                listening = true;
                button1_listen.Enabled = false;
                //textBox2_message.Enabled = true;
                //button2_send.Enabled = true;

                Thread acceptThread = new Thread(Accept);
                acceptThread.Start();

                richTextBox1.AppendText("Started listening on port: " + serverPort + "\n");

            }
            else
            {
                richTextBox1.AppendText("Please check port number \n");
            }
        }
        private void Accept()
        {
            while (listening)
            {
                try
                {
                    Socket newClient = serverSocket.Accept();
                    clientSockets.Add(newClient);
                    richTextBox1.AppendText("A client is connected. \n");

                    Thread receiveThread = new Thread(() => Receive(newClient));
                    receiveThread.Start();
                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        richTextBox1.AppendText("The socket stopped working.\n");
                    }
                }
            }
        }
        private void Receive(Socket thisClient)
        {

            bool connected = true;

            while (connected && !terminating)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    thisClient.Receive(buffer);

                    string incominMessage = Encoding.Default.GetString(buffer);
                    using (StreamWriter file = new StreamWriter(@"C:\Users\ESRA\OneDrive\Masaüstü\database.txt", append: true))
                    {
                        file.WriteLine(incominMessage);
                    }

                    incominMessage = incominMessage.Substring(0, incominMessage.IndexOf("\0"));
                    richTextBox1.AppendText("Client with the username " + incominMessage.Substring(0, incominMessage.IndexOf("-")) + " has created an account\n");
                }
                catch
                {
                    if (!terminating)
                    {

                        richTextBox1.AppendText("Client has disconnected\n");
                    }
                    thisClient.Close();
                    clientSockets.Remove(thisClient);
                    connected = false;
                }
            }
        }    
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }
    }
}
