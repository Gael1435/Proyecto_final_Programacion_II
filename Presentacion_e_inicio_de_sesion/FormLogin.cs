using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using System.Data.SqlClient;
using MySql.Data.MySqlClient; // libreria para trabajar con la base de datos
using System.Runtime.InteropServices; // esta sirve para poder arrastrarlo

namespace Presentacion_e_inicio_de_sesion
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();

        }

        MySqlConnection conexion = new MySqlConnection();

        ///****
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /// Codigo para arrastrar la ventana ***IGNORAR

        public void Connect() // Funcion que verifica la correcta conexion de el programa con la base de datos y la conecta
        {
            string cadena = "Server=localhost; Database=pasteleria; User=root; Password=; SslMode=none;";
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

        private void formLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }




        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Llamamos a la funcion para conectar a la base de datos
            Connect();

            // Verificar si la cuenta existe
            string consultaCuenta = "SELECT * FROM tabla_usuarios WHERE Cuenta = @Cuenta";
            MySqlCommand comandoCuenta = new MySqlCommand(consultaCuenta, conexion);
            comandoCuenta.Parameters.AddWithValue("@Cuenta", txtboxUsuario.Text);
            MySqlDataReader lectorCuenta = comandoCuenta.ExecuteReader();

            if (lectorCuenta.HasRows)
            {
                lectorCuenta.Close();

                // Verificar si la contraseña es correcta
                string consulta = "SELECT * FROM tabla_usuarios WHERE Cuenta = @Cuenta AND Contraseña = @Contraseña";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Cuenta", txtboxUsuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtboxContra.Text);
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Read();

                    string tipo = lector["Tipo"].ToString();
                    string nombreUsuario = lector["Nombre Completo"].ToString();
                    FormPrincipal f3;

                    switch (tipo)
                    {
                        case "admin":
                            MessageBox.Show($"Bienvenido, {nombreUsuario}. Has ingresado como Administrador.");
                            f3 = new FormPrincipal(nombreUsuario, true);
                            this.Hide();
                            f3.ShowDialog();
                            this.Show();
                            break;

                        case "usuario":
                            MessageBox.Show($"Bienvenido, {nombreUsuario}. Has ingresado como Usuario.");
                            f3 = new FormPrincipal(nombreUsuario);
                            this.Hide();
                            f3.ShowDialog();
                            this.Show();
                            break;

                        case "guest":
                            MessageBox.Show("Bienvenido Invitado.");
                            this.Hide();
                            f3 = new FormPrincipal(nombreUsuario);
                            f3.ShowDialog();
                            this.Show();
                            break;
                    }

                    txtboxContra.Text = "";
                    txtboxUsuario.Text = "";
                    lector.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Acceso no autorizado.");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
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
                txtboxContra.Font = new Font("Yu Gothic UI", 14); // restablece la fuente a la original
                txtboxContra.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            conexion.Close(); // por si acaso
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // CODIGO PARA PODER ARRASTRAR LA VENTANA

        private void formLogin_MouseDown(object sender, MouseEventArgs e) // ventana principal
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) // Lado izquierdo de color rosa
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void lblInvitado_Click(object sender, EventArgs e)
        {
            // Llamamos a la función para conectar a la base de datos
            Connect();

            // Usar la cuenta de invitado
            string consulta = "SELECT * FROM tabla_usuarios WHERE Cuenta = 'Invitado' AND Contraseña = 'Invitado'";

            // Preparamos el comando para ejecutar la consulta
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // Ejecutamos la consulta y guardamos los resultados
            MySqlDataReader lector;
            lector = comando.ExecuteReader();

            // Evaluar si la cuenta de invitado existe
            if (lector.HasRows)
            {
                lector.Read();
                string nombreUsuario = lector["Nombre Completo"].ToString();

                FormPrincipal f3 = new FormPrincipal(nombreUsuario);
                this.Hide();
                f3.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Error al ingresar como invitado.");
            }

            lector.Close();
            conexion.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("D", new CultureInfo("es-ES")); // "D" para formato de fecha

            // Poner la primera letra en mayuscula en la fecha
            fecha = char.ToUpper(fecha[0]) + fecha.Substring(1);

            // Obtener la hora actual
            string hora = DateTime.Now.ToString("HH:mm:ss");

            // Actualizar el Label Fecha con la fecha y el Label Hora con la hora
            lblFecha.Text = fecha;
            lblHora.Text = hora;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


