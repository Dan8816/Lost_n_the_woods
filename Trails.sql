-- MySQL Script generated by MySQL Workbench
-- Tue Jul 10 08:16:32 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema trailsdb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema trailsdb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `trailsdb` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------
-- Schema Trails
-- -----------------------------------------------------
USE `trailsdb` ;

-- -----------------------------------------------------
-- Table `trailsdb`.`Trails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trailsdb`.`Trails` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `trail_name` VARCHAR(45) NULL,
  `descript` TEXT NULL,
  `length` DOUBLE NULL,
  `elev_change` INT NULL,
  `lat` DOUBLE NULL,
  `lon` DOUBLE NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
