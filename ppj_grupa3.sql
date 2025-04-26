-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 192.168.0.10    Database: ppj_grupa3
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `artikal`
--

DROP TABLE IF EXISTS `artikal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `artikal` (
  `artikal_id` int NOT NULL AUTO_INCREMENT,
  `naziv_artikla` varchar(255) DEFAULT NULL,
  `vrsta_artikla` varchar(255) DEFAULT NULL,
  `cijena` double DEFAULT NULL,
  PRIMARY KEY (`artikal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artikal`
--

LOCK TABLES `artikal` WRITE;
/*!40000 ALTER TABLE `artikal` DISABLE KEYS */;
INSERT INTO `artikal` VALUES (1,'T-shirt','Majica',19.99),(2,'Farmerke','Pantalone',49.99),(3,'Jakna','Gornja odjeća',99.99),(4,'Haljina','Ženska odjeća',59.99),(5,'Šal','Aksesuar',12.99),(6,'Cipele','Obuća',79.99),(7,'Kaput','Zimska odjeća',129.99),(8,'Bunda','Zimska odjeća',199.99),(9,'Suknja','Ženska odjeća',39.99),(10,'Čarape','Aksesuar',5.99);
/*!40000 ALTER TABLE `artikal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kupac`
--

DROP TABLE IF EXISTS `kupac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kupac` (
  `kupac_id` int NOT NULL AUTO_INCREMENT,
  `ime` varchar(255) DEFAULT NULL,
  `prezime` varchar(255) DEFAULT NULL,
  `grad` varchar(255) DEFAULT NULL,
  `adresa` varchar(255) DEFAULT NULL,
  `telefon` varchar(255) DEFAULT NULL,
  `user` varchar(255) DEFAULT NULL,
  `pass` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`kupac_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kupac`
--

LOCK TABLES `kupac` WRITE;
/*!40000 ALTER TABLE `kupac` DISABLE KEYS */;
INSERT INTO `kupac` VALUES (1,'Marko','Marković','Sarajevo','Ul. Safeta Zajke 1','061234567','marko123','pass123'),(2,'Jovana','Jovanović','Zenica','Ul. Muje Begovića 2','062345678','jovana2024','pass456'),(3,'Nikola','Nikolić','Mostar','Ul. Kralja Petra 3','063456789','nikola123','pass789'),(4,'Amina','Aminović','Tuzla','Ul. Zelenih berbi 4','064567890','amina789','pass101'),(5,'Adnan','Adnanović','Sarajevo','Ul. Džemala Bijedića 5','065678901','adnan456','pass112'),(6,'Lejla','Lejlović','Banja Luka','Ul. Kralja Aleksandra 6','066789012','lejla2025','pass113'),(7,'Ivana','Ivanović','Bihać','Ul. Bosanske kraljice 7','067890123','ivana110','pass114'),(8,'Mirza','Mirzić','Sarajevo','Ul. Tadeusa Košćuška 8','068901234','mirza789','pass115'),(9,'Selma','Selmanović','Mostar','Ul. Šefika Džemalovića 9','069012345','selma321','pass116'),(10,'Dino','Dinić','Zenica','Ul. Tihomira Mirkovića 10','070123456','dino220','pass117');
/*!40000 ALTER TABLE `kupac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `narudzbenica`
--

DROP TABLE IF EXISTS `narudzbenica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `narudzbenica` (
  `narudzbenica_id` int NOT NULL AUTO_INCREMENT,
  `kupac_id` int DEFAULT NULL,
  `datum_narudzbe` date DEFAULT NULL,
  PRIMARY KEY (`narudzbenica_id`),
  KEY `kupac_id` (`kupac_id`),
  CONSTRAINT `narudzbenica_ibfk_1` FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `narudzbenica`
--

LOCK TABLES `narudzbenica` WRITE;
/*!40000 ALTER TABLE `narudzbenica` DISABLE KEYS */;
INSERT INTO `narudzbenica` VALUES (1,1,'2025-04-01'),(2,2,'2025-04-02'),(3,3,'2025-04-03'),(4,4,'2025-04-04'),(5,5,'2025-04-05'),(6,6,'2025-04-06'),(7,7,'2025-04-07'),(8,8,'2025-04-08'),(9,9,'2025-04-09'),(10,10,'2025-04-10');
/*!40000 ALTER TABLE `narudzbenica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `skladiste`
--

DROP TABLE IF EXISTS `skladiste`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `skladiste` (
  `id` int NOT NULL AUTO_INCREMENT,
  `artikal_id` int DEFAULT NULL,
  `kolicina_stanje` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `skladiste_ibfk_1` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `skladiste`
--

LOCK TABLES `skladiste` WRITE;
/*!40000 ALTER TABLE `skladiste` DISABLE KEYS */;
INSERT INTO `skladiste` VALUES (2,1,100),(3,2,150),(4,3,50),(5,4,80),(6,5,200),(7,6,60),(8,7,30),(9,8,20),(10,9,70),(11,10,500),(12,1,100),(13,2,150),(14,3,50),(15,4,80),(16,5,200),(17,6,60),(18,7,30),(19,8,20),(20,9,70),(21,10,500);
/*!40000 ALTER TABLE `skladiste` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stavka_narudzbenice`
--

DROP TABLE IF EXISTS `stavka_narudzbenice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int NOT NULL AUTO_INCREMENT,
  `narudzbenica_id` int DEFAULT NULL,
  `artikal_id` int DEFAULT NULL,
  `kolicina` int DEFAULT NULL,
  PRIMARY KEY (`stavka_id`),
  KEY `narudzbenica_id` (`narudzbenica_id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_1` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_2` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stavka_narudzbenice`
--

LOCK TABLES `stavka_narudzbenice` WRITE;
/*!40000 ALTER TABLE `stavka_narudzbenice` DISABLE KEYS */;
INSERT INTO `stavka_narudzbenice` VALUES (1,1,1,2),(2,1,3,1),(3,2,2,3),(4,2,4,1),(5,3,5,4),(6,3,6,2),(7,4,7,1),(8,5,8,1),(9,6,9,2),(10,7,10,3),(11,8,1,1),(12,9,3,2),(13,10,4,2),(14,10,5,1);
/*!40000 ALTER TABLE `stavka_narudzbenice` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-26 18:37:19
