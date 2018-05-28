using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    public class Adhérents
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Naissance { get; set; }
        public string Adresse { get; set; }
        public string Codepostal { get; set; }
        public string Ville { get; set; }
        public int cotisation { get; set; }
        public string licence { get; set; }
        public int idClub { get; set; }
        /// <summary>
        /// Le constructeur de la classe Adhérent.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="date"></param>
        /// <param name="adresse"></param>
        /// <param name="codepostal"></param>
        /// <param name="ville"></param>
        public Adhérents(string nom, string prenom, DateTime date, string adresse,
            string codepostal, string ville)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Naissance = date;
            this.Adresse = adresse;
            this.Codepostal = codepostal;
            this.Ville = ville;
        }
    }
}
