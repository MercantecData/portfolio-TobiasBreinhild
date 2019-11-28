-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 28. 11 2019 kl. 12:09:43
-- Serverversion: 10.4.8-MariaDB
-- PHP-version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `something`
--

DELIMITER $$
--
-- Procedurer
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteOrder` (IN `deleteID` INT(11))  BEGIN

	DELETE FROM orders
    WHERE orders.orderid = deleteID;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `addresses`
--

CREATE TABLE `addresses` (
  `addrid` int(11) NOT NULL,
  `userID` int(11) DEFAULT NULL,
  `address` varchar(256) DEFAULT NULL,
  `city` varchar(256) DEFAULT NULL,
  `zipcode` varchar(256) DEFAULT NULL,
  `country` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `addresses`
--

INSERT INTO `addresses` (`addrid`, `userID`, `address`, `city`, `zipcode`, `country`) VALUES
(1, 2, 'Bobby Street 1', 'Bobber Town', '6969', 'BobLand'),
(2, 3, 'Bobby Street 2', 'Bobber Town', '6969', 'BobLand'),
(3, 4, 'Bobby Street 3', 'Bobber Town', '6969', 'BobLand'),
(4, 5, 'Bobby Street 4', 'Bobber Town', '6969', 'BobLand'),
(5, 6, 'Bobby Street 5', 'Bobber Town', '6969', 'BobLand'),
(6, 7, 'Bobby Street 6', 'Bobber Town', '6969', 'BobLand'),
(7, 8, 'Bobby Street 7', 'Bobber Town', '6969', 'BobLand'),
(8, 9, 'Bobby Street 8', 'Bobber Town', '6969', 'BobLand'),
(9, 10, 'Bobby Street 9', 'Bobber Town', '6969', 'BobLand'),
(10, 11, 'Bobby Street 10', 'Bobber Town', '6969', 'BobLand');

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `orders`
--

CREATE TABLE `orders` (
  `orderid` int(11) NOT NULL,
  `userID` int(11) DEFAULT NULL,
  `prodID` int(11) DEFAULT NULL,
  `addrID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `orders`
--

INSERT INTO `orders` (`orderid`, `userID`, `prodID`, `addrID`) VALUES
(1, 2, 3, 4),
(2, 3, 4, 5),
(3, 4, 5, 6),
(4, 5, 6, 7),
(5, 6, 7, 8);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `products`
--

CREATE TABLE `products` (
  `productid` int(11) NOT NULL,
  `prodname` varchar(256) DEFAULT NULL,
  `proddescription` varchar(256) DEFAULT NULL,
  `prodstock` int(11) DEFAULT NULL,
  `prodprice` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `products`
--

INSERT INTO `products` (`productid`, `prodname`, `proddescription`, `prodstock`, `prodprice`) VALUES
(1, 'SMH', 'Smh my head', 10, 3000),
(2, 'OMG', 'Oh my god', 10, 191),
(3, 'FML', 'Frick my life', 10, 900),
(4, 'IMO', 'In my opinion', 10, 1),
(5, 'FFS', 'For frick sake', 10, 40),
(6, 'LMAO', 'Laughing my ass off', 10, 60),
(7, 'WTF', 'What the frick', 10, 20),
(8, 'LMFAO', 'Laughing my fricking ass off', 10, 30),
(9, '69', 'Sixty-nine', 10, 70),
(10, '420', 'Four-twenty', 10, 420);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `testview`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `testview` (
`firstname` varchar(256)
,`lastname` varchar(256)
,`prodname` varchar(256)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(256) DEFAULT NULL,
  `firstname` varchar(256) DEFAULT NULL,
  `lastname` varchar(256) DEFAULT NULL,
  `email` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `users`
--

INSERT INTO `users` (`userid`, `username`, `firstname`, `lastname`, `email`) VALUES
(1, 'BobberMan', 'Bob', 'Man', NULL),
(2, 'BobberMan', 'Bob', 'Man', NULL),
(3, 'Bobbinator', 'Bob', 'Nator', NULL),
(4, 'Bobio', 'Bob', 'Io', NULL),
(5, 'Bobbachu', 'Bob', 'Chu', NULL),
(6, 'Bobby', 'Bob', 'By', NULL),
(7, 'BobbaBobba', 'Bobba', 'Bobba', NULL),
(8, 'BobberWoman', 'Bob', 'Woman', NULL),
(9, 'BobberKid', 'Bob', 'Kid', NULL),
(10, 'Bobu', 'Bob', 'Bu', NULL),
(11, 'WhatTheBob', 'Bob', 'WT', NULL);

-- --------------------------------------------------------

--
-- Struktur for visning `testview`
--
DROP TABLE IF EXISTS `testview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `testview`  AS  select `users`.`firstname` AS `firstname`,`users`.`lastname` AS `lastname`,`products`.`prodname` AS `prodname` from (`users` join `products`) where `users`.`userid` = `products`.`productid` ;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`addrid`),
  ADD KEY `userID` (`userID`);

--
-- Indeks for tabel `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderid`),
  ADD KEY `userID` (`userID`),
  ADD KEY `prodID` (`prodID`),
  ADD KEY `addrID` (`addrID`);

--
-- Indeks for tabel `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`productid`);

--
-- Indeks for tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `addresses`
--
ALTER TABLE `addresses`
  MODIFY `addrid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `orders`
--
ALTER TABLE `orders`
  MODIFY `orderid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `products`
--
ALTER TABLE `products`
  MODIFY `productid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `users` (`userid`);

--
-- Begrænsninger for tabel `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `users` (`userid`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`prodID`) REFERENCES `products` (`productid`),
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`addrID`) REFERENCES `addresses` (`addrid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
