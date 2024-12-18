﻿using System;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace Presentacion_e_inicio_de_sesion
{
    public partial class Administrador : Form
    {
        int contElement = 0; // Contador de productos
        // Diccionario de indices para las imagenes del pictureBox
        Dictionary<string, int> Diccionario = new Dictionary<string, int>();
        bool busqueda = false; // Auxiliar para cambiar el comportamiento del boton de Agregar a Eliminar
        private Conexion conexion = new Conexion();
        private Chart grafico; // Control Chart para el grafico

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

            // Crea el grafico
            grafico = new Chart()
            {
                Location = new Point(753, 75),
                Size = new Size(417, 188)
            };

            ChartArea area = new ChartArea();
            grafico.ChartAreas.Add(area);

            Series info = new Series
            {
                Name = "Ventas",
                ChartType = SeriesChartType.Pie, // Tipo pastel
                IsValueShownAsLabel = true // Mostrar valores
            };
            grafico.Series.Add(info);

            this.Controls.Add(grafico);

            refrescar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DibujarGraf((string user, double venta)[] datos)
        {
            Series info = grafico.Series["Ventas"];
            info.Points.Clear(); // Limpiar datos anteriores

            foreach (var (categoria, valor) in datos)
            {
                info.Points.AddXY(categoria, valor); // Agregar puntos al gráfico
            }
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
            timer1.Start();
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

            // Actualiza el grafico
            List<double> ventasLista = conexion.ventasInd();
            var info = new[]
            {
                ("Brandon", ventasLista[1]),
                ("Azael", ventasLista[2]),
                ("Bruno", ventasLista[3]),
                ("Invitado", ventasLista[4])
            };

            DibujarGraf(info);
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
            FormPrincipal.logout = true;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void imagen_Click(object sender, EventArgs e)
        {

        }

        private void listProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
