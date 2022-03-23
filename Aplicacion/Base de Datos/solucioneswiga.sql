-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-03-2022 a las 19:48:54
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `solucioneswiga`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idClientes` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idClientes`, `nombre`) VALUES
(1, 'Camila Martínez'),
(2, 'Claudia Guarin'),
(3, 'Isabel Ospina'),
(4, 'Laura Ramirez'),
(5, 'Luisa Gil'),
(6, 'Matias Salazar'),
(7, 'Sebastian Lopez');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_factura`
--

CREATE TABLE `detalle_factura` (
  `num_detalle` int(11) NOT NULL,
  `numero_factura_fk` int(11) NOT NULL,
  `id_producto_fk` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `detalle_factura`
--

INSERT INTO `detalle_factura` (`num_detalle`, `numero_factura_fk`, `id_producto_fk`, `cantidad`) VALUES
(1, 1005, 1, 2),
(2, 1006, 2, 3),
(3, 1003, 3, 2),
(4, 1004, 4, 4),
(5, 1011, 5, 10),
(6, 1012, 6, 3),
(7, 1001, 7, 5),
(8, 1009, 8, 2),
(9, 1010, 9, 1),
(10, 1002, 10, 10),
(11, 1008, 12, 1),
(12, 1007, 11, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `numero` int(11) NOT NULL,
  `fecha_compra` date NOT NULL,
  `id_cliente_fk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`numero`, `fecha_compra`, `id_cliente_fk`) VALUES
(1001, '2015-12-07', 4),
(1002, '2016-04-22', 6),
(1003, '2018-01-01', 2),
(1004, '2019-02-05', 2),
(1005, '2019-05-01', 1),
(1006, '2019-07-03', 1),
(1007, '2020-08-07', 7),
(1008, '2020-11-22', 7),
(1009, '2021-06-01', 5),
(1010, '2021-06-01', 5),
(1011, '2022-03-02', 3),
(1012, '2022-03-03', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `id_producto` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `precio` decimal(8,2) NOT NULL,
  `stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id_producto`, `nombre`, `precio`, `stock`) VALUES
(1, 'Cuaderno', '10000.00', 4),
(2, 'Borrador', '3000.00', 6),
(3, 'Bafles', '100000.00', 4),
(4, 'Audifonos', '25000.00', 8),
(5, 'Camiseta', '200000.00', 20),
(6, 'Pantalon', '235900.00', 5),
(7, 'Foco', '15000.00', 10),
(8, 'Video Beam', '305000.00', 4),
(9, 'Celular', '900000.00', 2),
(10, 'Termo', '58350.00', 15),
(11, 'Locion', '70000.00', 4),
(12, 'Desodorante', '90000.00', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idClientes`);

--
-- Indices de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD PRIMARY KEY (`num_detalle`),
  ADD KEY `numero_factura_fk` (`numero_factura_fk`),
  ADD KEY `id_producto_fk` (`id_producto_fk`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `id_cliente_fk` (`id_cliente_fk`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id_producto`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD CONSTRAINT `detalle_factura_ibfk_1` FOREIGN KEY (`numero_factura_fk`) REFERENCES `factura` (`numero`),
  ADD CONSTRAINT `detalle_factura_ibfk_2` FOREIGN KEY (`id_producto_fk`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `factura_ibfk_1` FOREIGN KEY (`id_cliente_fk`) REFERENCES `cliente` (`idClientes`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
