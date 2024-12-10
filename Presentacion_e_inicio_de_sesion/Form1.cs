using System.Globalization;

namespace Presentacion_e_inicio_de_sesion
{
    public partial class formPresentacion : Form
    {
        public formPresentacion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); //Inicia el timer cuando el formulario cargue 
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            formLogin Formlogin = new formLogin();

            this.Hide();//esconde primero el formulario
            Formlogin.ShowDialog();  // Muestra el segundo formulario
            this.Close();//cierra este al momento de cerrar el otro

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
