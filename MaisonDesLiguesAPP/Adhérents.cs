using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    public class Adhérents
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Naissance { get; set; }
        public string Adresse { get; set; }
        public string Codepostal { get; set; }
        public string Ville { get; set; }
        public int Cotisation { get; set; }
        public int idClub { get; set; }
        public Adhérents(string nom, string prenom, DateTime date, string adresse,
            string codepostal, string ville, int cotisation, int idClub)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Naissance = date;
            this.Adresse = adresse;
            this.Codepostal = codepostal;
            this.Ville = ville;
            this.Cotisation = cotisation;
            this.idClub = idClub;
        }
    }
}
