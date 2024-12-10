using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentacion_e_inicio_de_sesion
{
    internal class Conexion
    {
        //estos son los valores de tu BD, root es un usuario por default, contraseña no le puse.
        private MySqlConnection conexion; //variable de mysql
        private string server = "localhost";//localhost como no estoy trabajando con un servidor activo se pone
        private string database = "pasteleria";//nombre de la base de datos
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database + "; DataSource=" + server + "; User Id=" + user + "; Password=" + password;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);// Conecta la base de datos
                conexion.Open();// Abre la conexion con esta
            }
            return conexion;//regresa la conexion
        }

        public void desconectar()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public List<Productos> consulta()
        {
            List<Productos> productos = new List<Productos>();
            Productos elemento;

            int id;
            string nombre;
            string imagen;
            string descripcion;
            double precio;
            int existencias;

            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.conexion);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    nombre = imagen = Convert.ToString(reader["NOMBRE"]) ?? "";
                    imagen = Convert.ToString(reader["IMAGEN"]) ?? "";
                    precio = Convert.ToDouble(reader["PRECIO"]);
                    descripcion = Convert.ToString(reader["DESCRIPCION"]) ?? "";
                    existencias = Convert.ToInt32(reader["EXISTENCIAS"]);

                    elemento = new Productos(id, nombre, imagen, descripcion, precio, existencias);
                    productos.Add(elemento);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
            }
            return productos;
        }

        public void insertar(int id, string nombre, string imagen, string descripcion, double precio, int exist)
        {
            string consulta = "";
            try
            {
                consulta = "INSERT INTO productos (ID, NOMBRE, IMAGEN, DESCRIPCION, PRECIO, EXISTENCIAS) VALUES ("
               + "'" + id + "',"
               + "'" + nombre + "',"
               + "'" + imagen + "', "
               + "'" + descripcion + "',"
               + "'" + precio + "',"
               + "'" + exist + "')";

                MySqlCommand realizaConsulta = new MySqlCommand(consulta, conexion);
                realizaConsulta.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nClave duplicada" + ex.Message);
            }

        }

        public Productos buscar(int idBuscar)
        {
            Productos elemento = null;

            int id;
            string nombre;
            string imagen;
            string descripcion;
            double precio;
            int existencias;


            try
            {
                string query = "SELECT * FROM productos where ID=" + idBuscar + ";";
                MySqlCommand RealizarConsulta = new MySqlCommand(query, conexion);

                MySqlDataReader reader = RealizarConsulta.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    nombre = imagen = Convert.ToString(reader["NOMBRE"]) ?? "";
                    imagen = Convert.ToString(reader["IMAGEN"]) ?? "";
                    precio = Convert.ToDouble(reader["PRECIO"]);
                    descripcion = Convert.ToString(reader["DESCRIPCION"]) ?? "";
                    existencias = Convert.ToInt32(reader["EXISTENCIAS"]);

                    elemento = new Productos(id, nombre, imagen, descripcion, precio, existencias);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
            }
            return elemento;
        }

        public void eliminar(int idBuscar)
        {
            string query = "";
            try
            {
                query = "DELETE FROM productos WHERE ID=" + idBuscar + ";";

                MySqlCommand eliminarRegistro = new MySqlCommand(query, conexion);
                eliminarRegistro.ExecuteNonQuery();
                MessageBox.Show("\nProducto Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
            }
        }

        public void actualizarTotalCompras(string nombreUsuario, double totalCompra)
        {
            try
            {
                // Consulta para actualizar el total de compras del usuario
                string consulta = "UPDATE tabla_usuarios SET `Monto` = Monto + @TotalCompra WHERE `Nombre Completo` = @NombreUsuario;";

                // Preparar el comando para ejecutar la consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Asignar los parámetros de la consulta
                comando.Parameters.AddWithValue("@TotalCompra", totalCompra);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                // Ejecutar la consulta
                comando.ExecuteNonQuery();

                MessageBox.Show("Total de compras actualizado correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre un problema
                MessageBox.Show("Error al actualizar el total de compras: " + ex.Message);
            }
        }

        public double ventasConsulta()
        {
            double total = 0;
            try
            {
                string query = "SELECT * FROM tabla_usuarios";
                MySqlCommand command = new MySqlCommand(query, this.conexion);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    double ventaInd = Convert.ToDouble(reader["Monto"]);

                    total += ventaInd;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
            }
            return total;
        }
        public List<double> ventasInd()
        {
            List <double> ventas = new List<double>();
            try
            {
                string query = "SELECT * FROM tabla_usuarios";
                MySqlCommand command = new MySqlCommand(query, this.conexion);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ventas.Add(Convert.ToDouble(reader["Monto"]));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
            }
            return ventas;
        }
    }
}