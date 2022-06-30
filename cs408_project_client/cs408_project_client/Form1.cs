using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;



namespace cs408_project_client
{
    public partial class Form1 : Form
    {
        bool terminating = false;
        bool connected = false;
        bool disconnected = false;
        Socket clientSocket;
        String username;
        List<String> users = new List<String>();

        public Form1()
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void button1_connect_Click(object sender, EventArgs e)
        {
            
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = textBox1_IP.Text;
            int portNum;
            username = textBox1_username.Text;

            if (!Int32.TryParse(textBox2_port.Text, out portNum))         //check inputs
            {
                richTextBox1.AppendText("Please check port number \n");
            }
            else if (IP == "")
            {
                richTextBox1.AppendText("Ip address slot can not be empty\n");
            }
            else if (username == "" || username.Length > 64)
            {
                richTextBox1.AppendText("User name is not in a valid length\n");
            }
            else                                            //inputs are valid
            {
                try
                {
                    clientSocket.Connect(IP, portNum);
                    checkConnection();                      //check whether server accepts this client
                }
                catch
                {
                    richTextBox1.AppendText("Could not connect to the server!\n");
                }
            }

        }

        private void checkConnection()  //send the user name and receive feedback from server, if connection is successful start receiving
        {
            try
            {
                Byte[] buffer = Encoding.Default.GetBytes(username);    //send username to server
                clientSocket.Send(buffer);

                Byte[] buffer_2 = new Byte[1];                          //receive feedback from the server
                clientSocket.Receive(buffer_2);                         //true or false

                if (buffer_2[0] > 0)    //if true
                {
                    button1_connect.Enabled = false;
                    textBox1_IP.Enabled = false;
                    textBox2_port.Enabled = false;
                    textBox1_username.Enabled = false;

                    connected = true;
                    disconnected = false;
                    richTextBox1.AppendText("Connected to the server!\n");

                    Thread receiveThread = new Thread(Receive);         //we are connected to the server, we can start receiving messages
                    receiveThread.Start();
                }
                else    //if false
                {
                    if (!terminating)
                    {
                        richTextBox1.AppendText("The server did not accept the user name!\n");
                        button1_connect.Enabled = true;
                       
                        //button_post.Enabled = false;
                    }
                    clientSocket.Close();
                    connected = false;
                }

            }
            catch
            {
                richTextBox1.AppendText("The server did not reply back about connection!\n");
            }
        }
        private void button1_send_Click(object sender, EventArgs e)
        {
            
        }
        private void Receive()
        {
            while (connected)
            {
                try
                {
                    Byte[] buffer = new Byte[64];            

                    clientSocket.Receive(buffer);
 
                    string incomingMessage = Encoding.Default.GetString(buffer);

                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));

                    //richTextBox1.AppendText("Server: " + incomingMessage + "\n");

                }
                catch
                {

                    if (!terminating)
                    {
                        //the sevrer is disconnected
                        richTextBox1.AppendText("The server has disconnected\n");
                        button1_send.Enabled = false;
                        button1_connect.Enabled = true;
                        textBox1_username.Enabled = false;

                    }
                    clientSocket.Close();
                    connected = false;
                }
            }
        }

        private void button2_disconnect_Click(object sender, EventArgs e)
        {
            connected = false;
            disconnected = true;
            clientSocket.Close();                   //close connection to the socket

            //richTextBox1.AppendText("Disconnected from the server\n");
           
            button2_disconnect.Enabled = false;
            

            button1_connect.Enabled = true;
            textBox1_IP.Enabled = true;
            textBox2_port.Enabled = true;
            textBox1_username.Enabled = true;

            richTextBox1.AppendText("you are (" + textBox1_username.Text + ") successfully disconnected from the server!\n");
        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }

        
    }
    
}