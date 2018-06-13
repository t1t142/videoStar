-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 13 juin 2018 à 21:55
-- Version du serveur :  5.7.21
-- Version de PHP :  5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `videostar`
--

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

DROP TABLE IF EXISTS `adherent`;
CREATE TABLE IF NOT EXISTS `adherent` (
  `code` varchar(4) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `adresse1` varchar(50) NOT NULL,
  `adresse2` varchar(50) NOT NULL,
  `refmoral` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `telephone` varchar(10) NOT NULL,
  `idville` int(11) NOT NULL,
  `idcivil` int(11) NOT NULL,
  PRIMARY KEY (`code`),
  KEY `idville` (`idville`),
  KEY `idcivil` (`idcivil`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `civilite`
--

DROP TABLE IF EXISTS `civilite`;
CREATE TABLE IF NOT EXISTS `civilite` (
  `idcivil` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(20) NOT NULL,
  PRIMARY KEY (`idcivil`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `civilite`
--

INSERT INTO `civilite` (`idcivil`, `libelle`) VALUES
(1, 'Monsieur'),
(2, 'Madame'),
(3, 'mademoiselle');

-- --------------------------------------------------------

--
-- Structure de la table `codepostal`
--

DROP TABLE IF EXISTS `codepostal`;
CREATE TABLE IF NOT EXISTS `codepostal` (
  `idcp` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(5) NOT NULL,
  `idpays` int(11) NOT NULL,
  PRIMARY KEY (`idcp`),
  KEY `idpays` (`idpays`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `document`
--

DROP TABLE IF EXISTS `document`;
CREATE TABLE IF NOT EXISTS `document` (
  `codedocument` varchar(6) NOT NULL,
  `titre_document` varchar(50) NOT NULL,
  `codeTypeDocument` varchar(3) NOT NULL,
  PRIMARY KEY (`codedocument`),
  KEY `codeTypeDocument` (`codeTypeDocument`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `etat`
--

DROP TABLE IF EXISTS `etat`;
CREATE TABLE IF NOT EXISTS `etat` (
  `code` varchar(1) NOT NULL,
  `libelle` varchar(20) NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `etat`
--

INSERT INTO `etat` (`code`, `libelle`) VALUES
('D', 'deteriore'),
('E', 'emprunter'),
('L', 'libre'),
('P', 'perdu');

-- --------------------------------------------------------

--
-- Structure de la table `exemplaire`
--

DROP TABLE IF EXISTS `exemplaire`;
CREATE TABLE IF NOT EXISTS `exemplaire` (
  `numero_exemplaire` varchar(2) NOT NULL,
  `codesupport` varchar(3) NOT NULL,
  `codedocument` varchar(6) NOT NULL,
  `code` varchar(1) NOT NULL,
  PRIMARY KEY (`numero_exemplaire`,`codedocument`),
  KEY `codesupport` (`codesupport`),
  KEY `codedocument` (`codedocument`),
  KEY `code` (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `facture`
--

DROP TABLE IF EXISTS `facture`;
CREATE TABLE IF NOT EXISTS `facture` (
  `idfacture` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(4) NOT NULL,
  `id_tva` int(11) NOT NULL,
  PRIMARY KEY (`idfacture`),
  KEY `code` (`code`),
  KEY `id_tva` (`id_tva`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `lieu`
--

DROP TABLE IF EXISTS `lieu`;
CREATE TABLE IF NOT EXISTS `lieu` (
  `idlieu` int(11) NOT NULL AUTO_INCREMENT,
  `nomLieu` varchar(50) NOT NULL,
  PRIMARY KEY (`idlieu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `location`
--

DROP TABLE IF EXISTS `location`;
CREATE TABLE IF NOT EXISTS `location` (
  `idlocation` int(11) NOT NULL AUTO_INCREMENT,
  `datelocation` date NOT NULL,
  `dateretour` date NOT NULL,
  `numero_exemplaire` varchar(2) NOT NULL,
  `codedocument` varchar(6) NOT NULL,
  `code` varchar(4) NOT NULL,
  `idfacture` int(11) NOT NULL,
  PRIMARY KEY (`idlocation`),
  KEY `numero_exemplaire` (`numero_exemplaire`,`codedocument`),
  KEY `code` (`code`),
  KEY `idfacture` (`idfacture`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

DROP TABLE IF EXISTS `participer`;
CREATE TABLE IF NOT EXISTS `participer` (
  `codedocument` varchar(6) NOT NULL,
  `idstar` int(11) NOT NULL,
  `ID_Compositeur` int(11) NOT NULL,
  PRIMARY KEY (`codedocument`,`idstar`,`ID_Compositeur`),
  KEY `idstar` (`idstar`),
  KEY `ID_Compositeur` (`ID_Compositeur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `pays`
--

DROP TABLE IF EXISTS `pays`;
CREATE TABLE IF NOT EXISTS `pays` (
  `idpays` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) NOT NULL,
  PRIMARY KEY (`idpays`)
) ENGINE=InnoDB AUTO_INCREMENT=200 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `pays`
--

INSERT INTO `pays` (`idpays`, `libelle`) VALUES
(2, 'Afrique du Sud'),
(3, 'Afghanistan'),
(4, 'Albanie'),
(5, 'Algérie'),
(6, 'Allemagne'),
(7, 'Andorre'),
(8, 'Angola'),
(9, 'Antigua-et-Barbuda'),
(10, 'Arabie Saoudite'),
(11, 'Argentine'),
(12, 'Arménie'),
(13, 'Australie'),
(14, 'Autriche'),
(15, 'Azerbaïdjan'),
(16, 'Bahamas'),
(17, 'Bahreïn'),
(18, 'Bangladesh'),
(19, 'Barbade'),
(20, 'Belgique'),
(21, 'Belize'),
(22, 'Bénin'),
(23, 'Bhoutan'),
(24, 'Biélorussie'),
(25, 'Birmanie'),
(26, 'Bolivie'),
(27, 'Bosnie-Herzégovine'),
(28, 'Botswana'),
(29, 'Brésil'),
(30, 'Brunei'),
(31, 'Bulgarie'),
(32, 'Burkina Faso'),
(33, 'Burundi'),
(34, 'Cambodge'),
(35, 'Cameroun'),
(36, 'Canada'),
(37, 'Cap-Vert'),
(38, 'Chili'),
(39, 'Chine'),
(40, 'Chypre'),
(41, 'Colombie'),
(42, 'Comores'),
(43, 'Corée du Nord'),
(44, 'Corée du Sud'),
(45, 'Costa Rica'),
(46, 'Côte d’Ivoire'),
(47, 'Croatie'),
(48, 'Cuba'),
(49, 'Danemark'),
(50, 'Djibouti'),
(51, 'Dominique'),
(52, 'Égypte'),
(53, 'Émirats arabes unis'),
(54, 'Équateur'),
(55, 'Érythrée'),
(56, 'Espagne'),
(57, 'Estonie'),
(58, 'États-Unis'),
(59, 'Éthiopie'),
(60, 'Fidji'),
(61, 'Finlande'),
(62, 'France'),
(63, 'Gabon'),
(64, 'Gambie'),
(65, 'Géorgie'),
(66, 'Ghana'),
(67, 'Grèce'),
(68, 'Grenade'),
(69, 'Guatemala'),
(70, 'Guinée'),
(71, 'Guinée équatoriale'),
(72, 'Guinée-Bissau'),
(73, 'Guyana'),
(74, 'Haïti'),
(75, 'Honduras'),
(76, 'Hongrie'),
(77, 'Îles Cook'),
(78, 'Îles Marshall'),
(79, 'Inde'),
(80, 'Indonésie'),
(81, 'Irak'),
(82, 'Iran'),
(83, 'Irlande'),
(84, 'Islande'),
(85, 'Israël'),
(86, 'Italie'),
(87, 'Jamaïque'),
(88, 'Japon'),
(89, 'Jordanie'),
(90, 'Kazakhstan'),
(91, 'Kenya'),
(92, 'Kirghizistan'),
(93, 'Kiribati'),
(94, 'Koweït'),
(95, 'Laos'),
(96, 'Lesotho'),
(97, 'Lettonie'),
(98, 'Liban'),
(99, 'Liberia'),
(100, 'Libye'),
(101, 'Liechtenstein'),
(102, 'Lituanie'),
(103, 'Luxembourg'),
(104, 'Macédoine'),
(105, 'Madagascar'),
(106, 'Malaisie'),
(107, 'Malawi'),
(108, 'Maldives'),
(109, 'Mali'),
(110, 'Malte'),
(111, 'Maroc'),
(112, 'Maurice'),
(113, 'Mauritanie'),
(114, 'Mexique'),
(115, 'Micronésie'),
(116, 'Moldavie'),
(117, 'Monaco'),
(118, 'Mongolie'),
(119, 'Monténégro'),
(120, 'Mozambique'),
(121, 'Namibie'),
(122, 'Nauru'),
(123, 'Népal'),
(124, 'Nicaragua'),
(125, 'Niger'),
(126, 'Nigeria'),
(127, 'Niue'),
(128, 'Norvège'),
(129, 'Nouvelle-Zélande'),
(130, 'Oman'),
(131, 'Ouganda'),
(132, 'Ouzbékistan'),
(133, 'Pakistan'),
(134, 'Palaos'),
(135, 'Palestine'),
(136, 'Panama'),
(137, 'Papouasie-Nouvelle-Guinée'),
(138, 'Paraguay'),
(139, 'Pays-Bas'),
(140, 'Pérou'),
(141, 'Philippines'),
(142, 'Pologne'),
(143, 'Portugal'),
(144, 'Qatar'),
(145, 'République centrafricaine'),
(146, 'République démocratique du Congo'),
(147, 'République Dominicaine'),
(148, 'République du Congo'),
(149, 'République tchèque'),
(150, 'Roumanie'),
(151, 'Royaume-Uni'),
(152, 'Russie'),
(153, 'Rwanda'),
(154, 'Saint-Kitts-et-Nevis'),
(155, 'Saint-Vincent-et-les-Grenadines'),
(156, 'Sainte-Lucie'),
(157, 'Saint-Marin'),
(158, 'Salomon'),
(159, 'Salvador'),
(160, 'Samoa'),
(161, 'São Tomé-et-Principe'),
(162, 'Sénégal'),
(163, 'Serbie'),
(164, 'Seychelles'),
(165, 'Sierra Leone'),
(166, 'Singapour'),
(167, 'Slovaquie'),
(168, 'Slovénie'),
(169, 'Somalie'),
(170, 'Soudan'),
(171, 'Soudan du Sud'),
(172, 'Sri Lanka'),
(173, 'Suède'),
(174, 'Suisse'),
(175, 'Suriname'),
(176, 'Swaziland'),
(177, 'Syrie'),
(178, 'Tadjikistan'),
(179, 'Tanzanie'),
(180, 'Tchad'),
(181, 'Thaïlande'),
(182, 'Timor oriental'),
(183, 'Togo'),
(184, 'Tonga'),
(185, 'Trinité-et-Tobago'),
(186, 'Tunisie'),
(187, 'Turkménistan'),
(188, 'Turquie'),
(189, 'Tuvalu'),
(190, 'Ukraine'),
(191, 'Uruguay'),
(192, 'Vanuatu'),
(193, 'Vatican'),
(194, 'Venezuela'),
(195, 'Viêt Nam'),
(196, 'Yémen'),
(197, 'Zambie'),
(198, 'Zimbabwe'),
(199, 'Angleterre');

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `ID_Compositeur` int(11) NOT NULL AUTO_INCREMENT,
  `nomCompositeur` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Compositeur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `star`
--

DROP TABLE IF EXISTS `star`;
CREATE TABLE IF NOT EXISTS `star` (
  `idstar` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `datenaissance` datetime NOT NULL,
  `paysorigine` varchar(50) NOT NULL,
  `photo` varchar(50) NOT NULL,
  PRIMARY KEY (`idstar`),
  KEY `nom` (`nom`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `star`
--

INSERT INTO `star` (`idstar`, `nom`, `prenom`, `datenaissance`, `paysorigine`, `photo`) VALUES
(7, 'John', 'Boyega', '1992-01-01 21:49:35', 'Angleterre', 'D:\\image\\johnBoyega.jpg'),
(8, 'Ford', 'Harrison', '1942-07-13 21:57:22', 'États-Unis', 'D:\\image\\harrisonFord.jpg'),
(9, 'Ridley', 'Daisy', '1992-01-01 23:14:50', 'Angleterre', 'D:\\image\\daisyRisley.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `support`
--

DROP TABLE IF EXISTS `support`;
CREATE TABLE IF NOT EXISTS `support` (
  `codesupport` varchar(3) NOT NULL,
  `libellesupport` varchar(50) NOT NULL,
  `idtarif` int(11) NOT NULL,
  PRIMARY KEY (`codesupport`),
  KEY `idtarif` (`idtarif`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `support`
--

INSERT INTO `support` (`codesupport`, `libellesupport`, `idtarif`) VALUES
('DVD', 'DVD', 3),
('TCH', 'telechargement', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tarif`
--

DROP TABLE IF EXISTS `tarif`;
CREATE TABLE IF NOT EXISTS `tarif` (
  `idtarif` int(11) NOT NULL AUTO_INCREMENT,
  `prixunitaire` float NOT NULL,
  `idunite` int(11) NOT NULL,
  PRIMARY KEY (`idtarif`),
  KEY `idunite` (`idunite`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tarif`
--

INSERT INTO `tarif` (`idtarif`, `prixunitaire`, `idunite`) VALUES
(1, 5, 1),
(2, 4, 2),
(3, 3, 2);

-- --------------------------------------------------------

--
-- Structure de la table `taxe_planetaire`
--

DROP TABLE IF EXISTS `taxe_planetaire`;
CREATE TABLE IF NOT EXISTS `taxe_planetaire` (
  `id_tva` int(11) NOT NULL AUTO_INCREMENT,
  `taux` float NOT NULL,
  `libelle` varchar(20) NOT NULL,
  PRIMARY KEY (`id_tva`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `tourner`
--

DROP TABLE IF EXISTS `tourner`;
CREATE TABLE IF NOT EXISTS `tourner` (
  `idlieu` int(11) NOT NULL,
  `codedocument` varchar(6) NOT NULL,
  PRIMARY KEY (`idlieu`,`codedocument`),
  KEY `codedocument` (`codedocument`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `typedocument`
--

DROP TABLE IF EXISTS `typedocument`;
CREATE TABLE IF NOT EXISTS `typedocument` (
  `codeTypeDocument` varchar(3) NOT NULL,
  `typeNom` varchar(50) NOT NULL,
  PRIMARY KEY (`codeTypeDocument`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `unitevente`
--

DROP TABLE IF EXISTS `unitevente`;
CREATE TABLE IF NOT EXISTS `unitevente` (
  `idunite` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(20) NOT NULL,
  PRIMARY KEY (`idunite`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `unitevente`
--

INSERT INTO `unitevente` (`idunite`, `libelle`) VALUES
(1, 'forfait'),
(2, 'prix journalier');

-- --------------------------------------------------------

--
-- Structure de la table `ville`
--

DROP TABLE IF EXISTS `ville`;
CREATE TABLE IF NOT EXISTS `ville` (
  `idville` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) NOT NULL,
  `idcp` int(11) NOT NULL,
  PRIMARY KEY (`idville`),
  KEY `idcp` (`idcp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `adherent`
--
ALTER TABLE `adherent`
  ADD CONSTRAINT `adherent_ibfk_1` FOREIGN KEY (`idville`) REFERENCES `ville` (`idville`),
  ADD CONSTRAINT `adherent_ibfk_2` FOREIGN KEY (`idcivil`) REFERENCES `civilite` (`idcivil`);

--
-- Contraintes pour la table `codepostal`
--
ALTER TABLE `codepostal`
  ADD CONSTRAINT `codepostal_ibfk_1` FOREIGN KEY (`idpays`) REFERENCES `pays` (`idpays`);

--
-- Contraintes pour la table `document`
--
ALTER TABLE `document`
  ADD CONSTRAINT `document_ibfk_1` FOREIGN KEY (`codeTypeDocument`) REFERENCES `typedocument` (`codeTypeDocument`);

--
-- Contraintes pour la table `exemplaire`
--
ALTER TABLE `exemplaire`
  ADD CONSTRAINT `exemplaire_ibfk_1` FOREIGN KEY (`codesupport`) REFERENCES `support` (`codesupport`),
  ADD CONSTRAINT `exemplaire_ibfk_2` FOREIGN KEY (`codedocument`) REFERENCES `document` (`codedocument`),
  ADD CONSTRAINT `exemplaire_ibfk_3` FOREIGN KEY (`code`) REFERENCES `etat` (`code`);

--
-- Contraintes pour la table `facture`
--
ALTER TABLE `facture`
  ADD CONSTRAINT `facture_ibfk_1` FOREIGN KEY (`code`) REFERENCES `adherent` (`code`),
  ADD CONSTRAINT `facture_ibfk_2` FOREIGN KEY (`id_tva`) REFERENCES `taxe_planetaire` (`id_tva`);

--
-- Contraintes pour la table `location`
--
ALTER TABLE `location`
  ADD CONSTRAINT `location_ibfk_1` FOREIGN KEY (`numero_exemplaire`,`codedocument`) REFERENCES `exemplaire` (`numero_exemplaire`, `codedocument`),
  ADD CONSTRAINT `location_ibfk_2` FOREIGN KEY (`code`) REFERENCES `adherent` (`code`),
  ADD CONSTRAINT `location_ibfk_3` FOREIGN KEY (`idfacture`) REFERENCES `facture` (`idfacture`);

--
-- Contraintes pour la table `participer`
--
ALTER TABLE `participer`
  ADD CONSTRAINT `participer_ibfk_1` FOREIGN KEY (`codedocument`) REFERENCES `document` (`codedocument`),
  ADD CONSTRAINT `participer_ibfk_2` FOREIGN KEY (`idstar`) REFERENCES `star` (`idstar`),
  ADD CONSTRAINT `participer_ibfk_3` FOREIGN KEY (`ID_Compositeur`) REFERENCES `role` (`ID_Compositeur`);

--
-- Contraintes pour la table `support`
--
ALTER TABLE `support`
  ADD CONSTRAINT `support_ibfk_1` FOREIGN KEY (`idtarif`) REFERENCES `tarif` (`idtarif`);

--
-- Contraintes pour la table `tarif`
--
ALTER TABLE `tarif`
  ADD CONSTRAINT `tarif_ibfk_1` FOREIGN KEY (`idunite`) REFERENCES `unitevente` (`idunite`);

--
-- Contraintes pour la table `tourner`
--
ALTER TABLE `tourner`
  ADD CONSTRAINT `tourner_ibfk_1` FOREIGN KEY (`idlieu`) REFERENCES `lieu` (`idlieu`),
  ADD CONSTRAINT `tourner_ibfk_2` FOREIGN KEY (`codedocument`) REFERENCES `document` (`codedocument`);

--
-- Contraintes pour la table `ville`
--
ALTER TABLE `ville`
  ADD CONSTRAINT `ville_ibfk_1` FOREIGN KEY (`idcp`) REFERENCES `codepostal` (`idcp`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
