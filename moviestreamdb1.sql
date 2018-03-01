-- creating Db
CREATE DATABASE IF NOT EXISTS moviestreamdb;
use moviestreamdb;

-- creating user table
DROP TABLE IF EXISTS `user`;
CREATE TABLE `moviestreamdb`.`user` (
  `user_id` INT UNSIGNED NOT NULL,
  `first_name` VARCHAR(45) NOT NULL,
  `last_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`user_id`));
  
  INSERT INTO `user` VALUES (1,'Wudist','Aycheh'),(2,'Ali','Ahmed'),(3,'Antonio','Nathan'),(4,'Lantonio','Robert'),(5,'Din','Daniel');
  
-- creating preference table
DROP TABLE IF EXISTS `preference`;
CREATE TABLE `moviestreamdb`.`preference` (
  `preference_id` INT UNSIGNED NOT NULL,
  `user_id` INT UNSIGNED NOT NULL,
  `comedy` VARCHAR(45) NULL,
  `drama` VARCHAR(45) NULL,
  `romance` VARCHAR(45) NULL,
  `horror` VARCHAR(45) NULL,
  PRIMARY KEY (`preference_id`),
  INDEX `preference_idfk_idx` (`user_id` ASC),
  CONSTRAINT `preference_idfk`
    FOREIGN KEY (`user_id`)
    REFERENCES `moviestreamdb`.`user` (`user_id`)
    );
    
-- creating Vote table
DROP TABLE IF EXISTS `vote`; 
CREATE TABLE `moviestreamdb`.`vote` (
  `vote_id` INT UNSIGNED NOT NULL,
  `user_id` INT UNSIGNED NOT NULL,
  `horror` VARCHAR(45) NULL,
  `comedy` VARCHAR(45) NULL,
  `romans` VARCHAR(45) NULL,
  `drama` VARCHAR(45) NULL,
  PRIMARY KEY (`vote_id`),
  INDEX `user_id_idx` (`user_id` ASC),
  CONSTRAINT `vote_idfk`
    FOREIGN KEY (`user_id`)
    REFERENCES `moviestreamdb`.`user` (`user_id`)
    );   


    