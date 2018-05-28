using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using PdfSharp.Drawing.Layout;

namespace MaisonDesLiguesAPP.Business
{
    public class Infos
    {
        /// <summary>
        /// Le but de cette classe est de retourner un fichier pdf avec les informations d'un adhérent.
        /// </summary>
        public Infos()
        {
            //crée l'objet Infos.
        }
        /// <summary>
        /// Cette méthode sert à créer le fichier pdf d'un adhérent.
        /// </summary>
        /// <param name="adh"></param>
        public void adhInfos(Adhérents adh)
        {
            Connection connexion = new Connection();
            List<Club> liste = connexion.listeClubs();
            string nom = "Pas de club";
            foreach (var item in liste)
            {
                if (adh.idClub == item.id) nom = item.nom;
            }
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Tahoma", 14, XFontStyle.Regular);
            graph.DrawString(adh.Nom + " " + adh.Prenom, font, XBrushes.Black,
                new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            graph.DrawString("Adresse : " + adh.Adresse
                + ", " + adh.Codepostal + ", " + adh.Ville, font, XBrushes.Black,
                new XRect(0, 15, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            graph.DrawString("Date de naissance : " + adh.Naissance, font, XBrushes.Black,
                new XRect(0, 30, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            graph.DrawString("Club : " + nom +"; Cotisation : " + adh.cotisation, font, XBrushes.Black,
                new XRect(0, 45, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            pdf.Save("Infos"+adh.Nom+"-"+adh.Prenom+".pdf");
            Process.Start("Infos" + adh.Nom + "-" + adh.Prenom + ".pdf");
            Console.WriteLine("oui");
        }
    }
}
