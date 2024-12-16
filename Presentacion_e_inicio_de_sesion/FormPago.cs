using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion_e_inicio_de_sesion.FormPrincipal;

namespace Presentacion_e_inicio_de_sesion
{
    public partial class FormPago : Form
    {
        private string nombreusuario;
        private List<DetalleCompra> detallesCompra;

        // Constructor que recibe detalles de la compra
        public FormPago(string nombreUsuario, List<DetalleCompra> detallesCompra)
        {
            InitializeComponent();
            this.nombreusuario = nombreUsuario;
            this.detallesCompra = detallesCompra;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnMostrarTicket.Enabled = false;
            // Mostrar los detalles de la compra
            MostrarDetallesCompra();

            // Calcular el total de la compra sumando los valores de los detalles
            double totalCompra = detallesCompra.Sum(detalle => detalle.Total); // Usamos el Total de cada DetalleCompra

            lbTotal.Text = "Total = $" + totalCompra.ToString();
            label1.Text = nombreusuario.ToString();
        }

        private void MostrarDetallesCompra()
        {
            // Limpiar cualquier texto anterior
            LimpiarLabels();

            // Recorrer la lista de detalles de compra y mostrar cada uno en sus respectivos labels
            foreach (var detalle in detallesCompra)
            {
                lblProducto.Text += detalle.NombreProducto + "\n";
                lblCantidad.Text += detalle.Cantidad.ToString() + "\n";
                lblPrecioUnitario.Text += "$" + detalle.PrecioUnitario.ToString() + "\n";
                lblTotal.Text += "$" + detalle.Total.ToString() + "\n";
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            // Ocultar ambos GroupBox al inicio
            gbcredito_debito.Visible = false;
            gbEfectivo.Visible = false;

            // Mostrar el GroupBox correspondiente según la opción seleccionada
            if (rdCredito.Checked || rdDebito.Checked)
            {
                gbcredito_debito.Visible = true;
                LimpiarCamposEfectivo(); // Limpiar campos de efectivo
            }
            else if (rdEfectivo.Checked)
            {
                gbEfectivo.Visible = true;
                LimpiarCamposTarjeta(); // Limpiar campos de tarjeta
            }
            else
            {
                MessageBox.Show("Selecciona una opción válida");
            }
        }

        private void LimpiarLabels()
        {
            lblProducto.Text = "";
            lblCantidad.Text = "";
            lblPrecioUnitario.Text = "";
            lblTotal.Text = "";
        }

        private void LimpiarCamposTarjeta()
        {
            txtnumTarjeta.Text = "";
            txtNombre.Text = "";
            txtCVC.Text = "";
            txtExpiracion.Text = "";
        }

        private void LimpiarCamposEfectivo()
        {
            txtPago.Text = "";
        }

        private void bttarjeta_Click(object sender, EventArgs e)
        {
            string num_tarjeta = txtnumTarjeta.Text;
            string nombre = txtNombre.Text;
            string cvc = txtCVC.Text;
            string expiracion = txtExpiracion.Text;
            bool confirmado = false;

            double totalCompra = detallesCompra.Sum(detalle => detalle.Total); // Total calculado de la lista

            if (num_tarjeta.Length == 16 && cvc.Length == 3 && int.TryParse(expiracion, out int expiraciona))
            {
                if (expiraciona >= 2024)
                {
                    MessageBox.Show("Datos Válidos, realizando compra...");
                    confirmado = true;
                    btnMostrarTicket.Enabled = true;
                    ActualizarUsuario(totalCompra);
                    mostrarTicket();
                    LimpiarCamposTarjeta();
                    LimpiarLabels();
                }
                else
                {
                    MessageBox.Show("Datos erróneos o expiró la tarjeta");
                    LimpiarCamposTarjeta();
                }
            }
        }

        private void btefectivo_Click(object sender, EventArgs e)
        {
            decimal pago = Convert.ToDecimal(txtPago.Text);
            decimal cambio = 0;
            bool confirmado = false;

            double totalCompra = detallesCompra.Sum(detalle => detalle.Total); // Total calculado de la lista

            if (pago < Convert.ToDecimal(totalCompra))
            {
                MessageBox.Show("El pago es menor y no se puede completar");
                LimpiarCamposEfectivo();
            }
            else
            {
                confirmado = true;
                btnMostrarTicket.Enabled = true;
                cambio = pago - Convert.ToDecimal(totalCompra);
                ActualizarUsuario(totalCompra);
                mostrarTicket();
                LimpiarCamposEfectivo();
                LimpiarLabels();
            }
        }

        private void ActualizarUsuario(double totalCompra)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.getConexion();
                conexion.actualizarTotalCompras(nombreusuario, totalCompra);
                conexion.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el total de compras: " + ex.Message);
            }
        }

        private void btnMostrarTicket_Click_1(object sender, EventArgs e)
        {
            mostrarTicket();
        }

        private void mostrarTicket()
        {
            // Calcular el total de la compra sumando los valores de los detalles
            double totalCompra = detallesCompra.Sum(detalle => detalle.Total);

            // Crear el formulario del ticket y mostrarlo
            FormTicket formTicket = new FormTicket(nombreusuario, DateTime.Now, totalCompra, detallesCompra);
            formTicket.Show();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///****
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// Codigo para arrastrar la ventana ***IGNORAR


    }
}
