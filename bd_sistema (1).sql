-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/02/2025 às 15:40
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_sistema`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_carros`
--

CREATE TABLE `tb_carros` (
  `Id` int(11) NOT NULL,
  `Proprietario` varchar(150) NOT NULL,
  `Telefone` varchar(14) NOT NULL,
  `CPF` varchar(14) NOT NULL,
  `Placa` varchar(7) NOT NULL,
  `Ano` year(4) NOT NULL,
  `Chassi` varchar(17) NOT NULL,
  `Cor` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Acessorios` text NOT NULL,
  `Valor` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_carros`
--

INSERT INTO `tb_carros` (`Id`, `Proprietario`, `Telefone`, `CPF`, `Placa`, `Ano`, `Chassi`, `Cor`, `Marca`, `Modelo`, `Acessorios`, `Valor`) VALUES
(1, 'David', '(19) 98717-191', '480.844.328-77', '1111111', '2024', '11111111111111111', 'Preto', 'Teste', 'Tesla', 'Teste', 'R$   .  1.700,'),
(3, 'cadastro2', '(19) 86325-475', '480.844.328-77', 'placa01', '2020', '52025212654894564', 'magenta', 'volkswagen', 'polo', 'sei al ', 'R$   .250.000,'),
(4, 'teste', '(11) 11111-111', '480.844.328-77', '1111111', '2024', '11111111111111111', 'azul', 'ette', 'etste', 'teste', 'R$200.000.000,');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_clientes`
--

CREATE TABLE `tb_clientes` (
  `Id_Cliente` int(11) NOT NULL,
  `NomeCompleto` varchar(150) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Cep` varchar(9) NOT NULL,
  `Numero` varchar(5) NOT NULL,
  `Telefone` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`Id_Cliente`, `NomeCompleto`, `Cpf`, `Email`, `Cep`, `Numero`, `Telefone`) VALUES
(1, 'Vagner Lourenço', '1813458926', 'ilsdhfjklsfhd@klshdfklshdf', '654645', '6546', '65464'),
(6, 'David', '480.844.328-77', 'david@teste', '13473-300', '356', '(19) 98717-191'),
(7, 'testefinal', '480.844.328-77', 'teste@final', '13473-300', '55555', '(11) 11111-111');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  ADD PRIMARY KEY (`Id_Cliente`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  MODIFY `Id_Cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
