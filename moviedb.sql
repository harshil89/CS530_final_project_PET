CREATE DATABASE  IF NOT EXISTS `moviedb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `moviedb`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: moviedb
-- ------------------------------------------------------
-- Server version	5.5.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `history_list`
--

DROP TABLE IF EXISTS `history_list`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `history_list` (
  `history_list_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `movie_id` int(11) NOT NULL,
  `year` year(4) NOT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`history_list_id`),
  UNIQUE KEY `UQ_KEY` (`movie_id`,`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `history_list`
--

LOCK TABLES `history_list` WRITE;
/*!40000 ALTER TABLE `history_list` DISABLE KEYS */;
INSERT INTO `history_list` VALUES (1,1,2015,1),(2,6,2016,1),(3,3,2016,1),(6,3,2016,2),(8,4,2016,2);
/*!40000 ALTER TABLE `history_list` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movies`
--

DROP TABLE IF EXISTS `movies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movies` (
  `movie_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `year` year(4) NOT NULL,
  `language` varchar(64) NOT NULL,
  `runtime` int(11) DEFAULT NULL,
  `type` char(16) DEFAULT NULL,
  PRIMARY KEY (`movie_id`),
  UNIQUE KEY `title_UNIQUE` (`title`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movies`
--

LOCK TABLES `movies` WRITE;
/*!40000 ALTER TABLE `movies` DISABLE KEYS */;
INSERT INTO `movies` VALUES (1,'The Shawshank Redemption',1994,'English',142,'movie'),(2,'The Godfather',1972,'English',175,'movie'),(3,'The Godfather: Part II',1974,'English',202,'movie'),(4,'The Dark Knight',2008,'English',152,'movie'),(5,'Schindler\'s List',1993,'English',195,'movie'),(6,'Rick and Morty',2013,'English',22,'tv show'),(7,'Band of Brothers',2001,'English',70,'tv show'),(14,'12 Angry Men',1957,'English',96,'movie'),(15,'Pulp Fiction',1999,'English',154,'movie'),(16,'The Lord of the Rings: The Return of the King',2003,'English',201,'movie'),(17,'The Good, the Bad and the Ugly',1966,'English',161,'movie'),(18,'Fight Club',1999,'English',139,'movie'),(19,'Breaking Bad',2008,'English',49,'tv show');
/*!40000 ALTER TABLE `movies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movies_wishlist`
--

DROP TABLE IF EXISTS `movies_wishlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movies_wishlist` (
  `movies_wishlist_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `wishlist_id` int(11) NOT NULL,
  `movie_id` int(11) NOT NULL,
  PRIMARY KEY (`movies_wishlist_id`),
  UNIQUE KEY `UQ_key` (`wishlist_id`,`movie_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movies_wishlist`
--

LOCK TABLES `movies_wishlist` WRITE;
/*!40000 ALTER TABLE `movies_wishlist` DISABLE KEYS */;
INSERT INTO `movies_wishlist` VALUES (1,1,2),(2,1,5),(7,2,1),(14,2,2),(3,2,3),(13,2,4),(8,2,6),(4,4,4),(9,4,6),(5,5,2),(6,6,5),(10,7,5),(11,8,4),(12,9,1),(15,10,2);
/*!40000 ALTER TABLE `movies_wishlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `series`
--

DROP TABLE IF EXISTS `series`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `series` (
  `series_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `movie_id` int(11) NOT NULL,
  `name_of_episode` varchar(255) NOT NULL,
  `season` int(11) NOT NULL,
  `episode_num` int(11) NOT NULL,
  PRIMARY KEY (`series_id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `series`
--

LOCK TABLES `series` WRITE;
/*!40000 ALTER TABLE `series` DISABLE KEYS */;
INSERT INTO `series` VALUES (1,7,'Currahee',1,1),(2,7,'Day of Days',1,2),(3,7,'Carentan',1,3),(4,7,'Replacements',1,4),(5,7,'Crossroads',1,5),(6,7,'Bastogne',1,6),(7,7,'The Breaking Point',1,7),(8,7,'The Last Patrol',1,8),(9,7,'Why We Fight',1,9),(10,7,'Points',1,10),(11,6,'Pilot',1,1),(12,6,'Lawnmower Dog',1,2),(13,6,'Anatomy Park',1,3),(14,6,'M. Night Shaym-Aliens!',1,4),(15,6,'Meeseeks and Destroy',1,5),(16,6,'A Rickle in Time',2,1),(17,6,'Mortynight Run',2,2),(18,6,'Auto Erotic Assimilation',2,3),(19,6,'Total Rickall',2,4),(20,6,'Get Schwifty',2,5),(31,19,'Pilot',1,1),(32,19,'Cat\'s in the Bag...',1,2),(33,19,'...And the Bag\'s in the River',1,3),(34,19,'Cancer Man',1,4),(35,19,'Gray Matter',1,5),(36,19,'Seven Thirty-Seven',2,1),(37,19,'Grilled',2,2),(38,19,'Bit by a Dead Bee',2,3),(39,19,'Down',2,4),(40,19,'Breakage',2,5);
/*!40000 ALTER TABLE `series` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `user_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL,
  `first_name` varchar(64) NOT NULL,
  `last_name` varchar(64) NOT NULL,
  `email` varchar(80) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'harshil89','password01','Harshil','Desai','harudesi@gmail.com'),(2,'harudesi','password02','haru','desi','hd85@gmail.com');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wishlist`
--

DROP TABLE IF EXISTS `wishlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wishlist` (
  `wishlist_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `wishlist_name` varchar(128) NOT NULL,
  PRIMARY KEY (`wishlist_id`),
  UNIQUE KEY `Unique_Key` (`user_id`,`wishlist_name`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wishlist`
--

LOCK TABLES `wishlist` WRITE;
/*!40000 ALTER TABLE `wishlist` DISABLE KEYS */;
INSERT INTO `wishlist` VALUES (8,1,'fav1'),(9,1,'fav2'),(1,1,'my favourite'),(7,1,'my favourite 1'),(2,2,'fav1'),(4,2,'fav2'),(5,2,'fav3'),(6,2,'fav4'),(10,2,'fav5');
/*!40000 ALTER TABLE `wishlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'moviedb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-06-01 19:04:03
