using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    class CreationListe
    {
        public CreationListe()
        {

        }

        public static List<Adhérents> CreerListe()
        {
            List<Adhérents> creerListe = new List<Adhérents>();
            creerListe.Add(new Adhérents("MARTIN", "Michael",DateTime.Now));
            return creerListe;
        }

        public static List<Club> CreerListeClub()
        {
            List<Club> listeClub = new List<Club>();
            listeClub.Add(new Club("CERCLE D'ESCRIME DE LAXOU",
                "http://www.escrime-laxou.net","6 rue des Affouages",545420,
                "LAXOU", "03.83.98.03.11", "contact@escrime-laxou.net"));
            return listeClub;
        }
    }
}
