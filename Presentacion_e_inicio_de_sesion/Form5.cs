using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_e_inicio_de_sesion
{
    public partial class Form5 : Form
    {
        private double totalCompra;
        private string nombreusuario;
        // Constructor que recibe el totalCompra
        public Form5(double totalCompra, string nombreUsuario)
        {
            InitializeComponent();
            this.nombreusuario = nombreUsuario;
            this.totalCompra = totalCompra;
        }

        public Form5()
        {
            InitializeComponent();
            gbcredito_debito.Visible = false;
            gbEfectivo.Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lbTotal.Text = "Total = $" + totalCompra.ToString();
            label1.Text = nombreusuario.ToString();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            gbcredito_debito.Visible = false;
            gbEfectivo.Visible = false;
            if (rdCredito.Checked)
            {
                gbcredito_debito.Visible = true;
            }
            else if (rdDebito.Checked)
            {
                gbcredito_debito.Visible = true;
            }
            else if (rdEfectivo.Checked)
            {
                gbEfectivo.Visible = true;
            }
            else if (rdOxxo.Checked)
            {
                //para azael y el qr
            }
            else
            {
                MessageBox.Show("Selecciona una opcion valida");
            }
        }

        private void bttarjeta_Click(object sender, EventArgs e)
        {
            string num_tarjeta = txtnumTarjeta.Text;
            string nombre = txtNombre.Text;
            string cvc = txtCVC.Text;
            string expiracion = txtExpiracion.Text;
            bool confirmado = false;
            if (num_tarjeta.Length == 16 && cvc.Length == 3 && int.TryParse(expiracion, out int expiraciona))
            {
                if (expiraciona >= 2024)
                {
                    MessageBox.Show("Datos Validos, realizando compra");
                    confirmado = true;
                    ActualizarUsuario();
                    Form3 form3 = new Form3(confirmado);
                    form3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos erroneos o expiro la tarjeta");
                }
            }
        }

        


        private void btefectivo_Click(object sender, EventArgs e)
        {
            decimal pago = Convert.ToDecimal(txtPago.Text);
            decimal cambio = 0;

            if (pago < Convert.ToDecimal(totalCompra))
            {
                MessageBox.Show("El pago es menor y no se puede completar");
            }
            else
            {
                cambio = pago - Convert.ToDecimal(totalCompra);
                MessageBox.Show("Su cambio es de $" + cambio);
                ActualizarUsuario();
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
        }

        private void ActualizarUsuario()//actualiza cuanto ha comprado el usuario
        {
            try
            {
                // Crear una instancia de la clase Conexion
                Conexion conexion = new Conexion();

                // Establecer la conexión con la base de datos
                conexion.getConexion();

                // Llamar al método de la clase Conexion que actualiza el total de compras del usuario
                conexion.actualizarTotalCompras(nombreusuario, totalCompra);

                conexion.desconectar();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre algún problema
                MessageBox.Show("Error al actualizar el total de compras: " + ex.Message);
            }
        }

    }
}
