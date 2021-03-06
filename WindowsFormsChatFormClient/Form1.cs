﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsChatFormClient
{
    public partial class Form1 : Form
    {
        private Socket clientSocket = null;
        private string serverIP = "127.0.0.1";
        private string serverPort = "8080";
        private IPAddress serverAddress = null;
        private IPEndPoint endPoint = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtShow.Text = "Form Loaded";
            this.Connect();
        }

        private void Connect()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverAddress = IPAddress.Parse(serverIP);
            endPoint = new IPEndPoint(serverAddress, int.Parse(serverPort));

            
        }

        private void ShowMsg(string msg)
        {
            this.txtShow.AppendText(msg + "\n");
        }
    }
}
