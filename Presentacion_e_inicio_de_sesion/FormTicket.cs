using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

using static Presentacion_e_inicio_de_sesion.FormPrincipal;
using System.Drawing.Imaging;
using Presentacion_e_inicio_de_sesion.Elementos;
using iTextSharp.text.pdf.qrcode;
using System.Net.NetworkInformation;
using ZXing;
using System.Drawing;
using ZXing.QrCode;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Presentacion_e_inicio_de_sesion
{
    public partial class FormTicket : Form
    {
        private Label lblTotalFinal;

        private System.Drawing.Image imageWithOpacity;

        ///****
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /// Codigo para arrastrar la ventana ***IGNORAR

        private void panelItems_Paint(object sender, PaintEventArgs e)
        {
            if (imageWithOpacity != null)
            {
                // Dibujar la imagen en la ubicación específica (34, 128) con las dimensiones 275x241
                e.Graphics.DrawImage(imageWithOpacity, new System.Drawing.Rectangle(34, 128, 275, 241));
            }
        }
        public FormTicket(string nombreUsuario, DateTime fechaHora, double totalCompra, List<DetalleCompra> detallesCompra)
        {
            InitializeComponent();
            ConfigurarImagenDeFondo();


            // Mostrar la información general del ticket
            lblNombreUsuario.Text = nombreUsuario;
            lblFechaHora.Text = fechaHora.ToString("dd/MM/yyyy HH:mm");
            double totalConImpuesto = totalCompra * 1.06; // Aumentar el total en un 6%

            // Ajustar el panel para los ítems
            panelItems.AutoScroll = true; // Permitir desplazamiento si los items exceden el tamaño del panel
            panelItems.Controls.Clear(); // Limpiar cualquier control anterior

            int yPosition = 10; // Posición inicial de los labels

            foreach (var detalle in detallesCompra)
            {
                // Calcular el total del producto (Cantidad * Precio Unitario)
                double totalProducto = detalle.Cantidad * detalle.PrecioUnitario;

                // Crear el label para cada producto
                Label lblItem = new Label
                {
                    Text = $"{detalle.Cantidad} x {detalle.NombreProducto} - ${totalProducto:F2}",
                    Location = new Point(10, yPosition),
                    AutoSize = true,
                    BackColor = Color.Transparent, // Establecer fondo transparente
                    Font = new System.Drawing.Font("Times New Roman", 14, FontStyle.Bold) // Establecer la fuente a Times New Roman, tamaño 10
                };

                // Agregar el label al panel
                panelItems.Controls.Add(lblItem);

                // Incrementar la posición para el siguiente ítem
                yPosition += lblItem.Height + 5; // 5 es el espaciado entre cada ítem
            }

            lblTotalFinal = new Label // Inicializar lblTotalFinal
            {
                Text = $"Total a Pagar (con 6% impuesto): ${totalConImpuesto:F2}",
                Location = new Point(10, yPosition), // Ubicado a la izquierda (10px de margen)
                AutoSize = true,
                BackColor = Color.Transparent, // Establecer fondo transparente
                Font = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Underline) // Establecer la fuente a Times New Roman, tamaño 10, negritas y subrayado
            };
            panelItems.Controls.Add(lblTotalFinal);
        }

        private void ConfigurarImagenDeFondo()
        {
            // Cargar la imagen desde los recursos del proyecto
            System.Drawing.Image originalImage = Properties.Resources.Logo;
            if (originalImage == null)
            {
                MessageBox.Show("Error: La imagen no se pudo cargar desde los recursos.");
                return;
            }

            // Ajustar la opacidad de la imagen
            System.Drawing.Image imageWithOpacity = AdjustImageOpacity(originalImage, 0.5f);

            // Guardar la imagen ajustada en una variable de clase
            this.imageWithOpacity = imageWithOpacity;

            // Suscribir el evento Paint del panel
            panelItems.Paint += new PaintEventHandler(panelItems_Paint);
        }

        private System.Drawing.Image AdjustImageOpacity(System.Drawing.Image image, float opacity)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "La imagen no puede ser null.");
            }

            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                gfx.DrawImage(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Desea guardar el ticket en PDF?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Obtener la ruta de la carpeta de descargas
                string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string filePath = Path.Combine(downloadsFolder, "Ticket.pdf");

                GenerarPDF(filePath);
                MessageBox.Show("El ticket se ha guardado en la carpeta de descargas.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }





        private void GenerarPDF(string filePath)
        {
            Document document = new Document(PageSize.A7); // Tamaño aproximado de un recibo
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Configuración de la fuente
            iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
            iTextSharp.text.Font fontContenido = FontFactory.GetFont(FontFactory.HELVETICA, 8);

            // Añadir el logo como fondo
            try
            {
                System.Drawing.Image logo = Properties.Resources.Logo;
                if (logo != null)
                {
                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(logo, System.Drawing.Imaging.ImageFormat.Png);
                    writer.PageEvent = new BackgroundImage(pdfImage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el logo: " + ex.Message);
            }

            // Título del documento
            Paragraph titulo = new Paragraph("Ticket de Compra", fontTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);

            // Información del usuario y fecha
            Paragraph info = new Paragraph($"Usuario: {lblNombreUsuario.Text}\nFecha y Hora: {lblFechaHora.Text}\n\n", fontContenido);
            document.Add(info);

            // Información de los productos
            foreach (Control control in panelItems.Controls)
            {
                if (control is Label label && !label.Text.StartsWith("Total a Pagar"))
                {
                    Paragraph item = new Paragraph(label.Text, fontContenido);
                    document.Add(item);
                }
            }

            // Total a pagar
            Paragraph total = new Paragraph($"\n{lblTotalFinal.Text}", fontContenido);
            total.Alignment = Element.ALIGN_RIGHT;
            document.Add(total);

            document.Close();
            writer.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelItems_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}