using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    public class ClubGerer
    {
        private List<Club> listeClub { get; set; }
        public ClubGerer()
        {
            listeClub = CreationListe.CreerListeClub();
        }
        public void ajouterClub(Club club)
        {
            listeClub.Add(club);
        }
    }
}
