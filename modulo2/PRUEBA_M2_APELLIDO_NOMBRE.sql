
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Feb 08, 2022 at 01:18 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `PRUEBA_M2_APELLIDO_NOMBRE`
--

-- --------------------------------------------------------

--
-- Table structure for table `libros`
--

CREATE TABLE `libros` (
  `id` int(11) NOT NULL,
  `codigo` varchar(6) NOT NULL,
  `titulo` text NOT NULL,
  `categoria` varchar(12) NOT NULL,
  `precio` decimal(10,0) NOT NULL,
  `cantidad_vendida` int(9) NOT NULL,
  `id_publicador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `libros`
--

INSERT INTO `libros` (`id`, `codigo`, `titulo`, `categoria`, `precio`, `cantidad_vendida`, `id_publicador`) VALUES
(1, 'BU1032', 'The Busy Executive Database Guide', 'business', '20', 5000, 3),
(2, 'BU1111', 'Cooking with Computers: Surreptitious Balance Sheets', 'business', '12', 5000, 3),
(3, 'BU2075', 'You Can Combat Computer Stress!', 'business', '3', 10125, 1),
(4, 'BU7832', 'Straight Talk About Computers', 'business', '20', 5000, 3),
(5, 'MC2222', 'Silicon Valley Gastronomic Treats', 'mod_cook', '20', 0, 2),
(6, 'MC3021', 'The Gourmet Microwave', 'mod_cook', '3', 15000, 2),
(7, 'MC3026', 'The Psychology of Computer Cooking', 'UNDECIDED', '0', 0, 2),
(8, 'PC1035', 'But Is It User Friendly?', 'popular_comp', '23', 7000, 3),
(9, 'PC8888', 'Secrets of Silicon Valley', 'popular_comp', '20', 8000, 3),
(10, 'PC9999', 'Net Etiquette', 'popular_comp', '0', 0, 3),
(11, 'PS1372', 'Computer Phobic and Non-Phobic Individuals: Behavior Variati', 'psychology', '22', 7000, 2),
(12, 'PS2091', 'Is Anger the Enemy?', 'psychology', '11', 2275, 1),
(13, 'PS2106', 'Life Without Fear', 'psychology', '7', 6000, 1),
(14, 'PS3333', 'Prolonged Data Deprivation: Four Case Studies', 'psychology', '20', 2000, 1),
(15, 'PS7777', 'Emotional Security: A New Algorithm', 'psychology', '8', 4000, 1),
(16, 'TC3218', 'Onions, Leeks, and Garlic: Cooking Secrets of the Mediterran', 'trad_cook', '21', 7000, 2),
(17, 'TC4203', 'Fifty Years in Buckingham Palace Kitchens', 'trad_cook', '12', 4000, 2),
(18, 'TC7777', 'Sushi, Anyone?', 'trad_cook', '15', 8000, 2);

-- --------------------------------------------------------

--
-- Table structure for table `publicadores`
--

CREATE TABLE `publicadores` (
  `id` int(11) NOT NULL,
  `nombre` text NOT NULL,
  `ciudad` varchar(15) NOT NULL,
  `estado` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `publicadores`
--

INSERT INTO `publicadores` (`id`, `nombre`, `ciudad`, `estado`) VALUES
(1, 'New Age Books', 'Boston', 'MA'),
(2, 'Binnet & Hardley', 'Washington', 'DC'),
(3, 'Algodata Infosistems', 'Berkeley', 'CA');

-- --------------------------------------------------------

--
-- Table structure for table `tiendas`
--

CREATE TABLE `tiendas` (
  `id` int(11) NOT NULL,
  `nombre` text NOT NULL,
  `codigo_postal` varchar(6) NOT NULL,
  `ciudad` varchar(15) NOT NULL,
  `estado` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tiendas`
--

INSERT INTO `tiendas` (`id`, `nombre`, `codigo_postal`, `ciudad`, `estado`) VALUES
(1, 'Barnums', '92789', 'Tustin', 'CA'),
(2, 'News & Brews', '96745', 'Los Gatos', 'CA'),
(3, 'Quality Laundry and Books', '98014', 'Remulade', 'WA'),
(4, 'Bookbeat', '89076', 'Portland', 'OR'),
(5, 'Eric the Read Books', '98056', 'Seattle', 'WA'),
(6, 'Fricative Bookshop', '90019', 'Fremont', 'CA'),
(7, 'Thoreau Reading Discount Chain', '1776', 'Concord', 'MA');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `libros`
--
ALTER TABLE `libros`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `publicadores`
--
ALTER TABLE `publicadores`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tiendas`
--
ALTER TABLE `tiendas`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `libros`
--
ALTER TABLE `libros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `publicadores`
--
ALTER TABLE `publicadores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tiendas`
--
ALTER TABLE `tiendas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;