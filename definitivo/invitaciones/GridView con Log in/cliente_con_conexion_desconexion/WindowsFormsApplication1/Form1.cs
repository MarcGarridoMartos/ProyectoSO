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
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;
        delegate void DelegadoParaEscribir(string mensaje);
        delegate void DelegadoParaChat(string mensaje);

        string[] trozos;
        int c;
        //int socket_invita, socket_invitado;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public void Chat(string s)
        {
            listBox1.Items.Add(s);
        }
        public void lconectados(string s)
        {
            trozos = s.Split('/');
            dataGridView1.Rows.Clear();
            for (int i = 0; i < trozos.Length; i++)
                dataGridView1.Rows.Add(trozos[i]);
        }

        //Indicamos valores para ver que funciona el datagridview correctamente
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenido";
            btnAbrir.Visible = false;
            label12.Visible = false;
            listBox2.Visible = false;
            mensaje2.Visible = false;
            chatBox2.Visible = false;
            button7.Visible = false;
            btnAceptar.Visible = false;
            btnRechazar.Visible = false;
        }


        private void AtenderServidor()
        {
            //string mensajevuelta;
            bool terminar = false;
            while (!terminar)
            {
                //Recibimos el mensaje del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string mensaje = Encoding.ASCII.GetString(msg2).TrimEnd('\0');
                mensaje = mensaje.TrimEnd('\0');
                trozos = mensaje.Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                switch (codigo)
                {
                    case 0:
                        c = 0;
                        this.BackColor = Color.Gray;
                        listBox1.Items.Clear();
                        this.Text = "Hasta la vista!";
                        DelegadoParaEscribir delegado = new DelegadoParaEscribir(lconectados);
                        server.Shutdown(SocketShutdown.Both);
                        server.Close();
                        atender.Abort();
                    break;

                    case 1: //Respuesta a contraseña
                        if (trozos[1].TrimEnd('\0') == "-1")
                            MessageBox.Show("El usuario no existe");
                        else
                            MessageBox.Show("La contraseña de "+ nombre.Text + " es: " + trozos[1]);
                    break;
                    case 4: //Cuando alguien hace log in
                    if (trozos[1] == "-1")
                        MessageBox.Show("No se ha podido loguear el usuario");
                    else
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.RowCount = trozos.Length - 1;
                        if (c==0){
                            this.Text = trozos[trozos.Length-1];
                            c = 1;
                        }
                        for (int i = 1; i < trozos.Length; i++)
                            dataGridView1.Rows[i-1].Cells[0].Value = trozos[i];
                    }
                    break;
                    case 6: //Cambio en la lista conectados
                        if(c!=0){
                        dataGridView1.Rows.Clear();
                           for (int i = 1; i < trozos.Length; i++)
                                dataGridView1.Rows.Add(trozos[i]);
                        }
                    break;

                    case 8: //Encontrar el socket de quien buscamos
                    if (trozos [1] == "0")
                        label10.Text = "No hay jugadores conectados";
                    else if (trozos[1] == "-1")
                        label10.Text = "El jugador no se encuentra conectado";
                    else if (trozos[1] != "-1")
                        label10.Text = "El jugador " + BuscaBox1.Text + " esta conectado y tiene el socket " + trozos[1];
                    break;

                    case 9:  //Enviar un mensaje en el chat
                    if (c != 0){
                        DelegadoParaChat delegadoc = new DelegadoParaChat(Chat);
                        listBox1.Invoke(delegadoc, new object[] { trozos[1] + ": " + trozos[2] });
                    }
                    break;

                    case 10:   //Invitar a alguien
                        MessageBox.Show(trozos[2] + " te ha invitado a chatear");
                        btnAceptar.Visible = true;
                        btnRechazar.Visible = true;
                    break;
                    case 11:
                    if (trozos[1] == "si")
                    {
                        label12.Visible = true;
                        listBox2.Visible = true;
                        mensaje2.Visible = true;
                        chatBox2.Visible = true;
                        button7.Visible = true;
                    }
                    else
                        MessageBox.Show("Tu invitación ha sido rechazada");
                    break;
                    case 12:
                                                DelegadoParaChat delegadocprivado = new DelegadoParaChat(Chat);
                        listBox2.Invoke(delegadocprivado, new object[] { trozos[1] + ": " + trozos[2] });
                    break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor ----------------------------------------------------------
            //al que deseamos conectarnos                                        ---------------------------------------------------------
            IPAddress direc = IPAddress.Parse(IP.Text);
            IPEndPoint ipep = new IPEndPoint(direc, Convert.ToInt32(puerto.Text));
            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");
            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            ThreadStart ts = delegate {AtenderServidor();};
            atender = new Thread(ts);
            atender.Start();
            Thread.Sleep(2000);
            //nada más iniciar le enviamos el 6/ al servidor para que nos envíe los conectados
            string mensaje = "6/" + nombre.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Contraseña.Checked)
            {
                try
                {
                    string mensaje = "1/" + nombre.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                    //Recibimos la respuesta del servidor
                }
                catch (FormatException)
                {
                    MessageBox.Show("El formato de los datos es incorrecto");
                    return;
                }
            }
            else if (PartidaLarga.Checked)
            {
                try
                {
                    string mensaje = "2/" + nombre.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                    //Recibimos la respuesta del servidor
                    if (mensaje == "-1")
                        MessageBox.Show("El usuario "+ nombre.Text +" no ha ganado ninguna partida");
                    else
                        MessageBox.Show(nombre.Text +" ha ganado en: "+ mensaje);
                }
                catch (FormatException)
                {
                    MessageBox.Show("El formato de los datos es incorrecto");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";
            mensaje = mensaje + this.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            // Nos desconectamos
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        //Botón que nos envía al form 2
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //form2.ShowDialog(); como variante
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {}
        private void Bonito_CheckedChanged(object sender, EventArgs e)
        {}
        private void nombre_TextChanged(object sender, EventArgs e)
        {}
        private void PartidaLarga_CheckedChanged(object sender, EventArgs e)
        {}
        private void altura_CheckedChanged(object sender, EventArgs e)
        {}
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {}
        private void LogIn_Click_1(object sender, EventArgs e)
        {
            //Nos aseguramos de que los textBox no estén vacios
            if (NombreBox1.Text == "")
                MessageBox.Show("Falta añadir el nombre");
            if (PassBox1.Text == "")
                MessageBox.Show("Falta añadir la contraseña");
            // Enviamos nombre y contraseña
            string mensaje = "4/" + NombreBox1.Text + "/" + PassBox1.Text;
            //MessageBox.Show("Conectado");
            try
            {
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }
        private void registrarse_Click(object sender, EventArgs e)
        {
            // Enviamos nombre, contraseña, edad y ciudad después de ver que los textbox no estan vacíos
            if (NombreBox2.Text == "")
                MessageBox.Show("Falta añadir el nombre");
            if (PassBox2.Text == "")
                MessageBox.Show("Falta añadir la contraseña");
            if (EdadBox2.Text == "")
                MessageBox.Show("Falta añadir la edad");
            if (CiudadBox2.Text == "")
                MessageBox.Show("Falta añadir la ciudad");
            if (NombreBox2.Text != "" && PassBox2.Text != "" && EdadBox2.Text != "" && CiudadBox2.Text != "")
            {
                string mensaje = "5/" + NombreBox2.Text + "/" + PassBox2.Text + "/" + EdadBox2.Text + "/" + CiudadBox2.Text;
                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress direc = IPAddress.Parse(IP.Text); //------------------------------------------------------------------
                IPEndPoint ipep = new IPEndPoint(direc, Convert.ToInt32(puerto.Text));       //------------------------------------------------------------------
                try
                {
                    //Intentamos conectar el socket
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
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
                    MessageBox.Show("Se ha registrado al usuario");
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            byte[] msg2 = new byte[80];
            //Nos aseguramos de que los textBox no estén vacios
            if (BuscaBox1.Text == "")
                MessageBox.Show("Falta añadir el nombre");
            // Enviamos nombre
            string mensaje = "8/" + BuscaBox1.Text;
            if (BuscaBox1.Text != "")
            {
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
            }          
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chatBox.Text != "")
            {
                string mensaje = "9/" + this.Text + "/" + chatBox.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                chatBox.Text = "";
            }
            else
                MessageBox.Show("No hay nada escrito");
        }
        private void btnInvitación_Click(object sender, EventArgs e)
        {
            string mensaje = "10/" + this.Text + "/" + BuscaBox1.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string mensaje = "12/" + this.Text + "/" + chatBox2.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            chatBox2.Text = "";
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "11/si";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            btnAceptar.Visible = false;
            btnRechazar.Visible = false;
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            string mensaje = "11/no";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            btnAceptar.Visible = false;
            btnRechazar.Visible = false;
        }
    }
}