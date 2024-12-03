using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

///
/// PANTALLA DE COMPRAS
///

namespace Presentacion_e_inicio_de_sesion
{
    public partial class Form3 : Form
    {
        static public bool logout = false; // Para cerrar desde otros form
        private string nombreUsuario = "Invitado";
        bool admin = false;
        private Conexion mConexion;
        public Form3()
        {
            InitializeComponent();
            mConexion = new Conexion();
            this.Load += new EventHandler(Form3_Load);
        }
        public Form3(string nombreUsuario)
        {
            InitializeComponent();
            mConexion = new Conexion();
            this.nombreUsuario = nombreUsuario;
            this.Load += new EventHandler(Form3_Load);
        }
        public Form3(string nombreUsuario, bool admin)
        {
            InitializeComponent();
            mConexion = new Conexion();
            this.nombreUsuario = nombreUsuario;
            this.Load += new EventHandler(Form3_Load);
            this.admin = admin;
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

                List<Productos> productos = new List<Productos>(); //genera la lista vacia de productos
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string nombre = Convert.ToString(reader["NOMBRE"]) ?? "";
                    string imagen = Convert.ToString(reader["IMAGEN"]) ?? "";
                    string descripcion = Convert.ToString(reader["DESCRIPCIÓN"]) ?? "";
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
                        Size = new Size(60, 50)
                    };

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

                    try
                    {
                        string imagenSinExtension = Path.GetFileNameWithoutExtension(imagenNombre);
                        Image img = (Image)Properties.Resources.ResourceManager.GetObject(imagenSinExtension);
                        if (img == null)
                        {
                            img = Properties.Resources.defaultImage; // Imagen por defecto si no se encuentra
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
            this.Show();
        }


        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
