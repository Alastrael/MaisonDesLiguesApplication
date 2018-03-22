using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    public class Club
    {
        private string nom {get; set;}
        private string lien { get; set; }
        private string adresse { get; set; }
        private int nbrDepartement { get; set; }
        private string ville { get; set; }
        private string telephone { get; set; }
        private string email { get; set; }

        public Club(string nom, string lien, string adresse, int nbrDepartement,
            string ville, string telephone, string email)
        {
            this.nom = nom;
            this.lien = lien;
            this.adresse = adresse;
            this.nbrDepartement = nbrDepartement;
            this.ville = ville;
            this.telephone = telephone;
            this.email = email;
        }

    }
}
