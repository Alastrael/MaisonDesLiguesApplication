using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    public class Club
    {
        public string nom {get; set;}
        public string lien { get; set; }
        public string adresse { get; set; }
        public int nbrDepartement { get; set; }
        public string ville { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public int idClub { get; set; }

        public Club(string nom, string lien, string adresse, int nbrDepartement,
            string ville, string telephone, string email, int idClub)
        {
            this.nom = nom;
            this.lien = lien;
            this.adresse = adresse;
            this.nbrDepartement = nbrDepartement;
            this.ville = ville;
            this.telephone = telephone;
            this.email = email;
            this.idClub = idClub;
        }

    }
}
