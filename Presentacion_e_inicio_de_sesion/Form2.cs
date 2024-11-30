using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;//libreria para trabajar con la base de datos
using System.Runtime.InteropServices;//esta sirve para poder arrastrarlo

namespace Presentacion_e_inicio_de_sesion
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("server = MARTHA;database=usuarios");

        ///****
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /// Codigo para arrastrar la ventana ***IGNORAR

        public void Connect() //Funcion que verifica la correcta conexion de el programa con la base de datos y la conecta
        {
            string cadena = "Server=localhost; Database=usuarios; User=root; Password=; SslMode=none;";
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void formLogin_Load(object sender, EventArgs e) { }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Llamamos a la funcion para conectar a la base de datos
            Connect();

            // Creamos la consulta SQL buscando el usuario y contraseña
            string consulta = "select * from tabla_usuarios where Cuenta = '" + txtboxUsuario.Text + "' and Contraseña = '" + txtboxContra.Text + "'";

            // Preparamos el comando para ejecutar la consulta
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // Ejecutamos la consulta y guardamos los resultados
            MySqlDataReader lector;
            lector = comando.ExecuteReader();


            //***AQUI SE DEBE AÑADIR LA LLAMADA A EL OTRO FORMULARIO QUE YA SERIA EL MAIN Y AQUI TAMBIEN SE EVALUA SI ES ADMIN O GUESS
            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecta");
            }



            conexion.Close();
        }


        private void txtboxUsuario_Enter(object sender, EventArgs e)
        {
            if (txtboxUsuario.Text == "USUARIO")
            {
                txtboxUsuario.Text = "";
                txtboxUsuario.ForeColor = Color.Black;
            }
        }

        private void txtboxUsuario_Leave(object sender, EventArgs e)
        {
            if (txtboxUsuario.Text == "")
            {
                txtboxUsuario.Text = "USUARIO";
                txtboxUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtboxContra_Enter(object sender, EventArgs e)
        {
            if (txtboxContra.Text == "CONTRASEÑA")
            {
                txtboxContra.Text = "";
                txtboxContra.ForeColor = Color.Black;
                txtboxContra.Font = new Font("Microsoft Sans Serif", 12); // Ajusta el tamaño y la serigrafia de los caracteres que ocultan la contraseña (....)
                txtboxContra.UseSystemPasswordChar = true; // contraseña se muestra oculta
            }
        }


        private void txtboxContra_Leave(object sender, EventArgs e)
        {
            if (txtboxContra.Text == "")
            {
                txtboxContra.Text = "CONTRASEÑA";
                txtboxContra.ForeColor = Color.DimGray;
                txtboxContra.Font = new Font("Yu Gothic UI", 14);//restablece la fuente a la original
                txtboxContra.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            conexion.Close();//por si acaso
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //CODIGO PARA PODER ARRASTRAR LA VENTANA

        private void formLogin_MouseDown(object sender, MouseEventArgs e) //ventana principal
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //Lado izquierdo de color rosa
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
