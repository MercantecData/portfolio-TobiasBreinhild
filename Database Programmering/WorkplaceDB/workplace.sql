-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 29. 11 2019 kl. 11:40:57
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
-- Database: `workplace`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `department`
--

CREATE TABLE `department` (
  `Department_id` int(11) NOT NULL,
  `department_name` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `department`
--

INSERT INTO `department` (`Department_id`, `department_name`) VALUES
(1, 'Office'),
(2, 'Work Area A'),
(3, 'Work Area B'),
(4, 'Cafeteria');

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `departmentemployee`
--

CREATE TABLE `departmentemployee` (
  `dpemployee_id` int(11) NOT NULL,
  `employeeID` int(11) DEFAULT NULL,
  `departmentID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `departmentemployee`
--

INSERT INTO `departmentemployee` (`dpemployee_id`, `employeeID`, `departmentID`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 2),
(5, 5, 2),
(6, 6, 3),
(7, 7, 3),
(8, 8, 4),
(9, 9, 4),
(10, 10, 4);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `departmentmanager`
--

CREATE TABLE `departmentmanager` (
  `dpmanager_id` int(11) NOT NULL,
  `employeeID` int(11) DEFAULT NULL,
  `departmentID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `departmentmanager`
--

INSERT INTO `departmentmanager` (`dpmanager_id`, `employeeID`, `departmentID`) VALUES
(1, 2, 1),
(2, 4, 2),
(3, 6, 3),
(4, 8, 4);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `employee`
--

CREATE TABLE `employee` (
  `employee_id` int(11) NOT NULL,
  `first_name` varchar(256) DEFAULT NULL,
  `last_name` varchar(256) DEFAULT NULL,
  `e_username` varchar(256) DEFAULT NULL,
  `e_password` varchar(256) DEFAULT NULL,
  `email` varchar(256) DEFAULT NULL,
  `titleID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `employee`
--

INSERT INTO `employee` (`employee_id`, `first_name`, `last_name`, `e_username`, `e_password`, `email`, `titleID`) VALUES
(1, 'Allan', 'Bob', 'AL', 'LAN', 'allan@gmail.com', 1),
(2, 'Benny', 'Bob', 'BO', 'B', 'benny@gmail.com', 2),
(3, 'Carl', 'Bob', 'CA', 'RL', 'carl@gmail.com', 2),
(4, 'Daniel', 'Bob', 'DAN', 'IEL', 'dan@gmail.com', 3),
(5, 'Eric', 'Bob', 'ER', 'IC', 'eric@gmail.com', 3),
(6, 'Frank', 'Bob', 'FRA', 'NK', 'frank@gmail.com', 3),
(7, 'George', 'Bob', 'GEOR', 'GE', 'george@gmail.com', 3),
(8, 'Hans', 'Bob', 'HA', 'NS', 'hans@gmail.com', 4),
(9, 'Ian', 'Bob', 'I', 'AN', 'ian@gmail.com', 4),
(10, 'Jake', 'Bob', 'JA', 'KE', 'jake@gmail.com', 5);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `employeestats`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `employeestats` (
`first_name` varchar(256)
,`last_name` varchar(256)
,`title_name` varchar(256)
,`department_name` varchar(256)
,`amount_work` int(11)
,`amount_money` int(11)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `salaries`
--

CREATE TABLE `salaries` (
  `salary_id` int(11) NOT NULL,
  `employeeID` int(11) DEFAULT NULL,
  `departmentID` int(11) DEFAULT NULL,
  `amount_work` int(11) DEFAULT NULL,
  `amount_money` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `salaries`
--

INSERT INTO `salaries` (`salary_id`, `employeeID`, `departmentID`, `amount_work`, `amount_money`) VALUES
(1, 1, 1, 37, 100000),
(2, 2, 1, 37, 75000),
(3, 3, 1, 37, 75000),
(4, 4, 2, 34, 25000),
(5, 5, 2, 34, 25000),
(6, 6, 3, 34, 25000),
(7, 7, 3, 34, 25000),
(8, 8, 4, 35, 30000),
(9, 9, 4, 35, 30000),
(10, 10, 4, 0, 2);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `titles`
--

CREATE TABLE `titles` (
  `title_id` int(11) NOT NULL,
  `title_name` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `titles`
--

INSERT INTO `titles` (`title_id`, `title_name`) VALUES
(1, 'Boss'),
(2, 'Office Staff'),
(3, 'Worker'),
(4, 'Cook'),
(5, 'Some Random-ass Dude');

-- --------------------------------------------------------

--
-- Struktur for visning `employeestats`
--
DROP TABLE IF EXISTS `employeestats`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `employeestats`  AS  select `employee`.`first_name` AS `first_name`,`employee`.`last_name` AS `last_name`,`titles`.`title_name` AS `title_name`,`department`.`department_name` AS `department_name`,`salaries`.`amount_work` AS `amount_work`,`salaries`.`amount_money` AS `amount_money` from (((`employee` join `department` on(`employee`.`employee_id` = `department`.`Department_id`)) join `titles` on(`employee`.`titleID` = `titles`.`title_id`)) join `salaries` on(`employee`.`employee_id` = `salaries`.`employeeID`)) ;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`Department_id`);

--
-- Indeks for tabel `departmentemployee`
--
ALTER TABLE `departmentemployee`
  ADD PRIMARY KEY (`dpemployee_id`),
  ADD KEY `employeeID` (`employeeID`),
  ADD KEY `departmentID` (`departmentID`);

--
-- Indeks for tabel `departmentmanager`
--
ALTER TABLE `departmentmanager`
  ADD PRIMARY KEY (`dpmanager_id`),
  ADD KEY `employeeID` (`employeeID`),
  ADD KEY `departmentID` (`departmentID`);

--
-- Indeks for tabel `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employee_id`),
  ADD KEY `titleID` (`titleID`);

--
-- Indeks for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD PRIMARY KEY (`salary_id`),
  ADD KEY `employeeID` (`employeeID`),
  ADD KEY `departmentID` (`departmentID`);

--
-- Indeks for tabel `titles`
--
ALTER TABLE `titles`
  ADD PRIMARY KEY (`title_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `department`
--
ALTER TABLE `department`
  MODIFY `Department_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tilføj AUTO_INCREMENT i tabel `departmentemployee`
--
ALTER TABLE `departmentemployee`
  MODIFY `dpemployee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `departmentmanager`
--
ALTER TABLE `departmentmanager`
  MODIFY `dpmanager_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tilføj AUTO_INCREMENT i tabel `employee`
--
ALTER TABLE `employee`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Tilføj AUTO_INCREMENT i tabel `salaries`
--
ALTER TABLE `salaries`
  MODIFY `salary_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `titles`
--
ALTER TABLE `titles`
  MODIFY `title_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `departmentemployee`
--
ALTER TABLE `departmentemployee`
  ADD CONSTRAINT `departmentemployee_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employee_id`),
  ADD CONSTRAINT `departmentemployee_ibfk_2` FOREIGN KEY (`departmentID`) REFERENCES `department` (`Department_id`);

--
-- Begrænsninger for tabel `departmentmanager`
--
ALTER TABLE `departmentmanager`
  ADD CONSTRAINT `departmentmanager_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employee_id`),
  ADD CONSTRAINT `departmentmanager_ibfk_2` FOREIGN KEY (`departmentID`) REFERENCES `department` (`Department_id`);

--
-- Begrænsninger for tabel `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`titleID`) REFERENCES `titles` (`title_id`);

--
-- Begrænsninger for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD CONSTRAINT `salaries_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employee_id`),
  ADD CONSTRAINT `salaries_ibfk_2` FOREIGN KEY (`departmentID`) REFERENCES `department` (`Department_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
