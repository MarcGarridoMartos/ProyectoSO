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

namespace WindowsFormsApplication1
{
    
    public partial class Form3 : Form
    {
        Socket server;
        //Threads thread;
        public Form3(Socket server)
        {
            InitializeComponent();
            this.server =  server;
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            // Enviamos nombre, contraseña y edad
            if (nombreBox2.Text == "")
                MessageBox.Show("Falta añadir el nombre");
            if (contraBox2.Text == "")
                MessageBox.Show("Falta añadir la contraseña");
            if (edadBox2.Text == "")
                MessageBox.Show("Falta añadir la edad");
            if (ciudadBox2.Text == "")
                MessageBox.Show("Falta añadir la ciudad");
            if (nombreBox2.Text != "" && contraBox2.Text != "" && edadBox2.Text != "" && ciudadBox2.Text != "")
            {
                string mensaje = "5/" + nombreBox2.Text + "/" + contraBox2.Text + "/" + edadBox2.Text + "/" + ciudadBox2.Text ;
                //Creamos el socket 
                //server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //IPAddress direc = IPAddress.Parse("192.168.56.103"); //------------------------------------------------------------------
                //IPEndPoint ipep = new IPEndPoint(direc, 9050);       //------------------------------------------------------------------


                try
                {
                    //Intentamos conectar el socket
                    //server.Connect(ipep);
                    //MessageBox.Show("Conectado");
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                }
                catch (SocketException)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
                if (mensaje == "-1")
                    MessageBox.Show("No se ha podido registrar al usuario");

                if (mensaje == "1")
                {
                    MessageBox.Show("Se ha registrado al usuario");
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_Click_1(object sender, EventArgs e)
        {
            //int i = 0;

            // Enviamos nombre y contraseña
            string mensaje = "4/" + nombreBox1.Text + "/" + contraBox1.Text;
            // Enviamos al servidor el nombre tecleado

            if (nombreBox1.Text == "")
                MessageBox.Show("Falta añadir el nombre");
            if (contraBox1.Text == "")
                MessageBox.Show("Falta añadir la contraseña");
            if (nombreBox1.Text != "" && contraBox1.Text != "")
            {
                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress direc = IPAddress.Parse("192.168.56.103"); //------------------------------------------------------------------
                IPEndPoint ipep = new IPEndPoint(direc, 9050);       //------------------------------------------------------------------


                try
                {
                    //Intentamos conectar el socket
                    server.Connect(ipep);
                    //MessageBox.Show("Conectado");
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                }
                catch (SocketException)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
               
            }
            

            if (mensaje == "-1")
                MessageBox.Show("El usuario o la contraseña son incorrectos");

            if (mensaje == "1")
            {
                MessageBox.Show("El usuario y la contraseña son correctos");
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }

            //if (mensaje == "-2")
            //    MessageBox.Show("Base de datos vacia");
            //MessageBox.Show("Tu nombre no esta en la base de datos");
        }
        private void contraBox2_TextChanged(object sender, EventArgs e)
        {}
        private void nombreBox1_TextChanged(object sender, EventArgs e)
        {}
        private void edadBox1_TextChanged(object sender, EventArgs e)
        {}
        private void ciudadBox2_TextChanged(object sender, EventArgs e)
        {}
        private void contraBox2_TextChanged_1(object sender, EventArgs e)
        {}
        private void nombreBox2_TextChanged(object sender, EventArgs e)
        {}
    }
}
