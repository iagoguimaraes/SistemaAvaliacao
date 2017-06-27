-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: avaliacao
-- ------------------------------------------------------
-- Server version	5.7.18-log

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
-- Dumping data for table `abrangencia`
--

LOCK TABLES `abrangencia` WRITE;
/*!40000 ALTER TABLE `abrangencia` DISABLE KEYS */;
INSERT INTO `abrangencia` VALUES (1,'Satisfação fora do trabalho'),(2,'Sastisfação no trabalho');
/*!40000 ALTER TABLE `abrangencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `alternativa`
--

LOCK TABLES `alternativa` WRITE;
/*!40000 ALTER TABLE `alternativa` DISABLE KEYS */;
INSERT INTO `alternativa` VALUES (1,1,'Muito',5),(2,1,'Consideravelmente',4),(3,1,'Pouco',3),(4,1,'Muito Pouco',2),(5,1,'Nada',1),(6,2,'Muito',5),(7,2,'Consideravelmente',4),(8,2,'Pouco',3),(9,2,'Muito Pouco',2),(10,2,'Nada',1),(11,3,'Muito',5),(12,3,'Consideravelmente',4),(13,3,'Pouco',3),(14,3,'Muito Pouco',2),(15,3,'Nada',1),(16,4,'Muito',5),(17,4,'Consideravelmente',4),(18,4,'Pouco',3),(19,4,'Muito Pouco',2),(20,4,'Nada',1),(21,5,'Muito',5),(22,5,'Consideravelmente',4),(23,5,'Pouco',3),(24,5,'Muito Pouco',2),(25,5,'Nada',1),(26,6,'Muito',5),(27,6,'Consideravelmente',4),(28,6,'Pouco',3),(29,6,'Muito Pouco',2),(30,6,'Nada',1),(31,7,'Muito',5),(32,7,'Consideravelmente',4),(33,7,'Pouco',3),(34,7,'Muito Pouco',2),(35,7,'Nada',1),(36,8,'Muito',5),(37,8,'Consideravelmente',4),(38,8,'Pouco',3),(39,8,'Muito Pouco',2),(40,8,'Nada',1),(41,9,'Muito',5),(42,9,'Consideravelmente',4),(43,9,'Pouco',3),(44,9,'Muito Pouco',2),(45,9,'Nada',1),(46,10,'Muito',5),(47,10,'Consideravelmente',4),(48,10,'Pouco',3),(49,10,'Muito Pouco',2),(50,10,'Nada',1),(51,11,'Muito',5),(52,11,'Consideravelmente',4),(53,11,'Pouco',3),(54,11,'Muito Pouco',2),(55,11,'Nada',1),(56,12,'Muito',5),(57,12,'Consideravelmente',4),(58,12,'Pouco',3),(59,12,'Muito Pouco',2),(60,12,'Nada',1),(61,13,'Muito',5),(62,13,'Consideravelmente',4),(63,13,'Pouco',3),(64,13,'Muito Pouco',2),(65,13,'Nada',1),(66,14,'Muito',5),(67,14,'Consideravelmente',4),(68,14,'Pouco',3),(69,14,'Muito Pouco',2),(70,14,'Nada',1),(71,15,'Muito',5),(72,15,'Consideravelmente',4),(73,15,'Pouco',3),(74,15,'Muito Pouco',2),(75,15,'Nada',1),(76,16,'Muito',5),(77,16,'Consideravelmente',4),(78,16,'Pouco',3),(79,16,'Muito Pouco',2),(80,16,'Nada',1),(81,17,'Muito',5),(82,17,'Consideravelmente',4),(83,17,'Pouco',3),(84,17,'Muito Pouco',2),(85,17,'Nada',1),(86,18,'Muito',5),(87,18,'Consideravelmente',4),(88,18,'Pouco',3),(89,18,'Muito Pouco',2),(90,18,'Nada',1),(91,19,'Muito',5),(92,19,'Consideravelmente',4),(93,19,'Pouco',3),(94,19,'Muito Pouco',2),(95,19,'Nada',1),(96,20,'Muito',5),(97,20,'Consideravelmente',4),(98,20,'Pouco',3),(99,20,'Muito Pouco',2),(100,20,'Nada',1),(101,21,'Muito',5),(102,21,'Consideravelmente',4),(103,21,'Pouco',3),(104,21,'Muito Pouco',2),(105,21,'Nada',1),(106,22,'Muito',5),(107,22,'Consideravelmente',4),(108,22,'Pouco',3),(109,22,'Muito Pouco',2),(110,22,'Nada',1),(111,23,'Muito',5),(112,23,'Consideravelmente',4),(113,23,'Pouco',3),(114,23,'Muito Pouco',2),(115,23,'Nada',1),(116,24,'Muito',5),(117,24,'Consideravelmente',4),(118,24,'Pouco',3),(119,24,'Muito Pouco',2),(120,24,'Nada',1),(121,25,'Muito',5),(122,25,'Consideravelmente',4),(123,25,'Pouco',3),(124,25,'Muito Pouco',2),(125,25,'Nada',1),(126,26,'Muito',5),(127,26,'Consideravelmente',4),(128,26,'Pouco',3),(129,26,'Muito Pouco',2),(130,26,'Nada',1),(131,27,'Muito',5),(132,27,'Consideravelmente',4),(133,27,'Pouco',3),(134,27,'Muito Pouco',2),(135,27,'Nada',1),(136,28,'Muito',5),(137,28,'Consideravelmente',4),(138,28,'Pouco',3),(139,28,'Muito Pouco',2),(140,28,'Nada',1),(141,29,'Muito',5),(142,29,'Consideravelmente',4),(143,29,'Pouco',3),(144,29,'Muito Pouco',2),(145,29,'Nada',1),(146,30,'Muito',5),(147,30,'Consideravelmente',4),(148,30,'Pouco',3),(149,30,'Muito Pouco',2),(150,30,'Nada',1),(151,31,'Muito',5),(152,31,'Consideravelmente',4),(153,31,'Pouco',3),(154,31,'Muito Pouco',2),(155,31,'Nada',1),(156,32,'Muito',5),(157,32,'Consideravelmente',4),(158,32,'Pouco',3),(159,32,'Muito Pouco',2),(160,32,'Nada',1),(161,33,'Muito',5),(162,33,'Consideravelmente',4),(163,33,'Pouco',3),(164,33,'Muito Pouco',2),(165,33,'Nada',1),(166,34,'Muito',5),(167,34,'Consideravelmente',4),(168,34,'Pouco',3),(169,34,'Muito Pouco',2),(170,34,'Nada',1),(171,35,'Muito',5),(172,35,'Consideravelmente',4),(173,35,'Pouco',3),(174,35,'Muito Pouco',2),(175,35,'Nada',1),(176,36,'Muito',5),(177,36,'Consideravelmente',4),(178,36,'Pouco',3),(179,36,'Muito Pouco',2),(180,36,'Nada',1),(181,37,'Muito',5),(182,37,'Consideravelmente',4),(183,37,'Pouco',3),(184,37,'Muito Pouco',2),(185,37,'Nada',1),(186,38,'Muito',5),(187,38,'Consideravelmente',4),(188,38,'Pouco',3),(189,38,'Muito Pouco',2),(190,38,'Nada',1),(191,39,'Muito',5),(192,39,'Consideravelmente',4),(193,39,'Pouco',3),(194,39,'Muito Pouco',2),(195,39,'Nada',1),(196,40,'Muito',5),(197,40,'Consideravelmente',4),(198,40,'Pouco',3),(199,40,'Muito Pouco',2),(200,40,'Nada',1);
/*!40000 ALTER TABLE `alternativa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `avaliacao`
--

LOCK TABLES `avaliacao` WRITE;
/*!40000 ALTER TABLE `avaliacao` DISABLE KEYS */;
INSERT INTO `avaliacao` VALUES (1,1,1,'','2017-06-22 15:00:48',NULL,'teste');
/*!40000 ALTER TABLE `avaliacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `avaliado`
--

LOCK TABLES `avaliado` WRITE;
/*!40000 ALTER TABLE `avaliado` DISABLE KEYS */;
INSERT INTO `avaliado` VALUES (1,'Dacera','','2017-06-02 09:27:47',NULL),(2,'Iago','','2017-06-02 09:59:16',NULL);
/*!40000 ALTER TABLE `avaliado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `avaliador`
--

LOCK TABLES `avaliador` WRITE;
/*!40000 ALTER TABLE `avaliador` DISABLE KEYS */;
/*!40000 ALTER TABLE `avaliador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Auto Realização'),(2,'Estima'),(3,'Sociais'),(4,'Segurança'),(5,'Fisiológica');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `modelo`
--

LOCK TABLES `modelo` WRITE;
/*!40000 ALTER TABLE `modelo` DISABLE KEYS */;
INSERT INTO `modelo` VALUES (1,'Avaliação Motivacional Maslow','','2017-06-23 12:21:08',NULL);
/*!40000 ALTER TABLE `modelo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `questao`
--

LOCK TABLES `questao` WRITE;
/*!40000 ALTER TABLE `questao` DISABLE KEYS */;
INSERT INTO `questao` VALUES (1,1,1,1,1,'Tem se empenhado em relação a estudos, leituras, conhecimento?'),(2,1,1,1,2,'Tem se sentido satisfeito com sua religião?'),(3,1,1,1,3,'Tem se divertido e aprendendo coisas novas com prática de hobbies ou passatempos?'),(4,1,1,1,4,'Acredita que tenha se tornado uma pessoa melhor nos últimos meses?'),(5,1,1,2,5,'Tem passado tempo com sua família? '),(6,1,1,2,6,'Tem passado tempo com seus amigos? '),(7,1,1,2,7,'Acredita que as pessoas ao redor notam sua presença e suas ações?  '),(8,1,1,2,8,'Tem se sentido feliz e confortável em suas relacoes amorosas?'),(9,1,1,3,9,'Sua relação com a família é agradável?'),(10,1,1,3,10,'Tem boas amizades e de confiança?'),(11,1,1,3,11,'Consegue se relacionar com pessoas diversas?'),(12,1,1,3,12,'Gosta das pessoas da região onde mora?'),(13,1,1,4,13,'Sente livre para fazer as coisas que gosta?'),(14,1,1,4,14,'Em relação a violência, sente segurança no local onde mora?'),(15,1,1,4,15,'O local onde mora é limpo e livre de poluição?'),(16,1,1,4,16,'Tem tido atrito ou brigas violentas com outras pessoas?'),(17,1,1,5,17,'Tem tido feito boas refeições?'),(18,1,1,5,18,'Tem bebido bastante água?'),(19,1,1,5,19,'Tem tido relações sexuais?'),(20,1,1,5,20,'Tem dormido bastante?'),(21,1,2,1,21,'Considera seu trabalho desafiante?'),(22,1,2,1,22,'Tem autonomia para realizar suas tarefas no trabalho?'),(23,1,2,1,23,'Participa nas tomadas de decisão em seu trabalho?'),(24,1,2,1,4,'Tem se tornado um profissional melhor nos últimos meses?'),(25,1,2,2,24,'É reconhecido no seu trabalho?'),(26,1,2,2,25,'Assume responsabilidades importantes no seu trabalho?'),(27,1,2,2,26,'Acredita que seus pares e superiores apreciem o trabalho que tem feito ultimamente?'),(28,1,2,2,27,'Teve promoções nos ultimos meses?'),(29,1,2,3,28,'Tem feito boas amizades no trabalho?'),(30,1,2,3,29,'Considera ter bom relacionamento com clientes/fornecedores em seu trabalho?'),(31,1,2,3,30,'Considera ter bom relacionamento com seu chefe/superior?'),(32,1,2,3,31,'Considera ter bom relacionamento com colegas de trabalho?'),(33,1,2,4,32,'Se sente seguro em seu trabalho?'),(34,1,2,4,33,'Considera que recebe um salário compátivel?'),(35,1,2,4,34,'Considera que recebe bons benefícios da empresa que trabalha?'),(36,1,2,4,35,'Acredita que irá permanecer bastante tempo no trabalho?'),(37,1,2,5,36,'Seu horário de trabalho está confortável?'),(38,1,2,5,37,'Tem tido intervalo de descanso suficiente?'),(39,1,2,5,38,'Se sente confortável em seu posto de trabalho?'),(40,1,2,5,39,'A empresa atende as suas necessidades básicas?');
/*!40000 ALTER TABLE `questao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `resposta`
--

LOCK TABLES `resposta` WRITE;
/*!40000 ALTER TABLE `resposta` DISABLE KEYS */;
/*!40000 ALTER TABLE `resposta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tema`
--

LOCK TABLES `tema` WRITE;
/*!40000 ALTER TABLE `tema` DISABLE KEYS */;
INSERT INTO `tema` VALUES (1,'Educação'),(2,'Religião'),(3,'Passatempos'),(4,'Crescimento Pessoal'),(5,'Aprovação da família'),(6,'Aprovação dos amigos'),(7,'Reconhecimento da comunidade'),(8,'Afeto'),(9,'Família'),(10,'Amigos'),(11,'Grupos Sociais'),(12,'Comunidade'),(13,'Liberdade'),(14,'Segurança da violência'),(15,'Ausência de poluição'),(16,'Ausência de guerras'),(17,'Comida'),(18,'Água'),(19,'Sexo'),(20,'Sono e Repouso'),(21,'Trabalho desafiante'),(22,'Diversidade e autonomia'),(23,'Participação nas decisões'),(24,'Reconhecimento'),(25,'Responsabilidade'),(26,'Orgulho e reconhecimento'),(27,'Promoções'),(28,'Amizades dos colegas'),(29,'Interação com clientes'),(30,'Chefe amigável'),(31,'Colegas amigáveis'),(32,'Trabalho seguro'),(33,'Remuneração'),(34,'Benefícios'),(35,'Permanência no emprego'),(36,'Horário de trabalho'),(37,'Intervalo de descanso'),(38,'Conforto Físico'),(39,'Necessidades Básicas');
/*!40000 ALTER TABLE `tema` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-06-27 15:28:27
