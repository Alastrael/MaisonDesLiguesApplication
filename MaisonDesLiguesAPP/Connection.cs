using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MaisonDesLiguesAPP
{
    public class Connection
    {
        private string connexionParams;

        public Connection()
        {
            Initialize();
        }

        private void Initialize()
        {
            string server = "localhost";
            string port = "3306";
            string database = "bdd_app";
            string uid = "root";
            string password = "";
            connexionParams = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }

        public void ajouterClub(Club club)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "INSERT INTO club (id_club, titre_club, url_club, " +
                    "adresse_club, codepostal_club, ville_club, mail_club, telephone_club, " +
                    "id_type_club) VALUES (NULL, @titre, @url, @adresse, @codepostal, " +
                    "@ville, @mail, @telephone, @id_club);";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@titre", club.nom);
                cmd.Parameters.AddWithValue("@url", club.lien);
                cmd.Parameters.AddWithValue("@adresse", club.adresse);
                cmd.Parameters.AddWithValue("@codepostal", club.nbrDepartement);
                cmd.Parameters.AddWithValue("@ville", club.ville);
                cmd.Parameters.AddWithValue("@mail", club.email);
                cmd.Parameters.AddWithValue("@telephone", club.telephone);
                cmd.Parameters.AddWithValue("@id_club", club.idClub);
                cmd.ExecuteNonQuery();
            }
        }
        public void ajouterAdherent(Adhérents adhérents)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "INSERT INTO adherent (id_adherent, numero_licence, nom_adherent, " +
                    "prenom_adherent, datenaissance_adherent, adresse_adherent, codepostal_adherent, " +
                    "ville_adherent, cotisation_adherent, id_club) VALUES (NULL, @licence, " +
                    "@nom, @prenom, @date, @adresse, @codepostal, @ville, @cotisation, @idClub);";
            }
        }

    }
}
