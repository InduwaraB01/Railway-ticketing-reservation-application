/*
SQLyog Community v13.2.1 (64 bit)
MySQL - 5.5.25a : Database - trainsystem
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`trainsystem` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `trainsystem`;

/*Table structure for table `adminlogin` */

DROP TABLE IF EXISTS `adminlogin`;

CREATE TABLE `adminlogin` (
  `adminusername` varchar(30) DEFAULT NULL,
  `adminpassword` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `adminlogin` */

insert  into `adminlogin`(`adminusername`,`adminpassword`) values 
('admin','admin123');

/*Table structure for table `cusdetailstbl` */

DROP TABLE IF EXISTS `cusdetailstbl`;

CREATE TABLE `cusdetailstbl` (
  `cusNIC` varchar(12) NOT NULL,
  `cusName` varchar(50) DEFAULT NULL,
  `cusAdd` varchar(200) DEFAULT NULL,
  `contact` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`cusNIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `cusdetailstbl` */

insert  into `cusdetailstbl`(`cusNIC`,`cusName`,`cusAdd`,`contact`) values 
('123456789000','Kalum','Galle;\r\nGalle','(071) 425-5555'),
('222222222222','saman','no333','(099) 999-9999'),
('333333333333','saman','eeeeeeee','(093) 333-3333'),
('816554255657','Yasiru','Matara\r\nMatara','(071) 458-5645');

/*Table structure for table `logintbl` */

DROP TABLE IF EXISTS `logintbl`;

CREATE TABLE `logintbl` (
  `userName` varchar(12) NOT NULL,
  `password` varchar(15) DEFAULT NULL,
  `cusNIC` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`userName`),
  KEY `FK_logintbl` (`cusNIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `logintbl` */

insert  into `logintbl`(`userName`,`password`,`cusNIC`) values 
('kalum','789','123456789000'),
('saaman','saaman','333333333333'),
('user2','user2','373737'),
('Yasi','123','816554255657');

/*Table structure for table `newuserdetailstbl` */

DROP TABLE IF EXISTS `newuserdetailstbl`;

CREATE TABLE `newuserdetailstbl` (
  `name` varchar(30) DEFAULT NULL,
  `contactNumber` varchar(30) DEFAULT NULL,
  `birthdate` varchar(20) DEFAULT NULL,
  `Gender` varchar(30) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `newuserdetailstbl` */

insert  into `newuserdetailstbl`(`name`,`contactNumber`,`birthdate`,`Gender`,`email`) values 
('222','333333333333','2024-03-10 17:54:05','Male','ssssssss'),
('hellooo11','0882726','2019-05-18 16:01:25','Male','dfdfdffs'),
('hellooo11','0882726','2019-05-18 16:01:25','Male','dfdfdffs'),
('induwara','08727227727','2024-03-11 09:04:17','Male','wgshshss');

/*Table structure for table `route` */

DROP TABLE IF EXISTS `route`;

CREATE TABLE `route` (
  `routeNo` int(11) NOT NULL,
  `routeName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`routeNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `route` */

insert  into `route`(`routeNo`,`routeName`) values 
(1,'Colombo - Kandy'),
(2,'Colombo - Galle'),
(3,'Colombo - Jaffna'),
(4,'Colombo - Anuradhapura'),
(5,'Galle - Matara');

/*Table structure for table `station` */

DROP TABLE IF EXISTS `station`;

CREATE TABLE `station` (
  `stationID` decimal(10,0) NOT NULL,
  `stationName` varchar(50) DEFAULT NULL,
  `routs` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`stationID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `station` */

insert  into `station`(`stationID`,`stationName`,`routs`) values 
(1,'Colombo','4,2,3,1,'),
(2,'Galle','2,5,'),
(6,'matara','5,');

/*Table structure for table `ticketprice` */

DROP TABLE IF EXISTS `ticketprice`;

CREATE TABLE `ticketprice` (
  `sStation` varchar(50) DEFAULT NULL,
  `tStation` varchar(50) DEFAULT NULL,
  `price` float DEFAULT NULL,
  `sclass` int(11) DEFAULT NULL,
  `priceID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`priceID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `ticketprice` */

insert  into `ticketprice`(`sStation`,`tStation`,`price`,`sclass`,`priceID`) values 
('Colombo','Galle',2100,1,1);

/*Table structure for table `train` */

DROP TABLE IF EXISTS `train`;

CREATE TABLE `train` (
  `tScheduleID` int(11) DEFAULT NULL,
  `tName` varchar(25) DEFAULT NULL,
  `sStation` varchar(50) DEFAULT NULL,
  `dStation` varchar(50) DEFAULT NULL,
  `FSeatcount` int(11) DEFAULT NULL,
  `SSeatcount` int(11) DEFAULT NULL,
  `tRoute` varchar(100) DEFAULT NULL,
  `sTime` varchar(50) DEFAULT NULL,
  `sDate` varchar(100) DEFAULT NULL,
  `tDirection` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `train` */

insert  into `train`(`tScheduleID`,`tName`,`sStation`,`dStation`,`FSeatcount`,`SSeatcount`,`tRoute`,`sTime`,`sDate`,`tDirection`) values 
(1,'Train1','Colombo','Galle',50,100,'Colombo - Galle','2:45:09 PM','Thursday, March 14, 2024',NULL),
(2,'Train2','Colombo','Galle',50,100,'Colombo - Galle','4:52:09 PM','Thursday, March 14, 2024',NULL),
(5,'train6','Colombo','Galle',50,10,'2','10:41:20 AM','Wednesday, April 17, 2024','DOWN'),
(8,'ruhunu','matara','Colombo',60,65,'3','7:30:33 AM','Saturday, March 30, 2024','UP'),
(21,'t003','Galle','matara',22,33,'5','6:44:34 AM','Monday, April 1, 2024','DOWN'),
(8,'ruhunu kumari','Colombo','matara',100,100,'2','12:40:24 AM','Sunday, March 31, 2024','DOWN'),
(0,'express','Galle','matara',88,55,'3','8:53:35 AM','Wednesday, April 17, 2024','DOWN');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
