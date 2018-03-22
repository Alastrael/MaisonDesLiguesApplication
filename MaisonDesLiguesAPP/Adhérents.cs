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
        public DateTime DateCreation { get; set; }
             //
        public Adhérents(string nom, string prenom, DateTime date)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateCreation = date;
        }
    }
}
