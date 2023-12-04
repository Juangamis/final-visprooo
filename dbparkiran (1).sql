-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2023 at 03:48 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `juang`
--

-- --------------------------------------------------------

--
-- Table structure for table `dbparkiran`
--

CREATE TABLE `dbparkiran` (
  `Nama` varchar(50) NOT NULL,
  `NIM` int(20) NOT NULL,
  `Fakultas` varchar(50) NOT NULL,
  `Jurusan` varchar(50) NOT NULL,
  `Kendaraan` varchar(50) NOT NULL,
  `Parkiran` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dbparkiran`
--

INSERT INTO `dbparkiran` (`Nama`, `NIM`, `Fakultas`, `Jurusan`, `Kendaraan`, `Parkiran`) VALUES
('Alo', 1050123112, 'Ekonomi', 'Business', 'honda', 'gk 2'),
('bopak', 1050221100, 'keperawatan', 'keperawatan', 'honda brio', 'GK1'),
('cilla', 1050529857, 'keperawatan', 'keperawatan', 'Wuling', 'GK2'),
('derel', 1050986734, 'komputer', 'informatika', 'honda jass', 'GK3'),
('echa', 1050748395, 'Ilmu Komputer', 'sustem informasi', 'avanza', 'GK2'),
('enjel', 1050667722, 'Ekonomi', 'managemen', 'nissan', 'GA'),
('ezra', 12141241, 'ilmu komputer', 'inforamtika', 'suzuki', 'parkiran GK 3'),
('jakly', 1050245375, 'keperawatan', 'keperawatan', 'vario', 'GA'),
('javier', 1050023123, 'filsafat', 'filsafat', 'Wuling', 'PARLOT GA'),
('joan', 1050221102, 'ilmu keperawatan', 'nurse', 'honda', 'parkiran gk 2'),
('juan', 1050221183, 'ilmu komputer', 'inforamtika', 'toyota', 'parlot mobil'),
('messi', 1050978675, 'Ilmu Komputer', 'Informatika', 'lamborghini', 'GK1'),
('naruto', 1050239876, 'ilmu komputer', 'Informatika', 'argera', 'GK1'),
('ogi', 105012312, 'ilmu komputer', 'sustem informasi', 'suzuki', 'parkiran gk 3'),
('olan', 1050543683, 'keperawatan', 'keperawatan', 'aerox', 'GK1'),
('ronaldo', 1050435678, 'filsafat', 'filsafat', 'buggati', 'GA'),
('sasuke', 1050285395, 'filsafat', 'filsafat', 'nissan', 'GA'),
('valdo', 1050692583, 'Ilmu Komputer', 'Informatika', 'honda brio', 'GA'),
('vina', 1050966985, 'Ekonomi', 'Business', 'veloz', 'Gk3'),
('wati', 1050687521, 'Ekonomi', 'Business', 'terios', 'GK2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dbparkiran`
--
ALTER TABLE `dbparkiran`
  ADD PRIMARY KEY (`Nama`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
