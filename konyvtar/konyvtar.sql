-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Nov 23. 12:22
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `konyvtar`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `konyvek`
--

CREATE TABLE `konyvek` (
  `id` int(8) NOT NULL,
  `cim` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `kolcsonzo` int(8) DEFAULT NULL,
  `lejarat` varchar(11) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `konyvek`
--

INSERT INTO `konyvek` (`id`, `cim`, `kolcsonzo`, `lejarat`) VALUES
(1, 'narnia', 7, '2021.12.17.'),
(2, 'Matematikai Függvények', 6, '2022.12.12.'),
(3, 'Peppa Malac manga', 7, '2021.12.17.'),
(4, 'Initial C - A beavatás', 5, '2021.12.04.'),
(5, 'HSZC Návay Lajos Szakgimnázium Házirend', NULL, NULL),
(6, 'Menzás Szakácskönyv', NULL, NULL),
(7, 'Légszűrő Magazin - 2021/3', 1, '2021.12.17.'),
(9, 'mysql alapok kezdőknek tippek és trükkök meg kuki', 1, '2021.12.17.'),
(10, 'excel kezdőknek', 3, '2021.12.03.'),
(11, 'matek', 5, '2021.12.17.'),
(12, 'Magyarorsz6ág Alaptörvényeh', 7, '2021.12.17.');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tagok`
--

CREATE TABLE `tagok` (
  `id` int(8) NOT NULL,
  `nev` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `lakcim` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `telefon` bigint(11) DEFAULT NULL,
  `email` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `tagok`
--

INSERT INTO `tagok` (`id`, `nev`, `lakcim`, `telefon`, `email`) VALUES
(1, 'Laci', '6969 Románia Avenue 18.', 36304455966, 'danonino@keri.mako.hu'),
(2, 'Mario', '6931 Apátfalva Rákóczi u. 19.', 36302299788, 'parfumarus@keri.mako.hu'),
(3, 'Pablo', '6931 Apátfalva Rákóczi u. 23.', 36302297788, 'ember@keri.mako.hu'),
(4, 'Alfonzo', '6931 Apátfalva Rákóczi u. 19.', 36302211788, 'alfonzo.racz@index.hu'),
(5, 'Jamal', '1203 Gyöngyös Duranda negyed u. 20.', 36302239788, 'jamal.amir@mail.af.gov'),
(6, 'Muhammad', '1203 Gyöngyös Duranda negyed u. 21.', 36302299712, 'jamal.amir@mail.af.gov'),
(7, 'Mutahar', '1203 Gyöngyös Duranda negyed u. 22.', 36302291231, 'mutahar.anas@canadamail.ca'),
(8, 'Lacika', '6900 Makó honvéd utca', 36301356428, 'jbl@mako.hu');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `konyvek`
--
ALTER TABLE `konyvek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kolcsonzo` (`kolcsonzo`);

--
-- A tábla indexei `tagok`
--
ALTER TABLE `tagok`
  ADD PRIMARY KEY (`id`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `konyvek`
--
ALTER TABLE `konyvek`
  ADD CONSTRAINT `konyvek_ibfk_1` FOREIGN KEY (`kolcsonzo`) REFERENCES `tagok` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
