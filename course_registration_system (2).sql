-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 12, 2017 at 09:54 AM
-- Server version: 5.7.17-log
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `course_registration_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `UserName` varchar(200) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `PasswordHint` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`UserName`, `Password`, `PasswordHint`) VALUES
('DD/14/001', 'DD/14/001', 'DD/14/001'),
('DD/14/002', 'DD/14/002', 'DD/14/002'),
('DD/14/003', 'DD/14/003', 'DD/14/003');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `DeptNo` varchar(15) NOT NULL,
  `DeptName` varchar(100) NOT NULL,
  `MainSubject` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`DeptNo`, `DeptName`, `MainSubject`) VALUES
('DKAN 01', 'Kandyan Dance', 'Kandyan Dance');

-- --------------------------------------------------------

--
-- Table structure for table `register`
--

CREATE TABLE `register` (
  `StuNo` varchar(15) NOT NULL,
  `SubjectId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `register`
--

INSERT INTO `register` (`StuNo`, `SubjectId`) VALUES
('DD/14/001', 1);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `StuNo` varchar(15) NOT NULL,
  `FullName` varchar(500) NOT NULL,
  `LName` varchar(200) NOT NULL,
  `Initials` varchar(20) NOT NULL,
  `Address` varchar(600) NOT NULL,
  `ContactNo` int(10) NOT NULL,
  `Sex` varchar(1) NOT NULL,
  `Batch` varchar(10) NOT NULL,
  `Degree` varchar(1) NOT NULL,
  `SpSubject` varchar(200) NOT NULL,
  `NID` varchar(12) NOT NULL,
  `DeptNo` varchar(15) NOT NULL,
  `UserName` varchar(200) NOT NULL,
  `IntakeYear` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`StuNo`, `FullName`, `LName`, `Initials`, `Address`, `ContactNo`, `Sex`, `Batch`, `Degree`, `SpSubject`, `NID`, `DeptNo`, `UserName`, `IntakeYear`) VALUES
('DD/14/001', 'Amila Nadeeshan Perera', 'Perera', 'A.N', '35/2,Dalugama,Kelaniya', 773212345, 'M', '2014/2015', 'S', 'Kandyan Dance', '953430820V', 'DKAN 01', 'DD/14/001', 2014),
('DD/14/002', 'K.A.U.S.KALPANEE', 'KALPANEE', 'K.A.U.S', 'BATHTHARAMULLA', 713548894, 'F', '2015/2016', 'E', 'IT', '957312020', 'DKAN 01', 'DD/14/002', 2015),
('DD/14/003', 'MALGINEE SAUBHAGYA', 'SAUBHAGYA', 'M', 'KULIYAPITIYA', 713548894, 'F', '2014/2015', 'S', 'Kandyan Dance', '957312020v', 'DKAN 01', 'DD/14/003', 2014);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `SubjectId` int(11) NOT NULL,
  `SubCode` varchar(20) NOT NULL,
  `SubName` varchar(200) NOT NULL,
  `SubType` varchar(1) NOT NULL,
  `SubCredit` int(2) NOT NULL,
  `Sem` int(1) NOT NULL,
  `YearId` int(3) NOT NULL,
  `AcYear` int(4) NOT NULL,
  `DeptNo` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`SubjectId`, `SubCode`, `SubName`, `SubType`, `SubCredit`, `Sem`, `YearId`, `AcYear`, `DeptNo`) VALUES
(1, 'DDBD 22012', 'Drama & Theatre', 'E', 2, 2, 2, 2016, 'DKAN 01');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`UserName`),
  ADD KEY `UserName` (`UserName`),
  ADD KEY `Password` (`Password`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DeptNo`),
  ADD KEY `Department_no` (`DeptNo`),
  ADD KEY `DeptNo` (`DeptNo`),
  ADD KEY `DeptName` (`DeptName`),
  ADD KEY `MainSubject` (`MainSubject`);

--
-- Indexes for table `register`
--
ALTER TABLE `register`
  ADD PRIMARY KEY (`StuNo`,`SubjectId`),
  ADD KEY `StuNo` (`StuNo`),
  ADD KEY `SubjectId` (`SubjectId`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`StuNo`),
  ADD KEY `StuNo` (`StuNo`),
  ADD KEY `DeptNo` (`DeptNo`),
  ADD KEY `UserName` (`UserName`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`SubjectId`),
  ADD KEY `Course_code` (`SubjectId`),
  ADD KEY `Department_no` (`DeptNo`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `register`
--
ALTER TABLE `register`
  ADD CONSTRAINT `register_ibfk_2` FOREIGN KEY (`SubjectId`) REFERENCES `subject` (`SubjectId`),
  ADD CONSTRAINT `register_ibfk_3` FOREIGN KEY (`StuNo`) REFERENCES `student` (`StuNo`);

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_2` FOREIGN KEY (`DeptNo`) REFERENCES `department` (`DeptNo`),
  ADD CONSTRAINT `student_ibfk_3` FOREIGN KEY (`UserName`) REFERENCES `account` (`UserName`);

--
-- Constraints for table `subject`
--
ALTER TABLE `subject`
  ADD CONSTRAINT `subject_ibfk_1` FOREIGN KEY (`DeptNo`) REFERENCES `department` (`DeptNo`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
