CREATE DATABASE IF NOT EXISTS `varosikozlekedes` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `varosikozlekedes`;

CREATE TABLE `jegyrendszer` (
  `alapdij` int(11),
  `tavolsag` int(11), 
  `jegytipus` text
)

INSERT INTO `jegyrendszer` (`alapdij`, `tavolsag`, `jegytipus`) VALUES
(450, 5, 'vonalbusz'),
(450, 12, 'vonalbusz'),
(450, 25, 'gyorsvonat'),
(450, 42, 'gyorsvonat'),
(NULL, 3, 'elektromos roller'),
(NULL, 7, 'elektromos roller');

