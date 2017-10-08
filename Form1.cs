using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace LamKimQuan_Bai2
{
    public partial class Form1 : Form
    {
        
        Socket server;
        Socket client;
        byte[] data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            server.Bind(ipep);
            server.Listen(10);
            client = server.Accept();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {


            send();
            receive();
               

               
               
            
            
        }
        public void send()
        {
            if (txtmess.Text == "")
            {
                MessageBox.Show("Ban chua nhap thong tin can gui");
            }
            else {
            data= Encoding.ASCII.GetBytes(txtmess.Text);
            client.Send(data);
            lbmess.Items.Add("server" + txtmess.Text);
            txtmess.Text = "";
            }
        }
        public void receive()
        {
            data = new byte[1024];
            
            if (data != null)
            {
                client.Receive(data);
                lbmess.Items.Add("Sever: " + Encoding.ASCII.GetString(data));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
    


    public void Disconnect()
    {
        client.Shutdown(SocketShutdown.Both);
        client.Close();
    }
}
}
