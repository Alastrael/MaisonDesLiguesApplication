-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 10 avr. 2018 à 16:15
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_app`
--

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

DROP TABLE IF EXISTS `adherent`;
CREATE TABLE IF NOT EXISTS `adherent` (
  `id_adherent` int(11) NOT NULL AUTO_INCREMENT,
  `numero_licence` varchar(12) DEFAULT NULL,
  `nom_adherent` varchar(25) NOT NULL,
  `prenom_adherent` varchar(25) DEFAULT NULL,
  `datenaissance_adherent` date DEFAULT NULL,
  `adresse_adherent` varchar(50) DEFAULT NULL,
  `codepostal_adherent` varchar(25) DEFAULT NULL,
  `ville_adherent` varchar(50) DEFAULT NULL,
  `cotisation_adherent` int(11) DEFAULT NULL,
  `id_club` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_adherent`),
  UNIQUE KEY `numero_licence` (`numero_licence`),
  KEY `FK_adherent_id_club` (`id_club`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `club`
--

DROP TABLE IF EXISTS `club`;
CREATE TABLE IF NOT EXISTS `club` (
  `id_club` int(11) NOT NULL AUTO_INCREMENT,
  `titre_club` varchar(50) DEFAULT NULL,
  `url_club` varchar(50) DEFAULT NULL,
  `adresse_club` varchar(50) DEFAULT NULL,
  `codepostal_club` varchar(25) DEFAULT NULL,
  `ville_club` varchar(50) DEFAULT NULL,
  `mail_club` varchar(50) DEFAULT NULL,
  `telephone_club` varchar(20) DEFAULT NULL,
  `id_type_club` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_club`),
  UNIQUE KEY `Titre_club` (`titre_club`),
  KEY `FK_club_id_type_club` (`id_type_club`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `club`
--

INSERT INTO `club` (`id_club`, `titre_club`, `url_club`, `adresse_club`, `codepostal_club`, `ville_club`, `mail_club`, `telephone_club`, `id_type_club`) VALUES
(1, 'Club de gym', 'gym.com', '3 rue Camille Pelletan', '92140', 'Moncul', 'gym.moncul@gmail.com', '06 66 66 66 66', 1);

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

DROP TABLE IF EXISTS `evenement`;
CREATE TABLE IF NOT EXISTS `evenement` (
  `id_evenement` int(11) NOT NULL AUTO_INCREMENT,
  `titre_evenement` varchar(50) DEFAULT NULL,
  `debut_evenement` date DEFAULT NULL,
  `fin_evenement` date DEFAULT NULL,
  `id_club` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_evenement`),
  KEY `FK_evenement_id_club` (`id_club`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `type_club`
--

DROP TABLE IF EXISTS `type_club`;
CREATE TABLE IF NOT EXISTS `type_club` (
  `id_type_club` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id_type_club`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `type_club`
--

INSERT INTO `type_club` (`id_type_club`, `libelle`) VALUES
(1, 'Escrime');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `adherent`
--
ALTER TABLE `adherent`
  ADD CONSTRAINT `FK_adherent_id_club` FOREIGN KEY (`id_club`) REFERENCES `club` (`id_club`);

--
-- Contraintes pour la table `club`
--
ALTER TABLE `club`
  ADD CONSTRAINT `FK_club_id_type_club` FOREIGN KEY (`id_type_club`) REFERENCES `type_club` (`id_type_club`);

--
-- Contraintes pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD CONSTRAINT `FK_evenement_id_club` FOREIGN KEY (`id_club`) REFERENCES `club` (`id_club`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
