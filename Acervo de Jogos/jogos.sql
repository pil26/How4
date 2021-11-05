-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 03-Out-2021 às 18:12
-- Versão do servidor: 10.4.20-MariaDB
-- versão do PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `acervo jogos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `jogos`
--

CREATE TABLE `jogos` (
  `Cod` int(11) NOT NULL,
  `NomeJogo` varchar(100) NOT NULL,
  `CategoriaJogo` varchar(50) NOT NULL,
  `PlataformaJogo` varchar(50) NOT NULL,
  `Midia` varchar(10) NOT NULL,
  `ValorJogo` decimal(11,2) NOT NULL,
  `CondicaoJogo` varchar(11) NOT NULL,
  `DataCompra` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `jogos`
--

INSERT INTO `jogos` (`Cod`, `NomeJogo`, `CategoriaJogo`, `PlataformaJogo`, `Midia`, `ValorJogo`, `CondicaoJogo`, `DataCompra`) VALUES
(1, 'Super Mario World', 'Aventura/Plataforma', 'Super Nintendo', 'Cartucho', '50.00', 'Usado', '2014-08-04'),
(2, 'Final Fantasy 6', 'RPG', 'Super Nintendo', 'Cartucho', '180.00', 'Usado', '2016-02-02'),
(3, 'Super Mario Bros 3', 'Aventura/Plataforma', 'NES', 'Cartucho', '70.00', 'Usado', '2016-05-03'),
(5, 'MoonWalker', 'Aventura/Plataforma', 'Master System', 'Cartucho', '20.00', 'Usado', '2018-08-01'),
(6, 'Ninja Gaiden', 'Aventura/Plataforma', 'Master System', 'Cartucho', '20.00', 'Usado', '2018-08-01'),
(22, 'Super Metroid', 'Aventura/Plataforma', 'Super Nintendo', 'Cartucho', '130.00', 'Usado', '2016-02-20'),
(24, 'Splatterhouse', 'Ação/Hack n Slash', 'PS3', 'Blu Ray', '189.00', 'Novo', '2021-08-05'),
(25, '3d Dot Game Heroes', 'Aventura', 'PS3', 'Blu Ray', '150.00', 'Novo', '2018-06-10'),
(26, 'Sega Genesis Classic', 'Aventura/Plataforma', 'PS4', 'Blu Ray', '169.00', 'Novo', '2020-05-23'),
(27, 'Bloodstained', 'Ação/Plataforma', 'PS4', 'Blu Ray', '179.00', 'Novo', '2020-06-06'),
(28, 'Darksiders 3', 'Hack n Slash', 'PS4', 'Blu Ray', '78.00', 'Novo', '2020-07-07'),
(29, 'Darksiders 1', 'Hack n Slash', 'PS4', 'Blu Ray', '79.00', 'Novo', '2020-07-07'),
(44, 'Tony Hawks Pro Skater 1 + 2', 'Esporte', 'PS4', 'Blu Ray', '315.00', 'Novo', '2020-12-24'),
(45, 'Contra Rogue Cops', 'Ação', 'PS4', 'Blu Ray', '69.00', 'Novo', '2020-09-09');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `jogos`
--
ALTER TABLE `jogos`
  ADD UNIQUE KEY `CodJogo` (`Cod`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `jogos`
--
ALTER TABLE `jogos`
  MODIFY `Cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
