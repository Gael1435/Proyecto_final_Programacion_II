using MySql.Data.MySqlClient;

namespace proyecto_final
{
    public partial class Form1 : Form
    {
        private Conexion mConexion;
        public Form1()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            string result = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "select * from tabla_usuarios";//agarro la tabla de usuarios
            if (mConexion.getConexion != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = mConexion.getConexion();
                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader.GetString("Tipo");
                }
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }

        }
    }
}
