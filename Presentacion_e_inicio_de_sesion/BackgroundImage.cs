using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Presentacion_e_inicio_de_sesion.Elementos
{
    public class BackgroundImage : PdfPageEventHelper
    {
        private iTextSharp.text.Image _image;


        public BackgroundImage(iTextSharp.text.Image image)
        {
            _image = image;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            // Escalar la imagen para que sea más grande
            float scale = 0.75f; // Ajustar el valor según sea necesario
            _image.ScaleToFit(document.PageSize.Width * scale, document.PageSize.Height * scale);

            // Calcular la posición centrada
            float xPosition = (document.PageSize.Width - _image.ScaledWidth) / 2;
            float yPosition = (document.PageSize.Height - _image.ScaledHeight) / 2;

            // Ajustar la opacidad de la imagen
            PdfGState gState = new PdfGState();
            gState.FillOpacity = 0.2f; // Ajustar la opacidad (0.1f para muy transparente)

            // Establecer la posición de la imagen
            _image.SetAbsolutePosition(xPosition, yPosition);

            // Agregar la imagen al contenido subyacente con la opacidad ajustada
            PdfContentByte under = writer.DirectContentUnder;
            under.SaveState();
            under.SetGState(gState);
            under.AddImage(_image);
            under.RestoreState();
        }
        public void OnOpenDocument(PdfWriter writer, Document document) { }
        public void OnStartPage(PdfWriter writer, Document document) { }
       
        public void OnCloseDocument(PdfWriter writer, Document document) { }
        public void OnParagraph(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnParagraphEnd(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnChapter(PdfWriter writer, Document document, float paragraphPosition, Paragraph title) { }
        public void OnChapterEnd(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnSection(PdfWriter writer, Document document, float paragraphPosition, int depth, Paragraph title) { }
        public void OnSectionEnd(PdfWriter writer, Document document, float paragraphPosition) { }
        public void OnGenericTag(PdfWriter writer, Document document, System.Drawing.Rectangle rect, string text) { }
    }
}
