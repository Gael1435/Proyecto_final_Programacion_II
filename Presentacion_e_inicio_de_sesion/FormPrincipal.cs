using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

///
/// PANTALLA DE COMPRAS
///

namespace Presentacion_e_inicio_de_sesion
{
    public partial class FormPrincipal : Form
    {
        Dictionary<string, int> Diccionario = new Dictionary<string, int>(); // Para usar un diccionario en imagenes
        List<Productos> productos = new List<Productos>(); //genera la lista vacia de productos
        private List<NumericUpDown> listaNumeros = new List<NumericUpDown>(); //para guardar los datos de los NumericUpDown
        private double totalCompra = 0.00;
        static public bool logout = false; // Para cerrar desde otros form
        private string nombreUsuario;
        bool admin = false;
        bool bandera = false; //confirma si se realizo la compra
        private Conexion mConexion;
        private List<DetalleCompra> detallesCompra = new List<DetalleCompra>();

        private bool esInvitado;

        public FormPrincipal()
        {
            InitializeComponent();
         
            mConexion = new Conexion();
            this.Load += new EventHandler(Form3_Load);
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                // Genera el diccionario en base a los nombres de las imagenes
                string key = imageList1.Images.Keys[i];
                Diccionario[key] = i;

            }
        }

        public FormPrincipal(string nombreUsuario)
        {
            InitializeComponent();
      
            this.nombreUsuario = nombreUsuario;
            this.esInvitado = nombreUsuario == "Invitado";
            mConexion = new Conexion();
            this.Load += new EventHandler(Form3_Load);
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                // Genera el diccionario en base a los nombres de las imagenes
                string key = imageList1.Images.Keys[i];
                Diccionario[key] = i;
            }
        }

        public FormPrincipal(string nombreUsuario, bool admin)
        {
            InitializeComponent();
          
            mConexion = new Conexion();
            this.nombreUsuario = nombreUsuario;
            this.admin = admin;
            this.Load += new EventHandler(Form3_Load);
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                // Genera el diccionario en base a los nombres de las imagenes
                string key = imageList1.Images.Keys[i];
                Diccionario[key] = i;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            generarlLista();
        }

        private void generarlLista()
        {
            MySqlDataReader reader = null;
            string query = "select * from productos";


            if (mConexion.getConexion != null)
            {
                MySqlCommand command = new MySqlCommand(query);
                command.Connection = mConexion.getConexion();


                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string nombre = Convert.ToString(reader["NOMBRE"]) ?? "";
                    string imagen = Convert.ToString(reader["IMAGEN"]) ?? "";
                    string descripcion = Convert.ToString(reader["DESCRIPCION"]) ?? "";
                    double precio = Convert.ToDouble(reader["PRECIO"]);
                    int existencias = Convert.ToInt32(reader["EXISTENCIAS"]);

                    productos.Add(new Productos(id, nombre, imagen, descripcion, precio, existencias)); //añade los productos a la lista
                }
                reader.Close();

                //logica para acomodar los objetos
                int maxPorFila = 5;
                int espHor = 230;
                int espVer = 380;
                int inicioX = 40;
                int inicioY = 150;

                //aqui es en donde tiene que entrar a juego un valor sacado desde la pestaña de admin para saber que productos aparecen
                for (int i = 0; i < productos.Count; i++) //cuenta hasta el maximo de productos 
                {
                    int fila = i / maxPorFila;
                    int columna = i % maxPorFila;

                    Productos producto = productos[i];

                    Label txtPrecio = new Label
                    {
                        Text = "$" + producto.Precio.ToString(),
                        Size = new Size(90, 30),
                    };
                    Label txtExistencias = new Label
                    {
                        Text = producto.Existencias.ToString(),
                        Size = new Size(40, 30),
                    };
                    Button btn = new Button //boton de descripcion
                    {
                        Size = new Size(50, 50)
                    };
                    Label nomPostre = new Label
                    {
                        Text = producto.Nombre,
                        Size = new Size(150, 50)
                    };
                    NumericUpDown numCantidad = new NumericUpDown
                    {
                        Size = new Size(60, 50),
                        Value = 0,
                        Minimum = 0,
                        Maximum = producto.Existencias
                    };

                    // Registrar el evento ValueChanged para que se dispare cuando el usuario cambie la cantidad
                    numCantidad.ValueChanged += (sender, e) => ActualizarCarrito(producto, numCantidad);

                    btn.Click += (sender, e) => MostrarDescripcion(producto.Descripcion);
                    btn.Location = new Point(
                        inicioX + (columna * espHor) + 150,
                        inicioY + (fila * espVer) - 60
                    );

                    nomPostre.Location = new Point(
                        inicioX + (columna * espHor),
                        inicioY + (fila * espVer) - 58
                    );

                    txtPrecio.Location = new Point(
                        inicioX + (columna * espHor),
                        inicioY + (fila * espVer) + -30
                    );

                    txtExistencias.Location = new Point(
                        inicioX + (columna * espHor) + 155,
                        inicioY + (fila * espVer) + 165
                    );

                    numCantidad.Location = new Point(
                        inicioX + (columna * espHor) + 75,
                        inicioY + (fila * espVer) + 210
                    );


                    //agregar los controles al formulario
                    this.Controls.Add(txtPrecio);
                    this.Controls.Add(txtExistencias);
                    this.Controls.Add(btn);
                    this.Controls.Add(nomPostre);
                    if (!admin)
                    {
                        this.Controls.Add(numCantidad);
                        listaNumeros.Add(numCantidad);
                    }

                    btn.BringToFront();
                    btn.Image = Properties.Resources.ImgDesc_2;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;

                    nomPostre.TextAlign = ContentAlignment.TopLeft;
                    nomPostre.Font = new Font("Yu Gothic Medium", 9, FontStyle.Bold);

                    txtPrecio.Font = new Font("Yu Gothic Medium", 12, FontStyle.Bold);
                    txtPrecio.ForeColor = Color.Green;

                    txtExistencias.TextAlign = ContentAlignment.MiddleCenter;
                    txtExistencias.Font = new Font("Yu Gothic Medium", 9, FontStyle.Bold);
                    txtExistencias.BorderStyle = BorderStyle.Fixed3D;

                    numCantidad.TextAlign = HorizontalAlignment.Center;

                    string imagenNombre = producto.Imagen;
                    var img = imageList1.Images[0];

                    try
                    {
                        if (Diccionario.ContainsKey(imagenNombre)) // Verificar si el nombre existe
                        {
                            int indice = Diccionario[imagenNombre]; // Recupera el indice de la imagen 
                            img = imageList1.Images[indice];
                        }

                        PictureBox pictureBox = new PictureBox
                        {
                            Image = img,
                            //Location = new Point(60 - 55, 122 + (i * 85)),
                            Size = new Size(200, 200),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };

                        pictureBox.Location = new Point(
                            inicioX + (columna * espHor),
                            inicioY + (fila * espVer)
                        );

                        this.Controls.Add(pictureBox);
                        //pictureBox.BringToFront();
                        pictureBox.BackColor = Color.Gainsboro;
                        pictureBox.BorderStyle = BorderStyle.Fixed3D;

                        txtExistencias.BringToFront(); //mover el numero de existencias frente a la imagen
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
            label6.Text = "Nombre:  " + nombreUsuario.ToString();

            if (admin)
            {
                Button panel = new Button
                {
                    AutoSize = true,
                    Text = "Panel de administracion",
                    Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold)
                };

                panel.Click += (sender, e) => PanelAdmin();
                panel.Location = new Point(10, 10);
                this.Controls.Add(panel);
                panel.BringToFront();

                PictureBox pictureBoxLogo = new PictureBox
                {
                    Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("Logo"),
                    Size = new Size(557, 487),
                    SizeMode = PictureBoxSizeMode.StretchImage,

                };

                pictureBoxLogo.Location = new Point(1191, 184);

                this.Controls.Add(pictureBoxLogo);
                pictureBoxLogo.BringToFront();

                lbl_total.Text = "Tartana";
                btnComprar.Enabled = false;
                btnComprar.Text = "Bloqueado";
            }

        }

        private void MostrarDescripcion(string descripcion)
        {
            MessageBox.Show(descripcion, "Descripción del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PanelAdmin()
        {
            Administrador f4 = new Administrador();
            this.Hide();
            f4.ShowDialog();
            if (logout)
                this.Close();
            else
            {
                this.Show();
                ActualizarYRecargarLista();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //este hace que el producto se actualize en la bd

        private void ActualizarCarrito(Productos producto, NumericUpDown numCantidad)
        {
            decimal cantidad = numCantidad.Value;
            decimal precioProducto = (decimal)producto.Precio;
            decimal total = cantidad * precioProducto;
            DetalleCompra detalle = new DetalleCompra(producto.Nombre, (int)cantidad, (double)precioProducto, (double)total);

            if (cantidad > 0)
            {
                // Buscar si ya existe el producto en los detalles de compra
                var detalleExistente = detallesCompra.FirstOrDefault(d => d.NombreProducto == producto.Nombre);
                if (detalleExistente == null)
                {
                    // Si no existe, agregar el detalle a la lista
                    detallesCompra.Add(detalle);
                }
                else
                {
                    // Si el producto ya está en los detalles de compra, actualizar la cantidad y el total
                    detalleExistente.Cantidad = (int)cantidad;
                    detalleExistente.Total = (double)total;
                }
            }
            else
            {
                // Si la cantidad es cero, eliminar el detalle de la lista
                detallesCompra.RemoveAll(d => d.NombreProducto == producto.Nombre);
            }

            // Actualizar el ListView
            ListViewItem itemExistente = null;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == producto.Nombre)
                {
                    itemExistente = item;
                    break;
                }
            }

            if (itemExistente == null && cantidad > 0)
            {
                ListViewItem compras = new ListViewItem(producto.Nombre);
                compras.SubItems.Add(cantidad.ToString());
                compras.SubItems.Add("$" + precioProducto.ToString("F2"));
                compras.SubItems.Add("$" + total.ToString("F2"));
                listView1.Items.Add(compras);
            }
            else if (cantidad > 0)
            {
                itemExistente.SubItems[1].Text = cantidad.ToString();
                itemExistente.SubItems[3].Text = "$" + total.ToString("F2");
            }
            else
            {
                if (itemExistente != null)
                {
                    listView1.Items.Remove(itemExistente);
                }
            }

            // Actualizar el total global
            totalCompra = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                totalCompra += Convert.ToDouble(item.SubItems[3].Text.Substring(1)); // Quitar el símbolo "$" y sumar
            }
            lbl_total.Text = "Total: $" + totalCompra.ToString("F2");
        }
        private void ActualizarYRecargarLista()
        {
            // Limpiar la lista actual
            productos.Clear();

            // Volver a cargar los productos desde la base de datos
            generarlLista();

        }

        public FormPrincipal(bool confirmado)
        {
            InitializeComponent();

            if (confirmado)
            {
                MessageBox.Show("La compra se ha realizado correctamente.");
                bandera = true;
            }
        }

        private void ActualizarDatos()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                string nombreProducto = item.SubItems[0].Text;
                decimal cantidad = Convert.ToDecimal(item.SubItems[1].Text);
                Productos producto = productos.FirstOrDefault(p => p.Nombre == nombreProducto);

                if (producto != null)
                {
                    int actualizacion = producto.Existencias - (int)cantidad;

                    string actualizar = "UPDATE productos SET EXISTENCIAS = @Existencias WHERE NOMBRE = @NombreProducto";
                    MySqlCommand command = new MySqlCommand(actualizar, mConexion.getConexion());
                    command.Parameters.AddWithValue("@Existencias", actualizacion);
                    command.Parameters.AddWithValue("@NombreProducto", nombreProducto);

                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        producto.Existencias = actualizacion;
                    }
                }
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormPago f5 = new FormPago(nombreUsuario, detallesCompra);
            this.Hide();
            f5.ShowDialog();
            this.Show();

            ActualizarDatos();
            ActualizarYRecargarLista();

            foreach (NumericUpDown numCantidad in listaNumeros)
            {
                numCantidad.Minimum = 0; // Asegúrate de que el mínimo sea 0 o el valor que necesites
                numCantidad.Maximum = 100; // Establece un máximo adecuado según tus necesidades
                numCantidad.Value = 0; // Asigna un valor dentro del rango permitido
            }

            totalCompra = 0;
            lbl_total.Text = "Total: $0.00";
            detallesCompra.Clear();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown numCantidad in listaNumeros)
            {
                numCantidad.Value = 0;
            }

            //listView1.Clear();//limpiar el listView

            totalCompra = 0;//compra igual a cero
            lbl_total.Text = "Total 0.00";
        }


        public class DetalleCompra
        {
            public string NombreProducto { get; set; }
            public int Cantidad { get; set; }
            public double PrecioUnitario { get; set; }
            public double Total { get; set; }

            public DetalleCompra(string nombreProducto, int cantidad, double precioUnitario, double total)
            {
                NombreProducto = nombreProducto;
                Cantidad = cantidad;
                PrecioUnitario = precioUnitario;
                Total = total;
            }
        }



        ///****
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        /// Codigo para arrastrar la ventana ***IGNORAR

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
