﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaisonDesLiguesAPP.Business;
using MySql.Data.MySqlClient;

namespace MaisonDesLiguesAPP
{
    public class Connection
    {
        /// <summary>
        /// Paramètres de la connexion.
        /// </summary>
        private string connexionParams;

        /// <summary>
        /// Constructeur de la classe.
        /// </summary>
        public Connection()
        {
            Initialize();
        }
        /// <summary>
        /// Méthode qui initialise la connexion à la base de données.
        /// </summary>
        private void Initialize()
        {
            string server = "localhost";
            string port = "3306";
            string database = "bdd_app";
            string uid = "root";
            string password = "";
            connexionParams = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; persistsecurityinfo=True; SslMode=none;";
        }

        /// <summary>
        /// Méthode qui ajoute un club dans la base de données.
        /// </summary>
        /// <param name="club"></param>
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
                cmd.Parameters.AddWithValue("@codepostal", club.codepostal);
                cmd.Parameters.AddWithValue("@ville", club.ville);
                cmd.Parameters.AddWithValue("@mail", club.email);
                cmd.Parameters.AddWithValue("@telephone", club.telephone);
                cmd.Parameters.AddWithValue("@id_club", club.idClub);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui ajoute un adhérent à la base de données.
        /// </summary>
        /// <param name="adhérents"></param>
        public void ajouterAdherent(Adhérents adhérents)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "INSERT INTO adherent (id_adherent, nom_adherent, " +
                    "prenom_adherent, datenaissance_adherent, adresse_adherent, codepostal_adherent, " +
                    "ville_adherent, cotisation_adherent, id_club, id_evenement) VALUES (NULL, " +
                    "@nom, @prenom, @date, @adresse, @codepostal, @ville, NULL, NULL, NULL);";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@nom", adhérents.Nom);
                cmd.Parameters.AddWithValue("@prenom", adhérents.Prenom);
                cmd.Parameters.AddWithValue("@date", adhérents.Naissance);
                cmd.Parameters.AddWithValue("@adresse", adhérents.Adresse);
                cmd.Parameters.AddWithValue("@codepostal", adhérents.Codepostal);
                cmd.Parameters.AddWithValue("@ville", adhérents.Ville);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui ajoute un évènement à la base de données.
        /// </summary>
        /// <param name="even"></param>
        /// <param name="club"></param>
        public void ajouterEvenement(Evenements even, Club club)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "INSERT INTO evenement (id_evenement, titre_evenement, debut_evenement, " +
                    "fin_evenement, id_club) VALUES (NULL, @titre, @debut, @fin, @id);";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@titre", even.titre);
                cmd.Parameters.AddWithValue("@debut", even.debut);
                cmd.Parameters.AddWithValue("@fin", even.fin);
                cmd.Parameters.AddWithValue("@id", club.id);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Méthode qui supprime un adhérent de la base de données.
        /// </summary>
        /// <param name="adhérents"></param>
        public void supprimerAdherent(Adhérents adhérents)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "DELETE FROM adherent WHERE id_adherent = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", adhérents.Id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui supprime un club de la base de données.
        /// </summary>
        /// <param name="club"></param>
        public void supprimerClub(Club club)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "DELETE FROM club WHERE id_club = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", club.id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui supprime un évènement dans la base de données.
        /// </summary>
        /// <param name="even"></param>
        public void supprimerEvent(Evenements even)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "DELETE FROM evenement WHERE id_evenement = @id";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", even.id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui renvoit une liste des adhérents de la base de données.
        /// </summary>
        /// <returns></returns>
        public List<Adhérents> listeAdherents()
        {
            List<Adhérents> liste = new List<Adhérents>();
            Adhérents adhérents;
            using(MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "SELECT id_adherent, nom_adherent, prenom_adherent, datenaissance_adherent" +
                    ", adresse_adherent, codepostal_adherent, ville_adherent, id_club, cotisation_adherent " +
                    "FROM adherent;";
                MySqlCommand cmd = new MySqlCommand(requete,connexion);
                using(MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        adhérents = new Adhérents((string)datareader["nom_adherent"],
                            (string)datareader["prenom_adherent"],(DateTime)datareader["datenaissance_adherent"],
                            (string)datareader["adresse_adherent"], (string)datareader["codepostal_adherent"],
                            (string)datareader["ville_adherent"]);
                        adhérents.Id = (int)datareader["id_adherent"];
                        if(datareader["id_club"] != DBNull.Value)
                        {
                            adhérents.idClub = (int)datareader["id_club"];
                        }
                        if (datareader["cotisation_adherent"] == DBNull.Value)
                        {
                            adhérents.cotisation = 0;
                        }
                        else adhérents.cotisation = (int)datareader["cotisation_adherent"];
       
                        liste.Add(adhérents);
                    }
                }
            }
            return liste;
        }
        /// <summary>
        /// Méthode qui retourne la liste des clubs de la base de données.
        /// </summary>
        /// <returns></returns>
        public List<Club> listeClubs()
        {
            List<Club> liste = new List<Club>();
            Club club;
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "SELECT id_club, titre_club, url_club, adresse_club" +
                    ", codepostal_club, ville_club, mail_club, telephone_club, id_type_club " +
                    "FROM club;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        club = new Club((string)datareader["titre_club"],
                            (string)datareader["url_club"], (string)datareader["adresse_club"], 
                            (string)datareader["codepostal_club"], (string)datareader["ville_club"],
                            (string)datareader["telephone_club"], (string)datareader["mail_club"],
                            (int)datareader["id_type_club"]);
                        liste.Add(club);
                        club.id = (int)datareader["id_club"];
                    }
                }
            }
            return liste;
        }
        /// <summary>
        /// Méthode qui renvoit une liste des Types de Club de la base de données.
        /// </summary>
        /// <returns></returns>
        public List<TypeClub> listeTypeClub()
        {
            List<TypeClub> liste = new List<TypeClub>();
            TypeClub type;
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "CALL id_type_club_procedure;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        type = new TypeClub((string)datareader["libelle"]);
                        liste.Add(type);
                        type.id_type_club = (int)datareader["id_type_club"];
                    }
                }
            }
            return liste;
        }
        /// <summary>
        /// Méthode qui renvoit la liste des évènement d'un club.
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        public List<Evenements> listeEvents(Club club)
        {
            List<Evenements> liste = new List<Evenements>();
            Evenements evenements;
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "SELECT id_evenement, titre_evenement, debut_evenement," +
                    " fin_evenement FROM evenement WHERE id_club = @idClub";
                                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@idClub", club.id);
                cmd.ExecuteNonQuery();
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        evenements = new Evenements((string)datareader["titre_evenement"],
                            (DateTime)datareader["debut_evenement"], (DateTime)datareader["fin_evenement"]);
                        evenements.id = (int)datareader["id_evenement"];
                        liste.Add(evenements);
                    }
                }
            }
            return liste;
        }
        public List<Adhérents> listeAdherentsInClub(Club club)
        {
            List<Adhérents> liste = new List<Adhérents>();
            Adhérents adh;
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "SELECT id_adherent, nom_adherent, prenom_adherent, datenaissance_adherent" +
                    ", adresse_adherent, codepostal_adherent, ville_adherent " +
                    "FROM adherent WHERE id_club = @idClub;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@idClub", club.id);
                cmd.ExecuteNonQuery();
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        adh = new Adhérents((string)datareader["nom_adherent"],
                            (string)datareader["prenom_adherent"], (DateTime)datareader["datenaissance_adherent"],
                            (string)datareader["adresse_adherent"], (string)datareader["codepostal_adherent"],
                            (string)datareader["ville_adherent"]);
                        adh.Id = (int)datareader["id_adherent"];
                        liste.Add(adh);
                    }
                }
            }
            return liste;
        }
        /// <summary>
        /// Méthode qui renvoit la liste des adhérents qui n'ont pas de clubs.
        /// </summary>
        /// <returns></returns>
        public List<Adhérents> listeAdherentsSansClubs()
        {
            List<Adhérents> liste = new List<Adhérents>();
            Adhérents adhérents;
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "SELECT id_adherent, nom_adherent, prenom_adherent, datenaissance_adherent" +
                    ", adresse_adherent, codepostal_adherent, ville_adherent " +
                    "FROM adherent " +
                    "WHERE id_club IS NULL;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        adhérents = new Adhérents((string)datareader["nom_adherent"],
                            (string)datareader["prenom_adherent"], (DateTime)datareader["datenaissance_adherent"],
                            (string)datareader["adresse_adherent"], (string)datareader["codepostal_adherent"],
                            (string)datareader["ville_adherent"]);
                        adhérents.Id = (int)datareader["id_adherent"];
                        liste.Add(adhérents);
                    }
                }
            }
            return liste;
        }
        /// <summary>
        /// Méthode qui affecte un adhérent dans un club avec une cotisation (qui peut être nulle).
        /// </summary>
        /// <param name="adhérents"></param>
        /// <param name="club"></param>
        /// <param name="cotisation"></param>
        public void affectation(Adhérents adhérents, Club club, int cotisation)
        {
            using(MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "UPDATE adherent " +
                    "SET id_club = @idClub , cotisation_adherent = @cotisation " +
                    "WHERE id_adherent = @idAdherent;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@idClub", club.id);
                cmd.Parameters.AddWithValue("@idAdherent", adhérents.Id);
                cmd.Parameters.AddWithValue("@cotisation", cotisation);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui affecte des adhérents d'un club dans un des évènements de ce dernier.
        /// </summary>
        /// <param name="adh"></param>
        /// <param name="even"></param>
        public void affecterAdhToEvent(Adhérents adh, Evenements even)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "UPDATE adherent " +
                    "SET id_evenement = @idE " +
                    "WHERE id_adherent = @idAdherent;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@idE", even.id);
                cmd.Parameters.AddWithValue("@idAdherent", adh.Id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui permet de modifier un évènement.
        /// </summary>
        /// <param name="even"></param>
        public void modifierEvent(Evenements even)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "UPDATE evenement " +
                    "SET titre_evenement = @titre, " +
                    "debut_evenement = @debut, " +
                    "fin_evenement = @fin " +
                    "WHERE id_evenement = @id;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@titre", even.titre);
                cmd.Parameters.AddWithValue("@debut", even.debut);
                cmd.Parameters.AddWithValue("@fin", even.fin);
                cmd.Parameters.AddWithValue("@id", even.id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui permet de modifier un adhérent.
        /// </summary>
        /// <param name="adh"></param>
        public void modifierAdh(Adhérents adh)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "UPDATE adherent " +
                    "SET nom_adherent = @nom, " +
                    "prenom_adherent = @prenom, " +
                    "datenaissance_adherent = @date, adresse_adherent=@adresse, codepostal_adherent=@cp, " +
                    "ville_adherent=@ville, cotisation_adherent=@cotisation " +
                    "WHERE id_adherent = @id;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@nom", adh.Nom);
                cmd.Parameters.AddWithValue("@cotisation", adh.cotisation);
                cmd.Parameters.AddWithValue("@prenom", adh.Prenom);
                cmd.Parameters.AddWithValue("@date", adh.Naissance);
                cmd.Parameters.AddWithValue("@adresse", adh.Adresse);
                cmd.Parameters.AddWithValue("@cp", adh.Codepostal);
                cmd.Parameters.AddWithValue("@ville", adh.Ville);
                cmd.Parameters.AddWithValue("@id", adh.Id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui permet de modifier un club.
        /// </summary>
        /// <param name="club"></param>
        public void modifierClub(Club club)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "UPDATE club " +
                    "SET titre_club = @titre, " +
                    "url_club = @url, " +
                    "adresse_club = @adresse, codepostal_club=@cp, ville_club=@ville, " +
                    "mail_club=@mail, telephone_club=@tel, id_type_club=@idt " +
                    "WHERE id_club = @id;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@id", club.id);
                cmd.Parameters.AddWithValue("@titre", club.nom);
                cmd.Parameters.AddWithValue("@url", club.lien);
                cmd.Parameters.AddWithValue("@adresse", club.adresse);
                cmd.Parameters.AddWithValue("@cp", club.codepostal);
                cmd.Parameters.AddWithValue("@ville", club.ville);
                cmd.Parameters.AddWithValue("@mail", club.email);
                cmd.Parameters.AddWithValue("@tel", club.telephone);
                cmd.Parameters.AddWithValue("@idt", club.idClub);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Méthode qui désaffecte un adhérent à son club.
        /// </summary>
        /// <param name="adhérents"></param>
        public void desaffectation(Adhérents adhérents)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "UPDATE adherent " +
                    "SET id_club = @idClub, cotisation_adherent = NULL " +
                    "WHERE id_adherent = @idAdherent;";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@idClub", null);
                cmd.Parameters.AddWithValue("@idAdherent", adhérents.Id);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Méthode qui renvoit toutes les cotisations d'un club.
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        public List<int>CotisationsInClub(Club club)
        {
            List<int> liste = new List<int>();
            int cotisation;
            using (MySqlConnection connexion = new MySqlConnection(connexionParams))
            {
                connexion.Open();
                string requete = "SELECT cotisation_adherent " +
                    "FROM adherent";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.ExecuteNonQuery();
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        if (datareader["cotisation_adherent"] == DBNull.Value)
                        {
                            cotisation = 0;
                        }
                        else cotisation = (int)datareader["cotisation_adherent"];
                        liste.Add(cotisation);
                    }
                }
            }
            return liste;
        } 
    }
}
