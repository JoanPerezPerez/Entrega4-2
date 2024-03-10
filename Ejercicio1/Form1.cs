using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Socket socket;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.1");
            IPEndPoint ipep = new IPEndPoint(direc, 9000);


            //Creamos el socket 
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor"+ ex);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "0/";
                socket.Send(Encoding.ASCII.GetBytes(input));

                this.BackColor = Color.Gray;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error al enviar datos al servidor debido a: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] msg2 = new byte[1024];
                int dataSize = socket.Receive(msg2);
                string respuesta = Encoding.ASCII.GetString(msg2, 0, dataSize);
                MessageBox.Show(respuesta);

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error al recibir datos del servidor debido a: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input;
                if (Longitud.Checked)
                {
                    input = "1/" + textBox1.Text;
                }
                else if (Bonito.Checked)
                {
                    input = "2/" + textBox1.Text;
                }
                else
                {
                    input = "3/" + textBox1.Text + textBox2.Text;
                }

                socket.Send(Encoding.ASCII.GetBytes(input));
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error al enviar datos al servidor debido a: " + ex.Message);
            }
        }
    }
}

