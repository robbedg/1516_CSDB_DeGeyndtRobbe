-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Gegenereerd op: 11 apr 2016 om 17:06
-- Serverversie: 5.6.17
-- PHP-versie: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `postorder`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `bepaal_lijst_van_bij_te_bestellen_artikelen`()
BEGIN
	
	-- Rollback in case of error
	DECLARE EXIT HANDLER FOR sqlexception
		BEGIN
			ROLLBACK;
		END;

	-- Rollback in case of warning
	DECLARE EXIT HANDLER FOR sqlwarning
		BEGIN
			ROLLBACK;
		END;
	
    -- Drop table if exists
    DROP TABLE IF EXISTS __items;
    
    -- Create temporary table
    CREATE TEMPORARY TABLE __items
		(artikel_id INT(11), aantal INT(11)) ENGINE = HEAP;

	-- Insert values
	START TRANSACTION;
		INSERT INTO __items(artikel_id, aantal)
			SELECT
				items.artikel_id,
                SUM(items.aantal)
			FROM items
            WHERE items.tijdstip IS NULL
            GROUP BY items.artikel_id;
	COMMIT;

	-- Get results
	SELECT
		__items.artikel_id,
		__items.aantal - artikelen.voorraad AS tekort
	FROM __items
    INNER JOIN artikelen
		ON __items.artikel_id = artikelen.artikel_id
	HAVING tekort > 0;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `perform_updates`()
begin
  declare maximum date;
  declare diff int;
  select max(datum) from bestellingen into maximum;
  select to_days(curdate()) - to_days(maximum) into diff;
  update bestellingen set datum = adddate(datum, interval diff day); 
  update items set tijdstip = adddate(tijdstip, interval diff day);
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `artikelen`
--

CREATE TABLE IF NOT EXISTS `artikelen` (
  `artikel_id` int(11) NOT NULL AUTO_INCREMENT,
  `beschr` varchar(60) NOT NULL,
  `voorraad` smallint(6) NOT NULL DEFAULT '0',
  `eenheid` varchar(20) NOT NULL,
  `prijs` decimal(5,2) NOT NULL,
  PRIMARY KEY (`artikel_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=51 ;

--
-- Gegevens worden geëxporteerd voor tabel `artikelen`
--

INSERT INTO `artikelen` (`artikel_id`, `beschr`, `voorraad`, `eenheid`, `prijs`) VALUES
(1, 'bord 26cm', 20, 'stuk', '3.50'),
(2, 'bord 31cm', 20, 'stuk', '4.20'),
(3, 'bordje 22cm', 20, 'stuk', '2.50'),
(4, 'bierglas 26cl', 12, 'set van 2', '7.50'),
(5, 'wijnglas 10cl', 12, 'set van 2', '7.00'),
(6, 'wijnglas 16cl', 12, 'set van 2', '7.50'),
(7, 'glas 25cl', 24, 'set van 12', '5.00'),
(8, 'bestek chroomstaal', 10, 'set 24-delig', '35.00'),
(9, 'eetservies in aardewerk', 10, 'set 18-delig', '12.50'),
(10, 'beker in aardewerk', 10, 'set van 8', '3.70'),
(11, 'afdruiprek in grenen', 5, 'stuk', '5.00'),
(12, 'bestek roestvrij staal', 5, 'set 3-delig', '12.50'),
(13, 'bestek roestvrij staal', 5, 'set 16-delig', '35.00'),
(14, 'bestek roestvrij staal', 5, 'set 16-delig', '25.00'),
(15, 'wijnglas 19cl', 7, 'set van 12', '5.00'),
(16, 'eetservies 4 persoons', 5, 'set 40-delig', '25.00'),
(17, 'serverbord messing 30cm', 0, 'stuk', '10.00'),
(18, 'kandelaar 5-armig', 3, 'stuk', '35.00'),
(19, 'kaarslantaarn glas', 0, 'stuk', '7.50'),
(20, 'kaarsen 28cm', 50, 'set van 10', '3.80'),
(21, 'waxinelichtje', 50, 'set van 30', '1.70'),
(22, 'vaas geglazuurd 13cm', 15, 'stuk', '7.00'),
(23, 'vaas geglazuurd 29cm', 0, 'stuk', '7.50'),
(24, 'klok A1 en glas 39cm', 5, 'stuk', '25.00'),
(25, 'klok golfkarton 28cm', 5, 'stuk', '3.70'),
(26, 'lijst hout/glas 40x50cm', 5, 'stuk', '20.00'),
(27, 'lijst ijzer/glas 10x15cm', 5, 'stuk', '5.00'),
(28, 'lijst grenen 10x15cm', 5, 'stuk', '3.70'),
(29, 'lijst grenen 30x40cm', 5, 'stuk', '8.50'),
(30, 'lijst grenen 50x70cm', 5, 'stuk', '17.50'),
(31, 'spiegel 75x75cm', 2, 'stuk', '47.00'),
(32, 'spiegel 8-hoek 25cm', 2, 'stuk', '15.00'),
(33, 'spiegel 45x60cm', 3, 'set van 4', '27.50'),
(34, 'kapstok metaal staand', 4, 'stuk', '32.50'),
(35, 'kapstok grenen 90x30x26cm', 4, 'stuk', '27.50'),
(36, 'kapstok grenen 78x27x19cm', 1, 'stuk', '35.00'),
(37, 'lamp bol 26cm 60W', 6, 'stuk', '12.50'),
(38, 'lamp wand 10x30cm TL', 6, 'stuk', '22.50'),
(39, 'tafellamp 46cm 40W', 6, 'stuk', '32.50'),
(40, 'kroonluchter 56cm 5x40W', 2, 'stuk', '70.00'),
(41, 'wandlamp 2x40W', 2, 'stuk', '25.00'),
(42, 'bureaulamp halogeen 20W', 7, 'stuk', '7.50'),
(43, 'hanglamp 3x40W', 2, 'stuk', '45.00'),
(44, 'inbouwlamp halogeen 20W', 10, 'set van 2', '30.00'),
(45, 'deurmat kokos 40x60cm', 11, 'stuk', '2.50'),
(46, 'ronde mat maisblad 90cm', 5, 'stuk', '10.00'),
(47, 'mat maisblad 120x180cm', 2, 'stuk', '25.00'),
(48, 'mat maisblad 150x240cm', 5, 'stuk', '37.50'),
(49, 'mat kokos 85x250cm', 5, 'stuk', '32.50'),
(50, 'mat kokos 140x200cm', 5, 'stuk', '40.00');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `bestellingen`
--

CREATE TABLE IF NOT EXISTS `bestellingen` (
  `bestelling_id` int(11) NOT NULL AUTO_INCREMENT,
  `klant_id` int(11) NOT NULL,
  `datum` date NOT NULL,
  PRIMARY KEY (`bestelling_id`),
  KEY `klant_id` (`klant_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=31 ;

--
-- Gegevens worden geëxporteerd voor tabel `bestellingen`
--

INSERT INTO `bestellingen` (`bestelling_id`, `klant_id`, `datum`) VALUES
(1, 1, '2016-02-15'),
(2, 2, '2016-02-15'),
(3, 20, '2016-02-16'),
(4, 10, '2016-02-16'),
(5, 7, '2016-02-18'),
(6, 1, '2016-02-19'),
(7, 2, '2016-02-20'),
(8, 24, '2016-02-20'),
(9, 15, '2016-02-23'),
(10, 10, '2016-02-23'),
(11, 1, '2016-02-25'),
(12, 5, '2016-02-25'),
(13, 21, '2016-02-26'),
(14, 10, '2016-02-27'),
(15, 7, '2016-03-01'),
(16, 1, '2016-03-03'),
(17, 2, '2016-03-04'),
(18, 21, '2016-03-05'),
(19, 16, '2016-03-09'),
(20, 16, '2016-03-11'),
(21, 11, '2016-03-16'),
(22, 12, '2016-03-18'),
(23, 30, '2016-03-20'),
(24, 31, '2016-03-20'),
(25, 27, '2016-03-20'),
(26, 21, '2016-03-25'),
(27, 26, '2016-03-27'),
(28, 42, '2016-03-29'),
(29, 45, '2016-04-01'),
(30, 50, '2016-04-01');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `bestelling_id` int(11) NOT NULL,
  `artikel_id` int(11) NOT NULL,
  `aantal` int(11) NOT NULL,
  `tijdstip` datetime DEFAULT NULL,
  PRIMARY KEY (`bestelling_id`,`artikel_id`),
  KEY `bestelling_id` (`bestelling_id`),
  KEY `artikel_id` (`artikel_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `items`
--

INSERT INTO `items` (`bestelling_id`, `artikel_id`, `aantal`, `tijdstip`) VALUES
(1, 2, 6, '2016-02-17 09:15:00'),
(1, 7, 1, '2016-02-17 09:15:00'),
(2, 26, 2, '2016-02-17 14:15:00'),
(3, 35, 1, '2016-02-18 10:05:00'),
(3, 43, 2, '2016-02-18 10:05:00'),
(4, 42, 1, '2016-02-18 14:25:00'),
(5, 35, 2, '2016-02-21 11:05:00'),
(6, 4, 3, '2016-02-23 16:10:00'),
(6, 16, 1, '2016-02-23 16:10:00'),
(7, 25, 1, '2016-02-23 16:10:00'),
(8, 39, 1, '2016-02-24 15:55:00'),
(9, 13, 1, '2016-02-24 16:40:00'),
(10, 16, 2, '2016-02-24 17:35:00'),
(10, 17, 1, '2016-02-24 17:35:00'),
(10, 21, 1, '2016-03-01 09:35:00'),
(12, 40, 1, '2016-03-01 10:15:00'),
(13, 5, 6, '2016-03-03 13:25:00'),
(14, 49, 3, '2016-03-03 13:45:00'),
(15, 25, 1, '2016-03-03 14:10:00'),
(15, 26, 3, '2016-03-03 14:10:00'),
(16, 39, 1, '2016-03-05 15:45:00'),
(17, 22, 1, '2016-03-09 11:50:00'),
(18, 10, 1, '2016-03-09 12:45:00'),
(19, 18, 1, '2016-03-12 09:10:00'),
(19, 20, 4, '2016-03-14 13:05:00'),
(19, 47, 2, '2016-03-14 13:05:00'),
(20, 37, 2, '2016-03-15 09:40:00'),
(21, 22, 1, '2016-03-17 14:10:00'),
(21, 23, 1, NULL),
(22, 44, 3, '2016-03-23 10:20:00'),
(23, 30, 2, '2016-03-23 11:05:00'),
(24, 18, 1, '2016-03-23 13:35:00'),
(25, 43, 1, '2016-03-25 17:10:00'),
(26, 16, 2, '2016-03-30 09:40:00'),
(27, 16, 1, '2016-04-01 10:45:00'),
(28, 19, 1, NULL),
(29, 17, 1, NULL),
(29, 36, 2, NULL),
(29, 47, 3, NULL),
(30, 7, 1, NULL),
(30, 13, 1, NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `klanten`
--

CREATE TABLE IF NOT EXISTS `klanten` (
  `klant_id` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(40) NOT NULL,
  `vnaam` varchar(20) NOT NULL,
  `adres` varchar(50) NOT NULL,
  `gemeente` varchar(25) NOT NULL,
  PRIMARY KEY (`klant_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=51 ;

--
-- Gegevens worden geëxporteerd voor tabel `klanten`
--

INSERT INTO `klanten` (`klant_id`, `naam`, `vnaam`, `adres`, `gemeente`) VALUES
(1, 'VAN BELLE', 'WERNER', 'HUNDELGEMSE STEENWEG, 105', 'GENT'),
(2, 'HOLLANDS', 'MICHEL', 'LEENWEG, 15', 'WACHTEBEKE'),
(3, 'DE GRAEVE', 'LIEVEN', 'GUIDE GEZELLELAAN, 95', 'DEINZE'),
(4, 'MAENHOUT', 'FREDDY', 'KESSELAARSTRAAT, 5', 'KAPRIJKE'),
(5, 'DE LANGHE', 'JO', 'VAN AKENSTRAAT, 13', 'GENT'),
(6, 'LAROY', 'JAN', 'GANZENDRIES, 231', 'GENT'),
(7, 'LAMBERT', 'MAURICE', 'ZWIJNAARDESTEENWEG, 133', 'GENT'),
(8, 'GOOSENS', 'CARLOS', 'BALGERHOEKJE, 154', 'EEKLO'),
(9, 'GOVAERT', 'BERT', 'DONKLAAN, 17', 'BERLARE'),
(10, 'VERHELLEN', 'STEFAAN', 'BREDERODESTRAAT, 15', 'MELLE'),
(11, 'DEWULF', 'JOZEF', 'KERKSTRAAT, 66', 'OLSENE'),
(12, 'DE VEIRMAN', 'MIA', 'HAMSTRAAT, 15', 'WETTEREN'),
(13, 'DE ROO', 'GRETA', 'WESTSTRAAT, 54', 'SLEIDINGE'),
(14, 'DE COSTER', 'PATRICK', 'VANDENBROECKSTRAAT, 40', 'OSSTAKKER'),
(15, 'DE BOEVER', 'MARIA', 'BAAIGEMSTRAAT, 387', 'GAVERE'),
(16, 'COSYNS', 'LUC', 'TWEEKERKENSTRAAT, 132', 'ZOTTEGEM'),
(17, 'BOONE', 'ERIK', 'WALPOORTSTRAAT, 4', 'GENT'),
(18, 'WILLEMS', 'BETTY', 'STOEPESTRAAT, 41', 'ERTVELDE'),
(19, 'VERMAERCKE', 'KAREL', 'STATIONSTRAAT, 130', 'EKE'),
(20, 'VERMEIREN', 'JACOB', 'WEVERBOSLAAN, 44', 'GENTBRUGGE'),
(21, 'VAN WIJNSBERGHE', 'MICHEL', 'OSSTHOEK, 22B', 'LEMBERGE'),
(22, 'VANHAUTE', 'ERIK', 'NAZARETHSESTEENWEG, 49', 'DEINZE'),
(23, 'MAES', 'FERDINAND', 'MECHELSESTRAAT, 24', 'LONDERZEEL'),
(24, 'LEFEVRE', 'JEANNE', 'WELVAARTSRTAAT, 48', 'AALST'),
(25, 'DE TAEYE', 'TANJA', 'ZWIJNAARDSESTWG, 100B', 'GENT'),
(26, 'DE LEENHEER', 'JOHN', 'OMMEGANGSTRAAT, 35', 'ZELE'),
(27, 'EVERAERT', 'CLARA', 'MOLENSTRAAT, 62', 'MELDERT'),
(28, 'DE TAYE', 'WALTER', 'BOTERMELKSTRAAT, 3', 'ONKERZELE'),
(29, 'DE TROYER', 'AN', 'BOSVELD, 18', 'DENDERWINDEKE'),
(30, 'DERIEMAEKER', 'EDOUARD', 'ZONNESTRAAT, 17', 'RONSE'),
(31, 'DE SADELEER', 'BANJAMIN', 'BOSKOUTERLAAN, 21', 'ERPE'),
(32, 'DE LANGHE', 'JO', 'STATIONSTRAAT, 11', 'OUDENAARDE'),
(33, 'DE BILDE', 'ANTOON', 'HEIRSTRAAT, 118', 'DENDERMONDE'),
(34, 'BORGHMANS', 'HERMAN', 'HOPMARKT, 30', 'AALST'),
(35, 'VERLEYEN', 'MARK', 'DROPSTRAAT, 6', 'AALTER'),
(36, 'VAN WESEMAEL', 'KURT', 'STEENSTRAAT, 72', 'LEDE'),
(37, 'VAN WAEYENBERGHE', 'FREDERICK', 'GENTSTRAAT, 51', 'GERAARDSBERGEN'),
(38, 'VAN WIJNSBERGHE', 'ACHIEL', 'BRUSSELSESTEENWEG, 120', 'LEBEKE'),
(39, 'VAN HAVERBEKE', 'HARRY', 'BRUSSELSESTEENWEG, 147', 'AALTER'),
(40, 'VAN HAUWERMEIREN', 'JAN', 'ASTRIDPLEIN, 8', 'LEBEKE'),
(41, 'VAN DER PERRE', 'WIM', 'KOUTERSTRAAT, 9', 'AALST'),
(42, 'VANDERSNICK', 'ANN', 'PIETER HEIRMANSHOEK, 6', 'BERLARE'),
(43, 'VAN DEN BOSSCHE', 'WALTER', 'VOORUITZICHTSTRAAT, 83', 'AALST'),
(44, 'DE CORTE', 'JO', 'TER PLATEN, 5', 'GENT'),
(45, 'VERMAERKE', 'JOHAN', 'PONTSTRAAT, 72', 'DEINZE'),
(46, 'VANDEKERKHOVE', 'MARC', 'SMIDSESTRAAT, 58', 'GENT'),
(47, 'GIJSSENS', 'STEVEN', 'MULLEMSTRAAT, 6', 'TERNAT'),
(48, 'OPSTAELE', 'HANS', 'ZELLICKLAAN, 24', 'OOSTENDE'),
(49, 'DEVOS', 'WOUTER', 'STATIONSSTRAAT, 17', 'OOSTROZEBEKE'),
(50, 'VAN DE VELDE', 'GEERT', 'VEERSTRAAT, 84A', 'UITBERGEN');

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `bestellingen`
--
ALTER TABLE `bestellingen`
  ADD CONSTRAINT `bestellingen_ibfk_1` FOREIGN KEY (`klant_id`) REFERENCES `klanten` (`klant_id`);

--
-- Beperkingen voor tabel `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `items_ibfk_1` FOREIGN KEY (`bestelling_id`) REFERENCES `bestellingen` (`bestelling_id`),
  ADD CONSTRAINT `items_ibfk_2` FOREIGN KEY (`artikel_id`) REFERENCES `artikelen` (`artikel_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
