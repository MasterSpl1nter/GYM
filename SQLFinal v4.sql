SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `gym` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `gym` ;

-- -----------------------------------------------------
-- Table `gym`.`trainer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`trainer` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `firstname` VARCHAR(30) NOT NULL,
  `lastname` VARCHAR(30) NOT NULL,
  `email` VARCHAR(30) NOT NULL,
  `username` VARCHAR(30) NOT NULL,
  `password` VARCHAR(30) NOT NULL,
  `permission` TINYINT UNSIGNED NOT NULL,
  `salaryperhour` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`student`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`student` (
  `id` INT UNSIGNED NOT NULL,
  `firstname` VARCHAR(30) NOT NULL,
  `lastname` VARCHAR(30) NOT NULL,
  `email` VARCHAR(30) NOT NULL,
  `username` VARCHAR(30) NOT NULL,
  `password` VARCHAR(30) NOT NULL,
  `permission` TINYINT UNSIGNED NOT NULL,
  `birthday` DATETIME NOT NULL,
  `startdate` DATETIME NOT NULL,
  `enddate` DATETIME NOT NULL,
  `medcert` DATETIME NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`worker`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`worker` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `firstname` VARCHAR(30) NOT NULL,
  `lastname` VARCHAR(30) NOT NULL,
  `email` VARCHAR(30) NOT NULL,
  `username` VARCHAR(30) NOT NULL,
  `password` VARCHAR(30) NOT NULL,
  `permission` TINYINT UNSIGNED NOT NULL,
  `salaryperhour` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`manager`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`manager` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `firstname` VARCHAR(30) NOT NULL,
  `lastname` VARCHAR(30) NOT NULL,
  `email` VARCHAR(30) NOT NULL,
  `username` VARCHAR(30) NOT NULL,
  `password` VARCHAR(30) NOT NULL,
  `permission` TINYINT UNSIGNED NOT NULL,
  `salaryperhour` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`guide`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`guide` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `firstname` VARCHAR(30) NOT NULL,
  `lastname` VARCHAR(30) NOT NULL,
  `email` VARCHAR(30) NOT NULL,
  `username` VARCHAR(30) NOT NULL,
  `password` VARCHAR(30) NOT NULL,
  `permission` TINYINT UNSIGNED NOT NULL,
  `salaryperhour` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`room`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`room` (
  `id` INT UNSIGNED NOT NULL,
  `name` VARCHAR(30) NOT NULL,
  `capacity` INT UNSIGNED NOT NULL,
  `area` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`class`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`class` (
  `id` INT UNSIGNED NOT NULL,
  `name` VARCHAR(30) NOT NULL,
  `room` INT UNSIGNED NOT NULL,
  `guideid` INT UNSIGNED NOT NULL,
  `capacity` INT UNSIGNED NOT NULL,
  `area` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `id_idx` (`guideid` ASC),
  INDEX `id_idx1` (`room` ASC),
  CONSTRAINT `guideid`
    FOREIGN KEY (`guideid`)
    REFERENCES `gym`.`guide` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `roomid`
    FOREIGN KEY (`room`)
    REFERENCES `gym`.`room` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`appliance`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`appliance` (
  `id` INT UNSIGNED NOT NULL,
  `name` VARCHAR(30) NOT NULL,
  `manufacturer` VARCHAR(30) NOT NULL,
  `room` INT UNSIGNED NOT NULL,
  `adddate` DATETIME NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `id_idx` (`room` ASC),
  CONSTRAINT `id`
    FOREIGN KEY (`room`)
    REFERENCES `gym`.`room` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`studentclass`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`studentclass` (
  `studentid` INT UNSIGNED NOT NULL,
  `classid` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`studentid`, `classid`),
  INDEX `id_idx` (`classid` ASC),
  CONSTRAINT `studentid`
    FOREIGN KEY (`studentid`)
    REFERENCES `gym`.`student` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `classid`
    FOREIGN KEY (`classid`)
    REFERENCES `gym`.`class` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`classtime`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`classtime` (
  `classid` INT UNSIGNED NOT NULL,
  `starttime` DATETIME NOT NULL,
  `endtime` DATETIME NOT NULL,
  PRIMARY KEY (`classid`, `starttime`),
  CONSTRAINT `FK_classid`
    FOREIGN KEY (`classid`)
    REFERENCES `gym`.`class` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`workingtime`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`workingtime` (
  `id` INT UNSIGNED NOT NULL,
  `permission` TINYINT UNSIGNED NOT NULL,
  `starttime` DATETIME NOT NULL,
  `endtime` DATETIME NOT NULL)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`training`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`training` (
  `id` INT UNSIGNED NOT NULL,
  `name` VARCHAR(30) NOT NULL,
  `appliance` INT UNSIGNED NOT NULL,
  `sets` INT UNSIGNED NOT NULL,
  `repeats` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `appliance_idx` (`appliance` ASC),
  CONSTRAINT `appliance`
    FOREIGN KEY (`appliance`)
    REFERENCES `gym`.`appliance` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gym`.`studenttraining`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gym`.`studenttraining` (
  `studentid` INT UNSIGNED NOT NULL,
  `trainingid` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`studentid`, `trainingid`),
  INDEX `trainingid_idx` (`trainingid` ASC),
  CONSTRAINT `fk_studentid`
    FOREIGN KEY (`studentid`)
    REFERENCES `gym`.`student` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `trainingid`
    FOREIGN KEY (`trainingid`)
    REFERENCES `gym`.`training` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
