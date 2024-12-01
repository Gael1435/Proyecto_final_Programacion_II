using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                conexion = new MySqlConnection(cadenaConexion);//pues conecta la base de datos
                conexion.Open();//abre la conexion con esta
            }
            return conexion;//regresa la conexion
        }
    }
}
