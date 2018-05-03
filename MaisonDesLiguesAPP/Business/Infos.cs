using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace MaisonDesLiguesAPP.Business
{
    public class Infos
    {
        public Infos()
        {
            //crée l'objet Infos.
        }
        public void adhInfos(Adhérents adh)
        {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            graph.DrawString(adh.Nom+adh.Prenom, font, XBrushes.Black,
                new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            pdf.Save("Infos"+adh.Nom+"-"+adh.Prenom+".pdf");
            Process.Start("Infos" + adh.Nom + "-" + adh.Prenom + ".pdf");
            Console.WriteLine("oui");
        }
    }
}
