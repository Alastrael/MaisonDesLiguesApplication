using MaisonDesLiguesAPP;
using MaisonDesLiguesAPP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProjetM2L
{
    public class TestUnit
    {
        [Fact]
        public void TestCotisations()
        {
            Connection connexion = new Connection();
            Club club = new Club("Test", "Test.com", "20 rue des Tests", "92140", "Test", "06 66 66 66 66", "test@gmail.com", 1);
            club.id = 15;
            Adhérents adhérents = new Adhérents("Test", "Test", new DateTime(1998, 8, 8), "Test", "92140", "Test");
            adhérents.idClub = club.id;
            adhérents.cotisation = 250;
            Statistiques stats = new Statistiques();
            List<int> liste = new List<int>();
            List<Adhérents> listeA = new List<Adhérents>();
            liste.Add(adhérents.cotisation);
            listeA.Add(adhérents);
            int[] tab = stats.CotisationElevee(club, liste);
            Assert.False(tab[0] != 250, "Le test de la plus haute cotisation a échoué.");
            Assert.False(listeA[tab[1]] != adhérents, "Le test sur le compteur a échoué.");
        }
    }
}
