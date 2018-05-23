using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsChatFormServer
{
    public partial class Form1 : Form
    {
        private Socket serverSocket = null;
        private string serverIP = "127.0.0.1";
        private string serverPort = "8080";
        private IPAddress serverAddress = null;
        private IPEndPoint serverEndPoint = null;
        private int backlog = 1;

        private Boolean isServerStarted = false;
        private Boolean isClientConnected = false;

        private Socket connSocket = null;
        private Thread threadConn = null;

        private IPAddress clientAddress = null;
        private string clientPort = null;
        private IPEndPoint clientEndPoint = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartClientForm();
        }

        private void StartClientForm()
        {
            WindowsFormsChatFormClient.Form1 clientForm1 = new WindowsFormsChatFormClient.Form1();
            clientForm1.Show();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                if(serverSocket == null)
                {
                    serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    serverAddress = IPAddress.Parse(serverIP);
                    serverEndPoint = new IPEndPoint(serverAddress, int.Parse(serverPort));
                    serverSocket.Bind(serverEndPoint);
                }
                ShowMsg("Server Addr: " + serverSocket.LocalEndPoint.ToString());
                serverSocket.Listen(backlog);
                this.ShowMsg("Server Started...");
                isServerStarted = true;
            }
            catch(SocketException se)
            {
                MessageBox.Show(se.Message);
            }
            
            threadConn = new Thread(connect);
            threadConn.IsBackground = true;
            threadConn.Start();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            this.ShowMsg("Server Stopped...");
        }

        private void connect()
        {
            while(isServerStarted)
            {
                connSocket = serverSocket.Accept();
                clientEndPoint = connSocket.RemoteEndPoint as IPEndPoint;
                clientAddress = clientEndPoint.Address;
                clientPort = clientEndPoint.Port.ToString();
                ShowMsg("*********************\nClient Connected: " + "\n*********************");
            }
        }

        private void ShowMsg(string msg)
        {
            this.txtShow.AppendText(msg + "\n");
        }
    }
}
