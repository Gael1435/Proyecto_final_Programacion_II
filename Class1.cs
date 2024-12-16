using System;

public class BackgroundImage : IPdfPageEvent
{
    private iTextSharp.text.Image _image;

    public BackgroundImage(iTextSharp.text.Image image)
    {
        _image = image;
    }

    public void OnOpenDocument(PdfWriter writer, Document document) { }
    public void OnStartPage(PdfWriter writer, Document document) { }
    public void OnEndPage(PdfWriter writer, Document document)
    {
        _image.SetAbsolutePosition(0, 0);
        _image.ScaleToFit(document.PageSize.Width, document.PageSize.Height);
        writer.DirectContentUnder.AddImage(_image);
    }
    public void OnCloseDocument(PdfWriter writer, Document document) { }
    public void OnParagraph(PdfWriter writer, Document document, float paragraphPosition) { }
    public void OnParagraphEnd(PdfWriter writer, Document document, float paragraphPosition) { }
    public void OnChapter(PdfWriter writer, Document document, float paragraphPosition, Paragraph title) { }
    public void OnChapterEnd(PdfWriter writer, Document document, float paragraphPosition) { }
    public void OnSection(PdfWriter writer, Document document, float paragraphPosition, int depth, Paragraph title) { }
    public void OnSectionEnd(PdfWriter writer, Document document, float paragraphPosition) { }
    public void OnGenericTag(PdfWriter writer, Document document, Rectangle rect, string text) { }
}
