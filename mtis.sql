-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-02-2017 a las 23:07:13
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mtis`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `claveacceso`
--

CREATE TABLE `claveacceso` (
  `id` int(11) NOT NULL,
  `clave` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `claveacceso`
--

INSERT INTO `claveacceso` (`id`, `clave`) VALUES
(1, 'clave');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `codigospostales`
--

CREATE TABLE `codigospostales` (
  `id` int(3) NOT NULL,
  `codigoPostal` varchar(5) NOT NULL,
  `poblacion` varchar(50) NOT NULL,
  `provincia` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `codigospostales`
--

INSERT INTO `codigospostales` (`id`, `codigoPostal`, `poblacion`, `provincia`) VALUES
(1, '03690', 'San Vicente', 'Alicante'),
(3, '03181', 'Torrevieja', 'Alicante'),
(6, '03203', 'Elche', 'Alicante');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `piezas`
--

CREATE TABLE `piezas` (
  `id` int(3) NOT NULL,
  `idProveedor` int(3) NOT NULL,
  `referenciaPieza` varchar(5) NOT NULL,
  `precioPieza` int(4) NOT NULL,
  `disponibilidadPieza` tinyint(1) NOT NULL,
  `fechaDisponibilidad` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `piezas`
--

INSERT INTO `piezas` (`id`, `idProveedor`, `referenciaPieza`, `precioPieza`, `disponibilidadPieza`, `fechaDisponibilidad`) VALUES
(1, 1, 'aaa1', 60, 1, '2017-02-12'),
(2, 2, 'abb2', 30, 0, '2017-02-01');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `presupuestos`
--

CREATE TABLE `presupuestos` (
  `id` int(3) NOT NULL,
  `idCliente` int(3) DEFAULT NULL,
  `referenciaProducto` varchar(5) DEFAULT NULL,
  `cantidadProducto` int(3) DEFAULT NULL,
  `fechaPresupuesto` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `presupuestos`
--

INSERT INTO `presupuestos` (`id`, `idCliente`, `referenciaProducto`, `cantidadProducto`, `fechaPresupuesto`) VALUES
(1, 1, 'aaa1', 5, '2017-02-14'),
(2, 2, 'bbb2', 78, '2017-02-18');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `claveacceso`
--
ALTER TABLE `claveacceso`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `codigospostales`
--
ALTER TABLE `codigospostales`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `piezas`
--
ALTER TABLE `piezas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `claveacceso`
--
ALTER TABLE `claveacceso`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `codigospostales`
--
ALTER TABLE `codigospostales`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `piezas`
--
ALTER TABLE `piezas`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
