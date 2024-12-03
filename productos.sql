-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-12-2024 a las 20:44:35
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pasteleria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `ID` int(6) NOT NULL,
  `NOMBRE` varchar(25) NOT NULL,
  `IMAGEN` varchar(50) NOT NULL,
  `DESCRIPCIÓN` text NOT NULL,
  `PRECIO` decimal(10,0) NOT NULL DEFAULT 0,
  `EXISTENCIAS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`ID`, `NOMBRE`, `IMAGEN`, `DESCRIPCIÓN`, `PRECIO`, `EXISTENCIAS`) VALUES
(1, 'Arroz Con Leche', 'arrozConLeche.png', 'Arroz con leche, un postre hecho con arroz, canela y leche', 25, 33),
(2, 'Brownie', 'brownies.png', 'Brawnie, pastel de chocolate denso y humedo', 15, 43),
(4, 'ChocoFlan', 'chocoFlan.png', 'Chocoflan, postre de dos capas con pastel de chocolate y flan', 120, 7),
(5, 'Gelatina', 'gelatinaMosaicos.png', 'Gelatina de mosaicos, gelatina de leche con piezas de gelatina de diferentes sabores y colores', 60, 2),
(6, 'Macarrones', 'macarrones.png', 'Macarrones, postre frances, hecho de harina de almendra, claras de huevo y azucar y relleno de crema', 20, 64),
(7, 'Pan de Platano', 'panPlatano.png', 'Pan de platano, es un pan horneado hecho con platanos maduros', 90, 5),
(8, 'Pastel', 'pastel.png', 'Pastel de tres leches, postre suave y esponjoso, bañado en una mezcla de leche condensada, evaporada y crema', 150, 4),
(9, 'Nieve', 'nieve.png', 'Nieve, postre helado, ligero y cremoso, hecho con frutas, leche o agua, y azúcar.', 25, 156),
(10, 'Pay de Limon', 'payLimon.png', 'Pay de limon,  postre con base de galleta, relleno cremoso de limón y cubierta de merengue o crema batida.', 45, 8);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
