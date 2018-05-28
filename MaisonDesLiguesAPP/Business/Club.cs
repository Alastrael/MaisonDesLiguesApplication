using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    public class Club
    {
        public int id { get; set; }
        public string nom {get; set;}
        public string lien { get; set; }
        public string adresse { get; set; }
        public string codepostal { get; set; }
        public string ville { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public int idClub { get; set; }
        /// <summary>
        /// Le constructeur de la classe Club.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="lien"></param>
        /// <param name="adresse"></param>
        /// <param name="codepostal"></param>
        /// <param name="ville"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <param name="idClub"></param>
        public Club(string nom, string lien, string adresse, string codepostal,
            string ville, string telephone, string email, int idClub)
        {
            this.nom = nom;
            this.lien = lien;
            this.adresse = adresse;
            this.codepostal = codepostal;
            this.ville = ville;
            this.telephone = telephone;
            this.email = email;
            this.idClub = idClub;
        }

    }
}
