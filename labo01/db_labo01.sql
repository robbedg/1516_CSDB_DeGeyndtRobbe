-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Gegenereerd op: 06 mrt 2016 om 21:44
-- Serverversie: 5.6.17
-- PHP-versie: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `db_labo01`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `docenten`
--

DROP TABLE IF EXISTS `docenten`;
CREATE TABLE IF NOT EXISTS `docenten` (
  `personeelsnummer` varchar(8) NOT NULL,
  `naam` varchar(45) NOT NULL,
  `voornaam` varchar(45) NOT NULL,
  PRIMARY KEY (`personeelsnummer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `docenten`
--

INSERT INTO `docenten` (`personeelsnummer`, `naam`, `voornaam`) VALUES
('a0000000', 'Vanderper', 'Hilde'),
('a0000001', 'Bracke', 'Lieven'),
('a0000002', 'Martens', 'Sabine'),
('a0000003', 'Wyns', 'Mario'),
('a0000004', 'Donné', 'Johannes'),
('a0000005', 'Sanders', 'Sven'),
('a0000006', 'Debbaut', 'Patrik'),
('a0000007', 'De Smet', 'Alexander'),
('a0000008', 'Van Assche', 'Kristien'),
('a0000009', 'Verbeeck', 'Katja'),
('a0000010', 'Vermeulen', 'Tim'),
('a0000011', 'Demeester', 'Peter'),
('a0000012', 'Maervoet', 'Joris'),
('a0000013', 'van der Linde', 'Rogier');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `docenten_has_olas`
--

DROP TABLE IF EXISTS `docenten_has_olas`;
CREATE TABLE IF NOT EXISTS `docenten_has_olas` (
  `personeelsnummer` varchar(8) NOT NULL,
  `OLAs_code` varchar(6) NOT NULL,
  PRIMARY KEY (`personeelsnummer`,`OLAs_code`),
  KEY `fk_docenten_has_OLAs_OLAs1_idx` (`OLAs_code`),
  KEY `fk_docenten_has_OLAs_docenten1_idx` (`personeelsnummer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `docenten_has_olas`
--

INSERT INTO `docenten_has_olas` (`personeelsnummer`, `OLAs_code`) VALUES
('a0000009', 'JLW141'),
('a0000010', 'JLW141'),
('a0000012', 'JLW141'),
('a0000004', 'JLW265'),
('a0000008', 'JLW265'),
('a0000009', 'JLW268'),
('a0000010', 'JLW268'),
('a0000011', 'JLW341'),
('a0000008', 'JLW342'),
('a0000009', 'JLW342'),
('a0000011', 'JLW342'),
('a0000000', 'JLW465'),
('a0000003', 'JLW466'),
('a0000005', 'JLW466'),
('a0000003', 'JLW467'),
('a0000005', 'JLW467'),
('a0000004', 'JLW468'),
('a0000006', 'JLW469'),
('a0000006', 'JLW470'),
('a0000007', 'JLW471'),
('a0000004', 'JLW472'),
('a0000008', 'JLW472'),
('a0000005', 'JLW473'),
('a0000002', 'JLW474'),
('a0000010', 'JLW475'),
('a0000010', 'JLW476'),
('a0000010', 'JLW477'),
('a0000013', 'JLW478'),
('a0000013', 'JLW479'),
('a0000012', 'JLW502'),
('a0000013', 'JLW510'),
('a0000001', 'JLWXTS'),
('a0000002', 'JLWXTT');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `olas`
--

DROP TABLE IF EXISTS `olas`;
CREATE TABLE IF NOT EXISTS `olas` (
  `code` varchar(6) NOT NULL,
  `naam` varchar(45) NOT NULL,
  `stp` int(11) NOT NULL,
  `OPO` varchar(6) NOT NULL,
  PRIMARY KEY (`code`),
  UNIQUE KEY `code_UNIQUE` (`code`),
  KEY `fk_OLAs_OPOs1_idx` (`OPO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `olas`
--

INSERT INTO `olas` (`code`, `naam`, `stp`, `OPO`) VALUES
('JLW141', 'Wetenschappelijke toepassingen 2', 3, 'JPW212'),
('JLW265', 'C# OO programmeren', 1, 'JPW337'),
('JLW268', 'Wetenschappelijke toepassingen 1', 2, 'JPW337'),
('JLW341', 'C# DB programmeren', 1, 'JPW212'),
('JLW342', 'Labo C# DB programmeren', 3, 'JPW212'),
('JLW465', 'Ethiek', 3, 'JPW333'),
('JLW466', 'Microcontrollers 2', 1, 'JPW334'),
('JLW467', 'Labo Microcontrollers 2', 2, 'JPW334'),
('JLW468', 'Processorarchitectuur', 2, 'JPW334'),
('JLW469', 'Elektronische Signalen 2', 2, 'JPW335'),
('JLW470', 'Labo Elektronische Signalen 2', 2, 'JPW335'),
('JLW471', 'Routing and switching essentials', 5, 'JPW336'),
('JLW472', 'Labo C# OO programmeren', 2, 'JPW337'),
('JLW473', 'Projecten 1', 3, 'JPW338'),
('JLW474', 'Wetenschappelijk rapporteren', 2, 'JPW338'),
('JLW475', 'Basis Systeembeheer', 1, 'JPW339'),
('JLW476', 'Labo Linux Server', 2, 'JPW339'),
('JLW477', 'Labo Windows Server', 2, 'JPW339'),
('JLW478', 'User Experience Design', 2, 'JPW340'),
('JLW479', 'Labo Web Design and Usability 2', 2, 'JPW340'),
('JLW502', 'Webscripten 1', 1, 'JPW359'),
('JLW510', 'Labo Clientside webscripten 1', 2, 'JPW359'),
('JLW511', 'Labo Serverside webscripten 1', 2, 'JPW359'),
('JLWXTS', 'Frans 1', 2, 'JPW0CM'),
('JLWXTT', 'Engels 1', 2, 'JPW0CM');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `opos`
--

DROP TABLE IF EXISTS `opos`;
CREATE TABLE IF NOT EXISTS `opos` (
  `code` varchar(6) NOT NULL,
  `naam` varchar(45) NOT NULL,
  `stp` int(11) NOT NULL,
  `verantwoordelijke` varchar(8) NOT NULL,
  `sem` enum('sem1','sem2') NOT NULL,
  `fase` enum('fase1','fase2','fase3') NOT NULL,
  PRIMARY KEY (`code`),
  UNIQUE KEY `code_UNIQUE` (`code`),
  KEY `fk_OPOs_docenten_idx` (`verantwoordelijke`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `opos`
--

INSERT INTO `opos` (`code`, `naam`, `stp`, `verantwoordelijke`, `sem`, `fase`) VALUES
('JPW0CM', 'Communicatieve vorming 1', 4, 'a0000001', 'sem2', 'fase2'),
('JPW212', 'Programmeren 4', 7, 'a0000011', 'sem2', 'fase2'),
('JPW333', 'Filosofie-Ethiek-RZL', 3, 'a0000000', 'sem1', 'fase2'),
('JPW334', 'Computertechnologie 3', 5, 'a0000003', 'sem1', 'fase2'),
('JPW335', 'Elektronische Signalen 2', 4, 'a0000006', 'sem1', 'fase2'),
('JPW336', 'Datanetwerken 2', 5, 'a0000007', 'sem1', 'fase2'),
('JPW337', 'Programmeren 3', 5, 'a0000004', 'sem1', 'fase2'),
('JPW338', 'Projecten 1', 5, 'a0000005', 'sem2', 'fase2'),
('JPW339', 'Systeembeheer 2', 5, 'a0000010', 'sem2', 'fase2'),
('JPW340', 'User Experience Design', 4, 'a0000013', 'sem1', 'fase2'),
('JPW359', 'Webscripten1', 5, 'a0000012', 'sem1', 'fase2');

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `docenten_has_olas`
--
ALTER TABLE `docenten_has_olas`
  ADD CONSTRAINT `fk_docenten_has_OLAs_docenten1` FOREIGN KEY (`personeelsnummer`) REFERENCES `docenten` (`personeelsnummer`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_docenten_has_OLAs_OLAs1` FOREIGN KEY (`OLAs_code`) REFERENCES `olas` (`code`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Beperkingen voor tabel `olas`
--
ALTER TABLE `olas`
  ADD CONSTRAINT `fk_OLAs_OPOs1` FOREIGN KEY (`OPO`) REFERENCES `opos` (`code`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Beperkingen voor tabel `opos`
--
ALTER TABLE `opos`
  ADD CONSTRAINT `fk_OPOs_docenten` FOREIGN KEY (`verantwoordelijke`) REFERENCES `docenten` (`personeelsnummer`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
