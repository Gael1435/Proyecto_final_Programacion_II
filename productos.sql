-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-12-2024 a las 02:33:30
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
  `DESCRIPCION` text NOT NULL,
  `PRECIO` decimal(10,0) NOT NULL DEFAULT 0,
  `EXISTENCIAS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`ID`, `NOMBRE`, `IMAGEN`, `DESCRIPCION`, `PRECIO`, `EXISTENCIAS`) VALUES
(2, 'Brownie', 'brownies.png', 'Brawnie, pastel de chocolate denso y humedo', 15, 43),
(6, 'Macarrones', 'macarrones.png', 'Macarrones, postre frances, hecho de harina de almendra, claras de huevo y azucar y relleno de crema', 20, 64),
(8, 'Pastel', 'pastel.png', 'Pastel de tres leches, postre suave y esponjoso, bañado en una mezcla de leche condensada, evaporada y crema', 150, 4),
(3, 'Croissant', 'Croissant.png', 'Bollo de hojaldre en forma de media luna, de origen francés, con una textura ligera y crujiente.', 45, 24),
(4, 'CupCake', 'Cupcake.png', 'Pequeño pastel individual, dulce y horneado', 50, 26),
(5, 'Dona', 'Dona.png', 'Pieza esponjosa de repostería en forma de rosca, frita y cubierta de chocolate.', 32, 24),
(1, 'CheeseCake', 'Cheesecake.png', 'Postre frio de queso y moras!', 62, 31),
(7, 'Galletas', 'Galletas.png', 'Pasta horneada de pequeño tamaño, con chispas de chocolate.', 26, 41),
(9, 'Empanada', 'Empanada.png', 'Pasta hojaldre ligera rellena de una preparacion de piña.', 35, 40),
(10, 'Tiramisú', 'Tiramisu.png', 'Postre frio por capas de galleta con cafe y mascarpone.', 95, 22);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
