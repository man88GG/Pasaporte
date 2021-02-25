-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-02-2021 a las 04:04:29
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `migracion`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

CREATE TABLE `aplicacion` (
  `pk_id_aplicacion` int(10) NOT NULL,
  `fk_id_modulo` int(10) NOT NULL,
  `nombre_aplicacion` varchar(40) NOT NULL,
  `descripcion_aplicacion` varchar(45) NOT NULL,
  `estado_aplicacion` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`pk_id_aplicacion`, `fk_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'Login', 'Ventana de Ingreso', 1),
(2, 1, 'Mantenimiento Usuario', 'Mantenimientos de usuario', 1),
(3, 1, 'Mantenimiento Aplicacion', 'ABC de las Aplicaciones', 1),
(4, 1, 'Mantenimiento Perfil', 'ABC de perfiles', 1),
(5, 1, 'Asignacion de Aplicaciones a Perfil', 'Asignacion Aplicacion y perfil', 1),
(6, 1, 'Asignacaion de Aplicaciones', 'Asignacion especificas a un usuario', 1),
(7, 1, 'Consulta Aplicacion', 'Mantenimiento de Aplicaciones', 1),
(8, 1, 'Agregar Modulo', 'Mantenimientos de Modulos', 1),
(9, 1, 'Consultar Perfil', 'Consultas de perfiles disponibles', 1),
(10, 1, 'Permisos', 'Asignar permisos a perfiles y aplicaciones', 1),
(11, 1, 'Bitacora', 'Guarda todos los movimientos', 1),
(12, 10, 'Gestión de Citas ', 'Gestionar Citas', 1),
(1302, 5, 'Tipo Caso', 'Tipo de casos', 1),
(1303, 5, 'Tipo Pasaporte', 'Tipo Pasaporte', 1),
(1304, 5, 'Tipo Tramite', 'Tipo Tramite', 1),
(1305, 5, 'Centro', 'Centro', 1),
(1306, 5, 'PROPIETARIO', 'PROPIETARIO', 1),
(1307, 5, 'TRANSACCIONES', 'TRANSACCIONES', 1),
(1308, 5, 'DISPONIBILIDAD DIARIA', 'REPORTE DE DISPONIBILIDAD DIARIA', 1),
(1309, 5, 'PETICION POLIZA', 'PETICION POLIZA', 1),
(1310, 5, 'CUENTAS CONTABLES', 'AGREGAR CUENTAS CONTABLES', 1),
(1311, 5, 'POLIZAS', 'POLIZAS', 1),
(1312, 5, 'LIBRO DIARIO', 'LIBRO DIARIO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_perfil`
--

CREATE TABLE `aplicacion_perfil` (
  `pk_id_aplicacion_perfil` int(10) NOT NULL,
  `fk_idaplicacion_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idperfil_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_perfil` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_perfil`
--

INSERT INTO `aplicacion_perfil` (`pk_id_aplicacion_perfil`, `fk_idaplicacion_aplicacion_perfil`, `fk_idperfil_aplicacion_perfil`, `fk_idpermiso_aplicacion_perfil`) VALUES
(1, 1, 1, 1),
(2, 4, 1, 2),
(3, 5, 1, 3),
(4, 2, 1, 4),
(5, 3, 1, 5),
(6, 6, 1, 6),
(7, 8, 1, 7),
(8, 2, 3, 8),
(9, 3, 3, 9),
(10, 4, 3, 11),
(11, 2, 4, 12),
(12, 8, 4, 13),
(13, 8, 5, 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_usuario`
--

CREATE TABLE `aplicacion_usuario` (
  `pk_id_aplicacion_usuario` int(10) NOT NULL,
  `fk_idlogin_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idaplicacion_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_usuario`
--

INSERT INTO `aplicacion_usuario` (`pk_id_aplicacion_usuario`, `fk_idlogin_aplicacion_usuario`, `fk_idaplicacion_aplicacion_usuario`, `fk_idpermiso_aplicacion_usuario`) VALUES
(1, 1, 4, 1),
(2, 1, 5, 2),
(3, 1, 6, 3),
(4, 3, 8, 10),
(5, 4, 6, 14),
(6, 5, 5, 16),
(7, 5, 2, 17),
(8, 6, 2, 1),
(9, 6, 3, 1),
(10, 6, 4, 1),
(11, 6, 6, 1),
(12, 6, 8, 1),
(13, 6, 1302, 1),
(14, 6, 1303, 1),
(15, 6, 1304, 1),
(16, 6, 1305, 1),
(17, 6, 1306, 1),
(18, 6, 12, 1),
(19, 7, 12, 19);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `pk_id_bitacora` int(10) NOT NULL,
  `fk_idusuario_bitacora` int(10) DEFAULT NULL,
  `fk_idaplicacion_bitacora` int(10) DEFAULT NULL,
  `fechahora_bitacora` varchar(50) DEFAULT NULL,
  `direccionhost_bitacora` varchar(20) DEFAULT NULL,
  `nombrehost_bitacora` varchar(20) DEFAULT NULL,
  `accion_bitacora` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`pk_id_bitacora`, `fk_idusuario_bitacora`, `fk_idaplicacion_bitacora`, `fechahora_bitacora`, `direccionhost_bitacora`, `nombrehost_bitacora`, `accion_bitacora`) VALUES
(402, 6, 1, '19/02/2021 09:03:45', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(403, 6, 2, '22/02/2021 09:03:45', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(404, 6, 1, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(405, 6, 1302, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de caso'),
(406, 6, 1303, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de pasaporte'),
(407, 6, 1304, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de tramite'),
(408, 6, 1305, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de ocupacion'),
(409, 6, 1302, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de caso'),
(410, 6, 1302, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO tipocaso VALUES ( 3,  PRUEBA,  1) '),
(411, 6, 1302, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Salir de la aplicacion'),
(412, 6, 1303, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de pasaporte'),
(413, 6, 1303, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO tipopasaporte VALUES ( 3,  prueba,  1) '),
(414, 6, 1303, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Formulario de ayuda'),
(415, 6, 2, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(416, 6, 1302, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de caso'),
(417, 6, 1302, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Formulario de ayuda'),
(418, 6, 4, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(419, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(420, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO datospersonales VALUES ( 1,  12345,  1,  Guatemala,  170,  morena,  Cafes,  1,  1,  1,  1,  3,  22/02/2021 09:25:51,  Guatemalteca,  1) '),
(421, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO programarcita VALUES ( 1,  1,  1,  2021-02-23 08:00:00,  1) '),
(422, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO historicacitas VALUES ( 1,  1) '),
(423, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO historicacitas VALUES ( 1,  1) '),
(424, 6, 4, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(425, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(426, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Modificar datos: ---- UPDATE PROGRAMARCITA SET ESTADO = 0 WHERE idProgramarCita = 1;'),
(427, 6, 12, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(428, 6, 2, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(429, 6, 2, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(430, 6, 2, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Entrega de Pasaporte'),
(431, 6, 2, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso al mantenimiento de usuarios'),
(432, 6, 2, '22/02/2021 09:21:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(433, 6, 1, '22/02/2021 12:21:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(434, 6, 1, '22/02/2021 12:23:05', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(435, 6, 1, '22/02/2021 12:23:34', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(436, 6, 1, '22/02/2021 12:42:21', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(437, 6, 1, '22/02/2021 12:45:39', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(438, 6, 1, '22/02/2021 12:56:47', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(439, 6, 1, '22/02/2021 12:58:00', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(440, 6, 1, '22/02/2021 13:07:07', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(441, 6, 1, '22/02/2021 13:07:43', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo erroneo'),
(442, 6, 1, '22/02/2021 13:07:43', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(443, 6, 1, '22/02/2021 13:08:36', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(444, 6, 1, '22/02/2021 13:14:18', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(445, 6, 1, '22/02/2021 13:16:13', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(446, 6, 1, '22/02/2021 15:54:40', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(447, 6, 2, '22/02/2021 15:54:40', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(448, 6, 2, '22/02/2021 15:54:40', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(449, 6, 2, '22/02/2021 15:54:40', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Entrega de Pasaporte'),
(450, 6, 1, '22/02/2021 16:14:29', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(451, 6, 1, '22/02/2021 16:15:09', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(452, 6, 1, '22/02/2021 16:17:45', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(453, 6, 1, '22/02/2021 16:22:51', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(454, 6, 1, '22/02/2021 16:29:46', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(455, 6, 1, '22/02/2021 16:30:36', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(456, 6, 1, '22/02/2021 16:32:59', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(457, 6, 1, '22/02/2021 16:33:33', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(458, 6, 1, '22/02/2021 16:33:55', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(459, 6, 1, '22/02/2021 16:38:32', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(460, 6, 1, '22/02/2021 16:40:52', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(461, 6, 1, '22/02/2021 17:02:40', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(462, 6, 1, '22/02/2021 17:03:57', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(463, 6, 1, '22/02/2021 17:14:49', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(464, 6, 1, '22/02/2021 17:19:39', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(465, 6, 1, '22/02/2021 17:25:29', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(466, 6, 1, '22/02/2021 17:35:42', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(467, 6, 1, '22/02/2021 17:37:45', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(468, 6, 1, '22/02/2021 17:40:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(469, 6, 1, '22/02/2021 17:41:31', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(470, 6, 1, '22/02/2021 17:44:09', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(471, 6, 1, '22/02/2021 17:45:41', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(472, 6, 1, '22/02/2021 17:46:52', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(473, 6, 1, '22/02/2021 17:52:52', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(474, 6, 1, '22/02/2021 17:58:43', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(475, 6, 1, '22/02/2021 17:59:45', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(476, 6, 1, '22/02/2021 18:03:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(477, 6, 1, '22/02/2021 18:44:58', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(478, 6, 1, '22/02/2021 18:45:56', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(479, 6, 1, '22/02/2021 18:50:21', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(480, 6, 1, '22/02/2021 18:52:15', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(481, 6, 1, '22/02/2021 18:57:04', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(482, 6, 1, '22/02/2021 19:03:45', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(483, 6, 1, '22/02/2021 19:05:32', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(484, 6, 1, '22/02/2021 19:07:45', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(485, 6, 1, '22/02/2021 19:08:30', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(486, 6, 1, '22/02/2021 19:14:16', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(487, 6, 1, '22/02/2021 20:17:55', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(488, 6, 1, '22/02/2021 20:33:40', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(489, 6, 1, '22/02/2021 20:37:51', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(490, 6, 1, '22/02/2021 20:39:25', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(491, 6, 1, '22/02/2021 20:41:11', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(492, 6, 1, '22/02/2021 20:43:56', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(493, 6, 1, '22/02/2021 20:47:44', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(494, 6, 1, '22/02/2021 20:48:38', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(495, 6, 1, '22/02/2021 20:54:57', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(496, 6, 1, '22/02/2021 20:55:42', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(497, 6, 1, '22/02/2021 21:00:09', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(498, 6, 1, '23/02/2021 17:36:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(499, 6, 1, '23/02/2021 17:39:05', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(500, 6, 1, '23/02/2021 17:52:14', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(501, 6, 1, '23/02/2021 17:53:22', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(502, 6, 1, '23/02/2021 17:55:41', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(503, 6, 1, '23/02/2021 18:13:07', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(504, 6, 1, '23/02/2021 18:13:55', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(505, 6, 1, '23/02/2021 18:15:19', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(506, 6, 1, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(507, 6, 2, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(508, 6, 2, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Entrega de Pasaporte'),
(509, 7, 1, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(510, 7, 2, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Trato de ingresar a la aplicacion centro'),
(511, 7, 4, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(512, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(513, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO datospersonales VALUES ( 2,  54321,  1,  Guatemala,  170,  moreno,  cafes,  1,  1,  1,  1,  5,  23/02/2021 18:22:09,  Guatemalteca,  1) '),
(514, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO programarcita VALUES ( 2,  2,  1,  2021-02-24 08:00:00,  1) '),
(515, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO historicacitas VALUES ( 2,  2) '),
(516, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO historicacitas VALUES ( 2,  2) '),
(517, 7, 4, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(518, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(519, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(520, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Modificar datos: ---- UPDATE PROGRAMARCITA SET ESTADO = 0 WHERE idProgramarCita = 2;'),
(521, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(522, 7, 4, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(523, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(524, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(525, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(526, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Modificar datos: ---- UPDATE DATOSPERSONALES SET ESTADO = 0 WHERE idDatosPersonales = 1;'),
(527, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(528, 7, 12, '23/02/2021 18:17:53', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(529, 6, 1, '23/02/2021 18:51:28', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(530, 6, 1302, '23/02/2021 18:51:28', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de caso'),
(531, 6, 1, '24/02/2021 08:33:32', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(532, 6, 2, '24/02/2021 08:33:32', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(533, 6, 2, '24/02/2021 08:33:32', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(534, 6, 2, '24/02/2021 08:33:32', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(535, 6, 2, '24/02/2021 08:33:32', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Entrega de Pasaporte'),
(536, 6, 1, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(537, 6, 1302, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de caso'),
(538, 6, 1303, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de pasaporte'),
(539, 6, 1303, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de pasaporte'),
(540, 6, 1304, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de tramite'),
(541, 6, 1305, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de ocupacion'),
(542, 6, 1305, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Formulario de ayuda'),
(543, 6, 2, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(544, 6, 2, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(545, 6, 2, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(546, 6, 2, '24/02/2021 09:54:03', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Entrega de Pasaporte'),
(547, 6, 1, '24/02/2021 13:42:06', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(548, 6, 1302, '24/02/2021 13:42:06', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de caso'),
(549, 6, 1303, '24/02/2021 13:42:06', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de pasaporte'),
(550, 6, 1305, '24/02/2021 13:42:06', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de ocupacion'),
(551, 6, 1, '24/02/2021 13:46:40', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(552, 6, 1, '24/02/2021 13:47:20', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(553, 6, 4, '24/02/2021 13:47:20', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(554, 6, 2, '24/02/2021 13:47:20', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(555, 6, 2, '24/02/2021 13:47:20', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(556, 6, 1, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(557, 6, 1302, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de caso'),
(558, 6, 1302, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO tipocaso VALUES ( 4,  PruebaVideo,  1) '),
(559, 6, 1302, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Salir de la aplicacion'),
(560, 6, 1303, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de pasaporte'),
(561, 6, 1303, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO tipopasaporte VALUES ( 4,  PruebaVideo,  1) '),
(562, 6, 1303, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Salir de la aplicacion'),
(563, 6, 1304, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de tramite'),
(564, 6, 1304, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO tipotramite VALUES ( 4,  PruebaVideo,  1) '),
(565, 6, 1305, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la aplicacion Tipo de ocupacion'),
(566, 6, 4, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(567, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(568, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(569, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO datospersonales VALUES ( 1,  5,  1,  Guatemala,  170,  blanca,  azules,  2,  1,  1,  1,  4,  24/02/2021 14:54:45,  Guatemalteca,  1) '),
(570, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO programarcita VALUES ( 1,  1,  1,  2021-02-25 08:00:00,  1) '),
(571, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO historicacitas VALUES ( 1,  1) '),
(572, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', ' INSERT INTO historicacitas VALUES ( 1,  1) '),
(573, 6, 4, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(574, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(575, 6, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario'),
(576, 6, 2, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a creacion de Pasaporte'),
(577, 6, 2, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Renovación/Vencimiento de Pasaporte'),
(578, 6, 2, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a Entrega de Pasaporte'),
(579, 6, 2, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso al mantenimiento de usuarios'),
(580, 6, 6, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la asignacion de aplicaciones'),
(581, 7, 1, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(582, 7, 1302, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Trato de ingresar a la aplicacion tipo de caso'),
(583, 7, 1304, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Trato de ingresar a la aplicacion tipo de tramite'),
(584, 7, 4, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(585, 7, 12, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Gestionar cita'),
(586, 7, 2, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Trato de ingresar a crear un nuevo Pasaporte'),
(587, 7, 2, '24/02/2021 14:52:17', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Trato de ingresar a la aplicacion centro'),
(588, 6, 1, '24/02/2021 15:18:15', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Logeo Exitoso'),
(589, 6, 4, '24/02/2021 15:18:15', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Ingreso a la apliacion de Gestion de citas'),
(590, 6, 12, '24/02/2021 15:18:15', 'fdb4:f58e:1300:1d00:', 'DESKTOP-7VFVMJ5', 'Validacion de boleta - Buscar Cita o usuario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boletabanco`
--

CREATE TABLE `boletabanco` (
  `idBoleta` int(11) NOT NULL,
  `numeroRecibo` int(11) DEFAULT NULL,
  `numeroBoleta` int(11) DEFAULT NULL,
  `fechaEmision` datetime DEFAULT NULL,
  `estatus` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `boletabanco`
--

INSERT INTO `boletabanco` (`idBoleta`, `numeroRecibo`, `numeroBoleta`, `fechaEmision`, `estatus`) VALUES
(1, 111, 111, '2021-02-09 15:27:14', 1),
(2, 222, 222, '2021-02-09 15:27:14', 1),
(3, 333, 333, '2021-02-09 15:27:14', 1),
(4, 444, 444, '2021-02-09 15:27:14', 1),
(5, 555, 555, '2021-02-01 14:35:08', 1),
(6, 666, 666, '2021-02-01 14:35:08', 1),
(7, 777, 777, '0000-00-00 00:00:00', 1),
(8, 888, 888, '0000-00-00 00:00:00', 1),
(9, 999, 999, '0000-00-00 00:00:00', 1),
(10, 122, 122, '0000-00-00 00:00:00', 1),
(11, 133, 133, '0000-00-00 00:00:00', 1),
(12, 144, 144, '0000-00-00 00:00:00', 1),
(13, 155, 155, '0000-00-00 00:00:00', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boletoornato`
--

CREATE TABLE `boletoornato` (
  `idBoletoOrnato` int(11) NOT NULL,
  `fechaEmision` datetime DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `centrocita`
--

CREATE TABLE `centrocita` (
  `idCentroCita` int(11) NOT NULL,
  `nombreCentro` varchar(85) DEFAULT NULL,
  `idMunicipio` int(11) DEFAULT NULL,
  `direccion` varchar(85) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `centrocita`
--

INSERT INTO `centrocita` (`idCentroCita`, `nombreCentro`, `idMunicipio`, `direccion`, `estado`) VALUES
(1, 'Central', 1, 'Zona 4', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `correo`
--

CREATE TABLE `correo` (
  `idCorreo` int(11) NOT NULL,
  `correo` varchar(85) DEFAULT NULL,
  `idCliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datospersonales`
--

CREATE TABLE `datospersonales` (
  `idDatosPersonales` int(11) NOT NULL,
  `dpi` int(11) DEFAULT NULL,
  `idMunicipio` int(11) DEFAULT NULL,
  `direccionResidencia` varchar(85) DEFAULT NULL,
  `altura` double DEFAULT NULL,
  `tez` varchar(45) DEFAULT NULL,
  `ojos` varchar(45) DEFAULT NULL,
  `idOcupacion` int(11) DEFAULT NULL,
  `idTipoTramite` int(11) DEFAULT NULL,
  `idTipoPasaporte` int(11) DEFAULT NULL,
  `idTipoCaso` int(11) DEFAULT NULL,
  `idBoletaBanco` int(11) DEFAULT NULL,
  `fechaCreacion` varchar(45) DEFAULT NULL,
  `nacionalidad` varchar(55) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `datospersonales`
--

INSERT INTO `datospersonales` (`idDatosPersonales`, `dpi`, `idMunicipio`, `direccionResidencia`, `altura`, `tez`, `ojos`, `idOcupacion`, `idTipoTramite`, `idTipoPasaporte`, `idTipoCaso`, `idBoletaBanco`, `fechaCreacion`, `nacionalidad`, `estado`) VALUES
(1, 5, 1, 'Guatemala', 170, 'blanca', 'azules', 2, 1, 1, 1, 4, '24/02/2021 14:54:45', 'Guatemalteca', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `idDepartamento` int(11) NOT NULL,
  `departamento` varchar(45) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`idDepartamento`, `departamento`, `estado`) VALUES
(1, 'Guatemala', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entregapasaporte`
--

CREATE TABLE `entregapasaporte` (
  `idEntregaPasaporte` int(11) NOT NULL,
  `idPasaporte` int(11) DEFAULT NULL,
  `fechaEntrega` varchar(45) DEFAULT NULL,
  `estatusEntrega` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `entregapasaporte`
--

INSERT INTO `entregapasaporte` (`idEntregaPasaporte`, `idPasaporte`, `fechaEntrega`, `estatusEntrega`) VALUES
(1, 3, '24/02/2021', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historicacitas`
--

CREATE TABLE `historicacitas` (
  `idHistorica` int(11) NOT NULL,
  `idProgramarCita` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `historicacitas`
--

INSERT INTO `historicacitas` (`idHistorica`, `idProgramarCita`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historicopasaporte`
--

CREATE TABLE `historicopasaporte` (
  `idHistoricoPasaporte` int(11) NOT NULL,
  `idPasaporte` int(11) DEFAULT NULL,
  `fecha` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `historicopasaporte`
--

INSERT INTO `historicopasaporte` (`idHistoricoPasaporte`, `idPasaporte`, `fecha`) VALUES
(1, 3, '24/02/2021');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `pk_id_login` int(10) NOT NULL,
  `usuario_login` varchar(45) DEFAULT NULL,
  `contraseña_login` varchar(45) DEFAULT NULL,
  `nombreCompleto_login` varchar(100) DEFAULT NULL,
  `estado_login` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`pk_id_login`, `usuario_login`, `contraseña_login`, `nombreCompleto_login`, `estado_login`) VALUES
(1, 'sistema', 'bi0PL96rbxVRPKJQsLJJAg==', 'Usuario de prueba', 1),
(2, 'bjsican', '0FOYy5u5h0djKjzCYqfvkg==', 'Billy Sican', 1),
(3, 'bmaza', 'xTfsC3/XR/CVyDvNr1Fs+g==', 'Bryan Mazariegos', 1),
(4, 'jsican', 'jsican', 'Jeshua Sican', 0),
(5, 'jmorataya', '123', 'Julio Morataya', 0),
(6, 'JLOPEZ', 'LwUsihMe9Bl//D/5WaIzLA==', 'JOSE LOPEZ', 1),
(7, 'cliente', '21LRuDS2GcjNgOcK8q54Aw==', 'Usuario para clientes', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE `modulo` (
  `pk_id_modulo` int(10) NOT NULL,
  `nombre_modulo` varchar(30) NOT NULL,
  `descripcion_modulo` varchar(50) NOT NULL,
  `estado_modulo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`pk_id_modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'Seguridad', 'Aplicaciones de seguridad', 1),
(2, 'Consultas', 'Consultas Inteligentes', 1),
(3, 'Reporteador', 'Aplicaciones de Reporteador', 1),
(4, 'HRM', 'Aplicaciones de Recursos Humanos', 1),
(5, 'FRM', 'Aplicaciones de Finanzas', 1),
(6, 'SCM', 'Aplicaciones Control de Inventario', 1),
(7, 'MRP', 'Aplicaciones de Produccion', 1),
(8, 'CRM', 'Aplicaciones de Ventas', 1),
(9, 'PRUEBA', 'PRUEBA', 1),
(10, 'Gestión de Citas', 'En este modulo se pueden gestionar las citas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `municipio`
--

CREATE TABLE `municipio` (
  `idMunicipio` int(11) NOT NULL,
  `municipio` varchar(45) DEFAULT NULL,
  `idDepartamento` int(11) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `municipio`
--

INSERT INTO `municipio` (`idMunicipio`, `municipio`, `idDepartamento`, `estado`) VALUES
(1, 'Guatemala', 1, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ocupacion`
--

CREATE TABLE `ocupacion` (
  `idOcupacion` int(11) NOT NULL,
  `ocupacion` varchar(105) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ocupacion`
--

INSERT INTO `ocupacion` (`idOcupacion`, `ocupacion`, `estado`) VALUES
(1, 'Ingeniero en sistema', '1'),
(2, 'Abogado Comercial', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pasaporte`
--

CREATE TABLE `pasaporte` (
  `idPasaporte` int(11) NOT NULL,
  `numeroPasaporte` int(11) DEFAULT NULL,
  `numeroLibreta` varchar(45) DEFAULT NULL,
  `dpi` int(11) DEFAULT NULL,
  `fechaCreacion` varchar(45) DEFAULT NULL,
  `fechaVencimiento` varchar(45) DEFAULT NULL,
  `idTipoPasaporte` int(11) DEFAULT NULL,
  `lugarNacimiento` varchar(105) DEFAULT NULL,
  `fotografia` varchar(250) DEFAULT NULL,
  `autoridad` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pasaporte`
--

INSERT INTO `pasaporte` (`idPasaporte`, `numeroPasaporte`, `numeroLibreta`, `dpi`, `fechaCreacion`, `fechaVencimiento`, `idTipoPasaporte`, `lugarNacimiento`, `fotografia`, `autoridad`, `estado`) VALUES
(1, 100, 'L100', 1, '24/02/2021', '24/02/2021', 1, 'Guatemala', 'https://cdn.discordapp.com/attachments/804515217538285619/813164168419999804/husky-siberiano-bosque.png', 'Sub-Director', 1),
(2, 200, 'L200', 1, '24/02/2021', '24/02/2021', 1, 'Guatemala', 'https://cdn.discordapp.com/attachments/804515217538285619/813164168419999804/husky-siberiano-bosque.png', 'Sub-Director', 1),
(3, 300, 'L300', 5, '24/02/2021', '24/02/2021', 1, 'Guatemala', 'https://cdn.discordapp.com/attachments/804515217538285619/814144218075234414/images.png', 'Sub-Director', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `pk_id_perfil` int(10) NOT NULL,
  `nombre_perfil` varchar(50) DEFAULT NULL,
  `descripcion_perfil` varchar(100) DEFAULT NULL,
  `estado_perfil` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'Admin', 'Administracion del programa', 1),
(2, 'Sistema', 'Administrador del sistema', 1),
(3, 'Digitador', 'Digitador para Cuentas', 1),
(4, 'Consultor', 'Unicamente consultas ', 1),
(5, 'Reportes', 'Ingreso y consultas de reportes', 1),
(6, 'Pruebas', 'pruebas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_usuario`
--

CREATE TABLE `perfil_usuario` (
  `pk_id_perfil_usuario` int(10) NOT NULL,
  `fk_idusuario_perfil_usuario` int(10) DEFAULT NULL,
  `fk_idperfil_perfil_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil_usuario`
--

INSERT INTO `perfil_usuario` (`pk_id_perfil_usuario`, `fk_idusuario_perfil_usuario`, `fk_idperfil_perfil_usuario`) VALUES
(2, 3, 3),
(4, 4, 1),
(5, 5, 5),
(6, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permiso`
--

CREATE TABLE `permiso` (
  `pk_id_permiso` int(10) NOT NULL,
  `insertar_permiso` tinyint(1) DEFAULT NULL,
  `modificar_permiso` tinyint(1) DEFAULT NULL,
  `eliminar_permiso` tinyint(1) DEFAULT NULL,
  `consultar_permiso` tinyint(1) DEFAULT NULL,
  `imprimir_permiso` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `permiso`
--

INSERT INTO `permiso` (`pk_id_permiso`, `insertar_permiso`, `modificar_permiso`, `eliminar_permiso`, `consultar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1, 1, 1, 1),
(2, 1, 0, 0, 1, 1),
(3, 1, 1, 1, 0, 0),
(4, 1, 1, 1, 1, 1),
(5, 1, 1, 1, 1, 1),
(6, 1, 1, 1, 1, 1),
(7, 1, 1, 1, 1, 1),
(8, 1, 0, 1, 0, 0),
(9, 1, 1, 0, 0, 0),
(10, 1, 1, 0, 0, 0),
(11, 1, 1, 1, 1, 1),
(12, 0, 0, 0, 1, 0),
(13, 0, 0, 0, 1, 0),
(14, 0, 0, 0, 0, 0),
(15, 1, 0, 0, 1, 0),
(16, 0, 0, 0, 0, 0),
(17, 1, 1, 0, 0, 0),
(18, 0, 0, 0, 0, 0),
(19, 0, 0, 0, 0, 0),
(20, 0, 0, 0, 0, 0),
(21, 0, 0, 0, 0, 0),
(22, 0, 0, 0, 0, 0),
(23, 0, 0, 0, 0, 0),
(24, 0, 0, 0, 0, 0),
(25, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programarcita`
--

CREATE TABLE `programarcita` (
  `idProgramarCita` int(11) NOT NULL,
  `idDatosPersonales` int(11) DEFAULT NULL,
  `idCentro` int(11) DEFAULT NULL,
  `fechaParaCita` datetime DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `programarcita`
--

INSERT INTO `programarcita` (`idProgramarCita`, `idDatosPersonales`, `idCentro`, `fechaParaCita`, `estado`) VALUES
(1, 1, 1, '2021-02-25 08:00:00', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `renap`
--

CREATE TABLE `renap` (
  `dpi` int(11) NOT NULL,
  `nombres` varchar(85) DEFAULT NULL,
  `apellidos` varchar(85) DEFAULT NULL,
  `fechaNacimiento` datetime DEFAULT NULL,
  `estadoCivil` varchar(25) DEFAULT NULL,
  `sexo` varchar(25) DEFAULT NULL,
  `idMunicipio` int(11) DEFAULT NULL,
  `nacionalidad` varchar(55) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `renap`
--

INSERT INTO `renap` (`dpi`, `nombres`, `apellidos`, `fechaNacimiento`, `estadoCivil`, `sexo`, `idMunicipio`, `nacionalidad`, `estado`) VALUES
(1, 'Jose Estanislao ', 'Lopez Tubac', '1999-03-18 23:11:16', 'Soltero', 'Masculino', 1, 'Guatemalteca', '1'),
(2, 'Manuel', 'Garcia', '2021-02-01 15:01:04', 'Soltero', 'Masculino', 1, 'Guatemalteca', '1'),
(3, 'Sergio', 'Orozco', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(4, 'Antonio', 'Garcia', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(5, 'Jose', 'Martinez', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(6, 'Francisco', 'Lopez', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(7, 'Manuel', 'Gonzales', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(8, 'Pedro', 'Gomez', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(9, 'Miguel', 'Jimenez', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(10, 'Javier', 'Perez', '2021-02-02 00:00:00', 'Soltero', 'Masculino', 1, 'Guatemalteco', '1'),
(11, 'Maria', 'Garcia', '2021-02-02 00:00:00', 'Soltera', 'Femenino', 1, 'Guatemalteca', '1'),
(12, 'Maria Carmen', 'Martinez', '2021-02-02 00:00:00', 'Soltera', 'Femenino', 1, 'Guatemalteca', '1'),
(13, 'Josefa', 'Lopez', '2021-02-02 00:00:00', 'Soltera', 'Femenino', 1, 'Guatemalteca', '1'),
(14, 'Isabel', 'Sanchez', '2021-02-02 00:00:00', 'Soltera', 'Femenino', 1, 'Guatemalteca', '1'),
(15, 'Dolores', 'Navarro', '2021-02-02 00:00:00', 'Soltera', 'Femenino', 1, 'Guatemalteca', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefono`
--

CREATE TABLE `telefono` (
  `idTelefono` int(11) NOT NULL,
  `telefono` int(11) DEFAULT NULL,
  `idCliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipocaso`
--

CREATE TABLE `tipocaso` (
  `idTipoCaso` int(11) NOT NULL,
  `tipoCaso` varchar(105) DEFAULT NULL,
  `estado` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipocaso`
--

INSERT INTO `tipocaso` (`idTipoCaso`, `tipoCaso`, `estado`) VALUES
(1, 'Mayor de edad', 1),
(2, 'Menor de edad', 1),
(3, 'PRUEBA', 1),
(4, 'PruebaVideo', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipopasaporte`
--

CREATE TABLE `tipopasaporte` (
  `idTipoPasaporte` int(11) NOT NULL,
  `tipoPasaporte` varchar(45) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipopasaporte`
--

INSERT INTO `tipopasaporte` (`idTipoPasaporte`, `tipoPasaporte`, `estado`) VALUES
(1, 'Ordinario', '1'),
(2, 'Diplomatico', '1'),
(3, 'prueba', '1'),
(4, 'PruebaVideo', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipotramite`
--

CREATE TABLE `tipotramite` (
  `idTipoTramite` int(11) NOT NULL,
  `nombreTipoTramite` varchar(45) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipotramite`
--

INSERT INTO `tipotramite` (`idTipoTramite`, `nombreTipoTramite`, `estado`) VALUES
(1, 'Primer Pasaporte', '1'),
(2, 'Renovacion', '1'),
(3, 'Emergencia', '1'),
(4, 'PruebaVideo', '1');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`pk_id_aplicacion`),
  ADD KEY `pk_id_aplicacion` (`pk_id_aplicacion`),
  ADD KEY `fk_aplicacion_modulo` (`fk_id_modulo`);

--
-- Indices de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD PRIMARY KEY (`pk_id_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_aplicacion` (`fk_idaplicacion_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_perfil` (`fk_idperfil_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_permiso` (`fk_idpermiso_aplicacion_perfil`);

--
-- Indices de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD PRIMARY KEY (`pk_id_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_login` (`fk_idlogin_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_aplicacion` (`fk_idaplicacion_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_permiso` (`fk_idpermiso_aplicacion_usuario`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`pk_id_bitacora`);

--
-- Indices de la tabla `boletabanco`
--
ALTER TABLE `boletabanco`
  ADD PRIMARY KEY (`idBoleta`);

--
-- Indices de la tabla `boletoornato`
--
ALTER TABLE `boletoornato`
  ADD PRIMARY KEY (`idBoletoOrnato`);

--
-- Indices de la tabla `centrocita`
--
ALTER TABLE `centrocita`
  ADD PRIMARY KEY (`idCentroCita`),
  ADD KEY `fk_centroMuni` (`idMunicipio`);

--
-- Indices de la tabla `correo`
--
ALTER TABLE `correo`
  ADD PRIMARY KEY (`idCorreo`),
  ADD KEY `fk_correodatos` (`idCliente`);

--
-- Indices de la tabla `datospersonales`
--
ALTER TABLE `datospersonales`
  ADD PRIMARY KEY (`idDatosPersonales`),
  ADD KEY `fk_datosDpi` (`dpi`),
  ADD KEY `fk_datosmunicipio` (`idMunicipio`),
  ADD KEY `fk_datosocupacion` (`idOcupacion`),
  ADD KEY `fk_datosTipoTram` (`idTipoTramite`),
  ADD KEY `fk_datosTipoPass` (`idTipoPasaporte`),
  ADD KEY `fk_datosTipoCaso` (`idTipoCaso`),
  ADD KEY `fk_datosBoletaBanco` (`idBoletaBanco`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`idDepartamento`);

--
-- Indices de la tabla `entregapasaporte`
--
ALTER TABLE `entregapasaporte`
  ADD PRIMARY KEY (`idEntregaPasaporte`),
  ADD KEY `fk_entregapass` (`idPasaporte`);

--
-- Indices de la tabla `historicacitas`
--
ALTER TABLE `historicacitas`
  ADD PRIMARY KEY (`idHistorica`),
  ADD KEY `fk_historicacitaadd` (`idProgramarCita`);

--
-- Indices de la tabla `historicopasaporte`
--
ALTER TABLE `historicopasaporte`
  ADD PRIMARY KEY (`idHistoricoPasaporte`),
  ADD KEY `fk_historicopass` (`idPasaporte`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`pk_id_login`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
  ADD PRIMARY KEY (`pk_id_modulo`),
  ADD KEY `pk_id_modulo` (`pk_id_modulo`);

--
-- Indices de la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD PRIMARY KEY (`idMunicipio`),
  ADD KEY `fk_muniDepart` (`idDepartamento`);

--
-- Indices de la tabla `ocupacion`
--
ALTER TABLE `ocupacion`
  ADD PRIMARY KEY (`idOcupacion`);

--
-- Indices de la tabla `pasaporte`
--
ALTER TABLE `pasaporte`
  ADD PRIMARY KEY (`idPasaporte`),
  ADD KEY `fk_passdpi` (`dpi`),
  ADD KEY `fk_passtipopass` (`idTipoPasaporte`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`pk_id_perfil`);

--
-- Indices de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD PRIMARY KEY (`pk_id_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_login` (`fk_idusuario_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_perfil` (`fk_idperfil_perfil_usuario`);

--
-- Indices de la tabla `permiso`
--
ALTER TABLE `permiso`
  ADD PRIMARY KEY (`pk_id_permiso`);

--
-- Indices de la tabla `programarcita`
--
ALTER TABLE `programarcita`
  ADD PRIMARY KEY (`idProgramarCita`),
  ADD KEY `fk_addcitadatos` (`idDatosPersonales`),
  ADD KEY `fk_addcitacentro` (`idCentro`);

--
-- Indices de la tabla `renap`
--
ALTER TABLE `renap`
  ADD PRIMARY KEY (`dpi`),
  ADD KEY `fk_renapmuni` (`idMunicipio`);

--
-- Indices de la tabla `telefono`
--
ALTER TABLE `telefono`
  ADD PRIMARY KEY (`idTelefono`),
  ADD KEY `fk_telefonodatos` (`idCliente`);

--
-- Indices de la tabla `tipocaso`
--
ALTER TABLE `tipocaso`
  ADD PRIMARY KEY (`idTipoCaso`);

--
-- Indices de la tabla `tipopasaporte`
--
ALTER TABLE `tipopasaporte`
  ADD PRIMARY KEY (`idTipoPasaporte`);

--
-- Indices de la tabla `tipotramite`
--
ALTER TABLE `tipotramite`
  ADD PRIMARY KEY (`idTipoTramite`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `pk_id_aplicacion` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1313;

--
-- AUTO_INCREMENT de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  MODIFY `pk_id_aplicacion_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  MODIFY `pk_id_aplicacion_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `pk_id_bitacora` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=591;

--
-- AUTO_INCREMENT de la tabla `login`
--
ALTER TABLE `login`
  MODIFY `pk_id_login` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `modulo`
--
ALTER TABLE `modulo`
  MODIFY `pk_id_modulo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `pk_id_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  MODIFY `pk_id_perfil_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `permiso`
--
ALTER TABLE `permiso`
  MODIFY `pk_id_permiso` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD CONSTRAINT `fk_aplicacion_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`);

--
-- Filtros para la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD CONSTRAINT `fk_aplicacionperfil_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_perfil`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_perfil` FOREIGN KEY (`fk_idperfil_aplicacion_perfil`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_perfil`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD CONSTRAINT `fk_aplicacionusuario_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_usuario`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_login` FOREIGN KEY (`fk_idlogin_aplicacion_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_usuario`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `centrocita`
--
ALTER TABLE `centrocita`
  ADD CONSTRAINT `fk_centroMuni` FOREIGN KEY (`idMunicipio`) REFERENCES `municipio` (`idMunicipio`);

--
-- Filtros para la tabla `correo`
--
ALTER TABLE `correo`
  ADD CONSTRAINT `fk_correodatos` FOREIGN KEY (`idCliente`) REFERENCES `datospersonales` (`dpi`);

--
-- Filtros para la tabla `datospersonales`
--
ALTER TABLE `datospersonales`
  ADD CONSTRAINT `fk_datosBoletaBanco` FOREIGN KEY (`idBoletaBanco`) REFERENCES `boletabanco` (`idBoleta`),
  ADD CONSTRAINT `fk_datosDpi` FOREIGN KEY (`dpi`) REFERENCES `renap` (`dpi`),
  ADD CONSTRAINT `fk_datosTipoCaso` FOREIGN KEY (`idTipoCaso`) REFERENCES `tipocaso` (`idTipoCaso`),
  ADD CONSTRAINT `fk_datosTipoPass` FOREIGN KEY (`idTipoPasaporte`) REFERENCES `tipopasaporte` (`idTipoPasaporte`),
  ADD CONSTRAINT `fk_datosTipoTram` FOREIGN KEY (`idTipoTramite`) REFERENCES `tipotramite` (`idTipoTramite`),
  ADD CONSTRAINT `fk_datosmunicipio` FOREIGN KEY (`idMunicipio`) REFERENCES `municipio` (`idMunicipio`),
  ADD CONSTRAINT `fk_datosocupacion` FOREIGN KEY (`idOcupacion`) REFERENCES `ocupacion` (`idOcupacion`);

--
-- Filtros para la tabla `entregapasaporte`
--
ALTER TABLE `entregapasaporte`
  ADD CONSTRAINT `fk_entregapass` FOREIGN KEY (`idPasaporte`) REFERENCES `pasaporte` (`idPasaporte`);

--
-- Filtros para la tabla `historicacitas`
--
ALTER TABLE `historicacitas`
  ADD CONSTRAINT `fk_historicacitaadd` FOREIGN KEY (`idProgramarCita`) REFERENCES `programarcita` (`idProgramarCita`);

--
-- Filtros para la tabla `historicopasaporte`
--
ALTER TABLE `historicopasaporte`
  ADD CONSTRAINT `fk_historicopass` FOREIGN KEY (`idPasaporte`) REFERENCES `pasaporte` (`idPasaporte`);

--
-- Filtros para la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD CONSTRAINT `fk_muniDepart` FOREIGN KEY (`idDepartamento`) REFERENCES `departamento` (`idDepartamento`);

--
-- Filtros para la tabla `pasaporte`
--
ALTER TABLE `pasaporte`
  ADD CONSTRAINT `fk_passdpi` FOREIGN KEY (`dpi`) REFERENCES `renap` (`dpi`),
  ADD CONSTRAINT `fk_passtipopass` FOREIGN KEY (`idTipoPasaporte`) REFERENCES `tipopasaporte` (`idTipoPasaporte`);

--
-- Filtros para la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD CONSTRAINT `fk_perfil_usuario_login` FOREIGN KEY (`fk_idusuario_perfil_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_perfil_usuario_perfil` FOREIGN KEY (`fk_idperfil_perfil_usuario`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `programarcita`
--
ALTER TABLE `programarcita`
  ADD CONSTRAINT `fk_addcitacentro` FOREIGN KEY (`idCentro`) REFERENCES `centrocita` (`idCentroCita`),
  ADD CONSTRAINT `fk_addcitadatos` FOREIGN KEY (`idDatosPersonales`) REFERENCES `datospersonales` (`idDatosPersonales`);

--
-- Filtros para la tabla `renap`
--
ALTER TABLE `renap`
  ADD CONSTRAINT `fk_renapmuni` FOREIGN KEY (`idMunicipio`) REFERENCES `municipio` (`idMunicipio`);

--
-- Filtros para la tabla `telefono`
--
ALTER TABLE `telefono`
  ADD CONSTRAINT `fk_telefonodatos` FOREIGN KEY (`idCliente`) REFERENCES `datospersonales` (`dpi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
