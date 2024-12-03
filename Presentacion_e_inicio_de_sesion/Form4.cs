using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentacion_e_inicio_de_sesion
{
    public partial class Administrador : Form
    {
        int contElement = 0; // Contador de productos
        // Diccionario de indices para las imagenes del pictureBox
        Dictionary<string, int> Diccionario = new Dictionary<string, int>();
        bool busqueda = false; // Auxiliar para cambiar el comportamiento del boton de Agregar a Eliminar
        private Conexion conexion = new Conexion();
        public Administrador()
        {
            InitializeComponent();
            conexion.getConexion();
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                // Genera el diccionario en base a los nombres de las imagenes
                string key = imageList1.Images.Keys[i];
                Diccionario[key] = i;
            }
            refrescar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (busqueda)
            {   // Funcion Eliminar
                if (contElement <= 6)
                {
                    MessageBox.Show("No puede haber menos de 6 productos!");
                }
                else
                {
                    conexion.eliminar(Convert.ToInt32(txtIdBuscar.Text));
                    btnBuscar.Text = "Buscar";
                    btnAgregar.Text = "Agregar";
                    busqueda = false;

                    txtId.Text = "";
                    txtDesc.Text = "";
                    txtNombre.Text = "";
                    txtExist.Text = "";
                    txtIdBuscar.Text = "";
                    txtImg.Text = "";
                    txtPrecio.Text = "";

                    txtId.Enabled = true;
                    txtDesc.Enabled = true;
                    txtExist.Enabled = true;
                    txtIdBuscar.Enabled = true;
                    txtImg.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtNombre.Enabled = true;
                }
            }
            else
            {   // Funcion Agregar
                if (contElement >= 10)
                {
                    MessageBox.Show("No puede haber mas de 10 productos!");
                }
                else
                {
                    int id = Convert.ToInt32(txtId.Text);
                    string nombre = Convert.ToString(txtNombre.Text);
                    string imagen = Convert.ToString(txtImg.Text);
                    double precio = Convert.ToDouble(txtPrecio.Text);
                    string descripcion = Convert.ToString(txtDesc.Text);
                    int existencias = Convert.ToInt32(txtExist.Text);
                    conexion.insertar(id, nombre, imagen, descripcion, precio, existencias);

                    txtId.Text = "";
                    txtDesc.Text = "";
                    txtNombre.Text = "";
                    txtExist.Text = "";
                    txtIdBuscar.Text = "";
                    txtImg.Text = "";
                    txtPrecio.Text = "";
                }
            }
            refrescar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Productos elemento = null;

            try
            {
                elemento = conexion.buscar(Convert.ToInt32(txtIdBuscar.Text));
                if (busqueda)
                {       // Cancela la operacion, pues la busqueda estaba activa y se volvio a presionar
                    btnBuscar.Text = "Buscar";
                    btnAgregar.Text = "Agregar";
                    busqueda = false;

                    imagen.Image = imageList1.Images[0];
                    imagen.SizeMode = PictureBoxSizeMode.StretchImage;

                    txtId.Text = "";
                    txtDesc.Text = "";
                    txtNombre.Text = "";
                    txtExist.Text = "";
                    txtIdBuscar.Text = "";
                    txtImg.Text = "";
                    txtPrecio.Text = "";

                    txtId.Enabled = true;
                    txtDesc.Enabled = true;
                    txtExist.Enabled = true;
                    txtIdBuscar.Enabled = true;
                    txtImg.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtNombre.Enabled = true;
                }
                else
                {
                    if (elemento != null)
                    {   // Cambia el comportamiento tras la busqueda
                        btnAgregar.Text = "Eliminar";
                        btnBuscar.Text = "Cancelar";
                        busqueda = true;

                        if (Diccionario.ContainsKey(elemento.Imagen)) // Verificar si el nombre existe
                        {
                            int indice = Diccionario[elemento.Imagen]; // Recupera el indice de la imagen 
                            imagen.Image = imageList1.Images[indice];
                            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la imagen con el nombre proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        txtId.Enabled = false;
                        txtNombre.Enabled = false;
                        txtDesc.Enabled = false;
                        txtExist.Enabled = false;
                        txtIdBuscar.Enabled = false;
                        txtImg.Enabled = false;
                        txtPrecio.Enabled = false;

                        txtId.Text = $"{elemento.Id}";
                        txtNombre.Text = $"{elemento.Nombre}";
                        txtDesc.Text = $"{elemento.Descripcion}";
                        txtExist.Text = $"{elemento.Existencias}";
                        txtImg.Text = $"{elemento.Imagen}";
                        txtPrecio.Text = $"{elemento.Precio}";
                    }
                    else
                    {
                        MessageBox.Show("No se encontro producto con dicho ID!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void refrescar() // Usada para refrescar la lista de productos activamente de forma continua
        {
            listProductos.View = View.Details; // Modo tabla
            listProductos.FullRowSelect = true; // Permitir selección completa
            listProductos.Clear();

            listProductos.Columns.Add("Id", 60, HorizontalAlignment.Center);
            listProductos.Columns.Add("Nombre", 290, HorizontalAlignment.Center);
            listProductos.Columns.Add("Existencias", 135, HorizontalAlignment.Center);

            imagen.Image = imageList1.Images[0];
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;

            List<Productos> lista = new List<Productos>();
            lista = conexion.consulta();
            contElement = lista.Count(); // Contador de elementos actualizado

            lista = lista.OrderBy(p => p.Existencias).ToList();
            foreach (var producto in lista)
            {
                ListViewItem elem = new ListViewItem(producto.Id.ToString());
                elem.SubItems.Add(producto.Nombre);
                elem.SubItems.Add(producto.Existencias.ToString());
                listProductos.Items.Add(elem);
            }

            double ventasC = conexion.ventasConsulta();
            ventas.Text = $"${ventasC}";
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form3.logout = true;
            this.Close();
        }

        private void txtImg_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtImg_Leave(object sender, EventArgs e)
        {
            if (Diccionario.ContainsKey(txtImg.Text)) // Verificar si el nombre existe
            {
                int indice = Diccionario[txtImg.Text]; // Recupera el indice de la imagen 
                imagen.Image = imageList1.Images[indice];
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("No se encontró la imagen con el nombre proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
