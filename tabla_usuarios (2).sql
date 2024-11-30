-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2024 at 03:06 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pasteleria`
--

-- --------------------------------------------------------

--
-- Table structure for table `tabla_usuarios`
--

CREATE TABLE `tabla_usuarios` (
  `ID` int(6) NOT NULL,
  `Nombre Completo` varchar(50) NOT NULL,
  `Cuenta` varchar(50) NOT NULL,
  `Contraseña` varchar(30) NOT NULL,
  `Monto` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Tipo` enum('admin','guest','usuario') NOT NULL DEFAULT 'usuario'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabla_usuarios`
--

INSERT INTO `tabla_usuarios` (`ID`, `Nombre Completo`, `Cuenta`, `Contraseña`, `Monto`, `Tipo`) VALUES
(508462, 'Gael Emiliano Nafarrate López', 'Gael123_4', 'dulces_y_pasteles', '0.00', 'admin'),
(208963, 'Brandon Javier Becerra Davila', 'Brandon123_4', 'dulcecitos', '0.00', 'usuario'),
(409764, 'Angel Azael Fajardo Espino', 'Azael123_4', 'Pastelitos', '0.00', 'usuario'),
(308764, 'Bruno Gonzalez Castillo', 'Bruno123_4', 'Tacos', '0.00', 'usuario'),
(120984, 'Invitado', 'Guest123_$', 'Userguest', '0.00', 'guest');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
