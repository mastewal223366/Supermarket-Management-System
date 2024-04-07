-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 10, 2023 at 09:11 AM
-- Server version: 8.0.31
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `supermarket`
--

-- --------------------------------------------------------

--
-- Table structure for table `brand`
--

DROP TABLE IF EXISTS `brand`;
CREATE TABLE IF NOT EXISTS `brand` (
  `bId` int NOT NULL AUTO_INCREMENT,
  `brandName` varchar(50) NOT NULL,
  PRIMARY KEY (`bId`),
  UNIQUE KEY `brandName` (`brandName`),
  UNIQUE KEY `brandName_2` (`brandName`)
) ENGINE=InnoDB AUTO_INCREMENT=209 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `brand`
--

INSERT INTO `brand` (`bId`, `brandName`) VALUES
(204, 'beka breads'),
(202, 'Farm Fresh'),
(203, 'haila mik'),
(207, 'M and M Chicken'),
(205, 'martha drinks'),
(206, 'martha meats'),
(208, 'Sholla Milk');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
CREATE TABLE IF NOT EXISTS `categories` (
  `id` int NOT NULL AUTO_INCREMENT,
  `catName` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `catName` (`catName`),
  UNIQUE KEY `catName_2` (`catName`)
) ENGINE=InnoDB AUTO_INCREMENT=140 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `catName`) VALUES
(137, 'Bakery'),
(138, 'Beverage'),
(136, 'Dairy'),
(135, 'Fruits'),
(139, 'Meat');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE IF NOT EXISTS `product` (
  `pId` int NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `Quantity` int NOT NULL,
  `price` double NOT NULL,
  `BrandId` int DEFAULT NULL,
  `CategoriesId` int DEFAULT NULL,
  PRIMARY KEY (`pId`),
  KEY `BrandId` (`BrandId`,`CategoriesId`) USING BTREE,
  KEY `CategoriesId` (`CategoriesId`)
) ENGINE=InnoDB AUTO_INCREMENT=282 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`pId`, `ProductName`, `Quantity`, `price`, `BrandId`, `CategoriesId`) VALUES
(274, 'Apple', 50, 10, 202, 135),
(275, 'Milk', 100, 900, 203, 136),
(276, 'White Bread', 100, 10, 204, 137),
(277, 'Cola', 10, 40, 205, 138),
(278, 'Chicken Breast', 4, 500, 206, 139),
(279, 'Eggs', 30, 11, 204, 136),
(280, 'Chicken Breast ', 250, 400, 207, 136),
(281, 'Milk', 240, 50, 208, 136);

-- --------------------------------------------------------

--
-- Table structure for table `product_supplier`
--

DROP TABLE IF EXISTS `product_supplier`;
CREATE TABLE IF NOT EXISTS `product_supplier` (
  `spId` int NOT NULL AUTO_INCREMENT,
  `sId` int DEFAULT NULL,
  `pId` int DEFAULT NULL,
  `price` double NOT NULL,
  `suppliedQuantity` int NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`spId`),
  KEY `pId` (`pId`),
  KEY `sId` (`sId`,`pId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=407 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `product_supplier`
--

INSERT INTO `product_supplier` (`spId`, `sId`, `pId`, `price`, `suppliedQuantity`, `date`) VALUES
(397, 118, 274, 10, 100, '2023-06-01'),
(398, 119, 275, 900, 100, '2023-06-10'),
(399, 120, 276, 10, 100, '2023-06-08'),
(400, 118, 274, 10, 100, '2023-06-10'),
(401, 121, 277, 40, 10, '2023-06-08'),
(402, 121, 278, 500, 2, '2023-06-02'),
(403, 121, 278, 500, 2, '2023-06-10'),
(404, 122, 279, 11, 300, '2023-05-30'),
(405, 123, 280, 400, 250, '2023-07-08'),
(406, 124, 281, 50, 240, '2023-06-10');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
CREATE TABLE IF NOT EXISTS `supplier` (
  `sId` int NOT NULL AUTO_INCREMENT,
  `sName` varchar(50) NOT NULL,
  `contactPhoneNumberr` varchar(13) NOT NULL,
  PRIMARY KEY (`sId`),
  UNIQUE KEY `sName` (`sName`)
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`sId`, `sName`, `contactPhoneNumberr`) VALUES
(118, 'Abenezer apple plc', ''),
(119, 'Haile milk plc', ''),
(120, 'Bereket Fast Bread plc', ''),
(121, 'Martha  marta', ''),
(122, 'Genesis Farm', ''),
(123, 'M and M Chicken', ''),
(124, 'Sholla Milk PLC', '');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
CREATE TABLE IF NOT EXISTS `transaction` (
  `tId` int NOT NULL AUTO_INCREMENT,
  `uId` int NOT NULL,
  `pId` int NOT NULL,
  `Quantity` int NOT NULL,
  `tDate` date NOT NULL,
  `Price` double(10,3) NOT NULL,
  `total` double(10,3) NOT NULL,
  PRIMARY KEY (`tId`),
  KEY `pId` (`pId`) USING BTREE,
  KEY `uId` (`uId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`tId`, `uId`, `pId`, `Quantity`, `tDate`, `Price`, `total`) VALUES
(22, 36, 274, 150, '2023-06-10', 10.000, 1500.000);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `uId` int NOT NULL AUTO_INCREMENT,
  `username` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `password` varchar(5) NOT NULL,
  `role` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'Cashier',
  `FirstName` varchar(50) NOT NULL,
  `SecondName` varchar(50) NOT NULL,
  `PhoneNumber` varchar(13) NOT NULL,
  `RegistrationDate` date NOT NULL,
  `Sex` varchar(6) NOT NULL,
  PRIMARY KEY (`uId`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`uId`, `username`, `password`, `role`, `FirstName`, `SecondName`, `PhoneNumber`, `RegistrationDate`, `Sex`) VALUES
(1, 'maste', '2233', 'Admin', 'mastewal', 'Yaregal', '0925597699', '2023-06-26', 'male'),
(36, 'miki', '2233', 'Cashier', 'Miki', 'Tekalgn', '+251908976543', '2023-06-09', 'Male');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`CategoriesId`) REFERENCES `categories` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`BrandId`) REFERENCES `brand` (`bId`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `product_supplier`
--
ALTER TABLE `product_supplier`
  ADD CONSTRAINT `product_supplier_ibfk_1` FOREIGN KEY (`sId`) REFERENCES `supplier` (`sId`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `product_supplier_ibfk_2` FOREIGN KEY (`pId`) REFERENCES `product` (`pId`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`uId`) REFERENCES `users` (`uId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`pId`) REFERENCES `product` (`pId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
