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
        private string nombreUsuario = "Nombre no especificado";
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
                    string imagen = Convert.ToString(reader["IMAGEN"]) ?? "";
                    string descripcion = Convert.ToString(reader["DESCRIPCIÓN"]) ?? "";
                    double precio = Convert.ToDouble(reader["PRECIO"]);
                    int existencias = Convert.ToInt32(reader["EXISTENCIAS"]);

                    productos.Add(new Productos(id, imagen, descripcion, precio, existencias)); //añade los productos a la lista
                }
                reader.Close();

                for (int i = 0; i < productos.Count; i++) //cuenta hasta el maximo de productos
                {
                    Productos producto = productos[i];

                    TextBox txtId = new TextBox
                    {
                        Text = producto.Id.ToString(),
                        Location = new Point(156 - 55, 142 + (i * 100)),
                        Multiline = true,
                        Size = new Size(32, 50),
                    };
                    TextBox txtDescripcion = new TextBox
                    {
                        Text = producto.Descripcion,
                        Location = new Point(193 - 55, 142 + (i * 100)),
                        Size = new Size(435, 50),
                        Multiline = true,

                    };
                    TextBox txtPrecio = new TextBox
                    {
                        Text = producto.Precio.ToString(),
                        Location = new Point(634 - 55, 142 + (i * 100)),
                        Multiline = true,
                        Size = new Size(90, 50),
                    };
                    TextBox txtExistencias = new TextBox
                    {
                        Text = producto.Existencias.ToString(),
                        Location = new Point(730 - 55, 142 + (i * 100)),
                        Multiline = true,
                        Size = new Size(90, 50),
                    };
                    CheckBox check = new CheckBox
                    {
                        CheckAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(35, 35),
                        Location = new Point(771, 150 + (i * 100)),

                    };

                    //agregar los textbox al formulario
                    this.Controls.Add(txtId);
                    this.Controls.Add(txtDescripcion);
                    this.Controls.Add(txtPrecio);
                    this.Controls.Add(txtExistencias);
                    this.Controls.Add(check);

                    txtId.BringToFront();
                    txtDescripcion.BringToFront();
                    txtPrecio.BringToFront();
                    txtExistencias.BringToFront();
                    check.BringToFront();
                    check.BackColor = Color.WhiteSmoke;

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
                            Location = new Point(60 - 55, 122 + (i * 100)),
                            Size = new Size(90, 90),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };

                        this.Controls.Add(pictureBox);
                        pictureBox.BringToFront();
                        pictureBox.BackColor = Color.Gainsboro;
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
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
