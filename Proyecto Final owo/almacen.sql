-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-11-2020 a las 06:44:00
-- Versión del servidor: 10.4.14-MariaDB
-- Versión de PHP: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `almacen`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cardiologia`
--

CREATE TABLE `cardiologia` (
  `Numero_identificacion` int(100) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Numero_serie` varchar(100) NOT NULL,
  `Ubicacion` varchar(100) NOT NULL,
  `Estatus` varchar(100) NOT NULL,
  `Departamento` varchar(100) NOT NULL,
  `Funcionamiento` varchar(125) NOT NULL,
  `Riesgo` varchar(125) NOT NULL,
  `Cantidad_refacciones` varchar(100) NOT NULL,
  `Accesorios` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cardiologia`
--

INSERT INTO `cardiologia` (`Numero_identificacion`, `Descripcion`, `Modelo`, `Marca`, `Numero_serie`, `Ubicacion`, `Estatus`, `Departamento`, `Funcionamiento`, `Riesgo`, `Cantidad_refacciones`, `Accesorios`) VALUES
(2, 'Maquina de ECG', 'Draguer-567', 'Draguer', '1234', 'Area 4 serie 2', 'Funcional', 'Cardiologia', 'Equipo de diagnostico y tratamiento ', 'Alto', '5', 'ninguno');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `imagenologia`
--

CREATE TABLE `imagenologia` (
  `Numero_identificacion` int(100) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Numero_serie` varchar(100) NOT NULL,
  `Ubicacion` varchar(100) NOT NULL,
  `Estatus` varchar(100) NOT NULL,
  `Departamento` varchar(100) NOT NULL,
  `Funcionamiento` varchar(125) NOT NULL,
  `Riesgo` varchar(125) NOT NULL,
  `Cantidad_refacciones` varchar(100) NOT NULL,
  `Accesorios` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `imagenologia`
--

INSERT INTO `imagenologia` (`Numero_identificacion`, `Descripcion`, `Modelo`, `Marca`, `Numero_serie`, `Ubicacion`, `Estatus`, `Departamento`, `Funcionamiento`, `Riesgo`, `Cantidad_refacciones`, `Accesorios`) VALUES
(1, 'Mesa quirurgica electrica', 'HEA-HOI897', 'HealthHome', 'MC-5678943', 'Área 3, sección 1', 'No funcional ', 'Imagenología', 'Equipo de tratamiento y diagnostico ', 'Minimo ', '4', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingresar`
--

CREATE TABLE `ingresar` (
  `ID` int(100) NOT NULL,
  `Usuario` varchar(100) NOT NULL,
  `Clave` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ingresar`
--

INSERT INTO `ingresar` (`ID`, `Usuario`, `Clave`) VALUES
(1, 'Ramos Grecia', '1234'),
(2, 'García Alexa', '1234'),
(3, 'Salmerón Athos', '1234');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pediatria`
--

CREATE TABLE `pediatria` (
  `Numero_identificacion` int(100) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Numero_serie` varchar(100) NOT NULL,
  `Ubicacion` varchar(100) NOT NULL,
  `Estatus` varchar(100) NOT NULL,
  `Departamento` varchar(100) NOT NULL,
  `Funcionamiento` varchar(125) NOT NULL,
  `Riesgo` varchar(125) NOT NULL,
  `Cantidad_refacciones` varchar(100) NOT NULL,
  `Accesorios` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pediatria`
--

INSERT INTO `pediatria` (`Numero_identificacion`, `Descripcion`, `Modelo`, `Marca`, `Numero_serie`, `Ubicacion`, `Estatus`, `Departamento`, `Funcionamiento`, `Riesgo`, `Cantidad_refacciones`, `Accesorios`) VALUES
(5, 'Mesa de exploración pediátrica con bascula', 'MID-640-001-843', 'Midmark', '640001843', 'Área 2, sección 1', 'No funcional ', 'Pediatría', 'Equipo de tratamiento ', 'Minimo', '4', 'Bascula'),
(6, 'Estuche de diagnostico Pocket ', 'WEA-POCKELED', 'Weich Allyn ', 'DP-09876', 'Área 2, sección 2', 'Funcional ', 'Pediatría ', 'Equipo de diagnostico ', 'Terapia inapropiada o falso diagnostico ', '4', 'Bombillos LED con tecnología SureColor.\r\nEl otoscopio y oftalmoscopio mas livianos para mayor comodidad y control.\r\nInterruptor de filtro polarizador de densidad neutral, que ayuda a reducir casi en su totalidad el reflejo de la córnea.\r\nDescanso de goma '),
(7, 'Bacinete para bebé', 'PAI-02069PA', 'PARI', 'BB02069', 'Área 2, sección 1', 'No funcional ', 'Pediatría', 'Equipo de tratamiento ', 'Minimo ', '6', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trauma_ortopedia`
--

CREATE TABLE `trauma_ortopedia` (
  `Numero_Identificacion` int(100) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Numero_serie` varchar(100) NOT NULL,
  `Ubicacion` varchar(100) NOT NULL,
  `Estatus` varchar(100) NOT NULL,
  `Departamento` varchar(100) NOT NULL,
  `Funcionamiento` varchar(125) NOT NULL,
  `Riesgo` varchar(125) NOT NULL,
  `Cantidad_refacciones` varchar(100) NOT NULL,
  `Accesorios` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `trauma_ortopedia`
--

INSERT INTO `trauma_ortopedia` (`Numero_Identificacion`, `Descripcion`, `Modelo`, `Marca`, `Numero_serie`, `Ubicacion`, `Estatus`, `Departamento`, `Funcionamiento`, `Riesgo`, `Cantidad_refacciones`, `Accesorios`) VALUES
(3, 'Mesa de cirugía general eléctrica ', 'HEA-HW503B', 'HealthHome', 'MQ-5030', 'Área 1, sección 2', 'No funcional ', 'Traumatología y ortopedia ', 'Equipos de tratamiento y mantenimiento de la vida', 'Minimo', '6', 'Arco de anestesia con fijador\r\nSoporte acojinado para brazo con fijador (2 piezas)\r\nPierneras acojinadas articuladas tipo goepel con fijador (2 piezas)\r\nSoporte de cabeza (1 pieza)\r\nSoportes laterales acojinados con fijadores (2 piezas)'),
(4, 'Densitómetro ', 'HOG-HORIZON-WI', 'Hologic', 'DSM-01019', 'Área 1, sección 2', 'No funcional ', 'Traumatología y ortopedia ', 'Equipo de diagnostico y tratamiento ', 'Minimo ', '6', 'Tecnología DEXA de Fan-Beam avanzada\r\nTécnica de adquisición de un solo paso OnePass™; escaneo por medio de arreglo de detectores múltiples\r\nNuevo detector GadOx Puls (GPDS) de 64 elementos, digital de alta resolución\r\nNuevo generador de Rayos X de alta f');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cardiologia`
--
ALTER TABLE `cardiologia`
  ADD PRIMARY KEY (`Numero_identificacion`);

--
-- Indices de la tabla `imagenologia`
--
ALTER TABLE `imagenologia`
  ADD PRIMARY KEY (`Numero_identificacion`);

--
-- Indices de la tabla `ingresar`
--
ALTER TABLE `ingresar`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `pediatria`
--
ALTER TABLE `pediatria`
  ADD PRIMARY KEY (`Numero_identificacion`);

--
-- Indices de la tabla `trauma_ortopedia`
--
ALTER TABLE `trauma_ortopedia`
  ADD PRIMARY KEY (`Numero_Identificacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cardiologia`
--
ALTER TABLE `cardiologia`
  MODIFY `Numero_identificacion` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `imagenologia`
--
ALTER TABLE `imagenologia`
  MODIFY `Numero_identificacion` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `ingresar`
--
ALTER TABLE `ingresar`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `pediatria`
--
ALTER TABLE `pediatria`
  MODIFY `Numero_identificacion` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `trauma_ortopedia`
--
ALTER TABLE `trauma_ortopedia`
  MODIFY `Numero_Identificacion` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
