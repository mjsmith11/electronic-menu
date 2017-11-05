CREATE TABLE IF NOT EXISTS `electronic_menu`.`MenuItem` (
  `MenuItemID` INT(11) NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(50) NOT NULL,
  `Description` VARCHAR(250) NULL DEFAULT NULL,
  `Price` DECIMAL(65,30) NULL DEFAULT NULL,
  `DiscountPrice` DECIMAL(65,30) NULL DEFAULT NULL,
  `Category` VARCHAR(20) NOT NULL,
  `IsAvailable` BIT(1) NOT NULL,
  `IsSpecialty` BIT(1) NULL DEFAULT b'0',
  PRIMARY KEY (`MenuItemID`))
ENGINE = InnoDB
AUTO_INCREMENT = 206
DEFAULT CHARACTER SET = latin1;


CREATE TABLE IF NOT EXISTS `electronic_menu`.`Table` (
  `TableID` INT(11) NOT NULL,
  `IsEmpty` BIT(1) NOT NULL,
  PRIMARY KEY (`TableID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `electronic_menu`.`Order` (
  `OrderID` INT(11) NOT NULL AUTO_INCREMENT,
  `IsPlaced` BIT(1) NOT NULL,
  `IsPrepared` BIT(1) NOT NULL,
  `IsPaid` BIT(1) NOT NULL,
  `TableID` INT(11) NOT NULL,
  PRIMARY KEY (`OrderID`),
  INDEX `TableMap_idx` (`TableID` ASC),
  CONSTRAINT `TableMap`
    FOREIGN KEY (`TableID`)
    REFERENCES `electronic_menu`.`Table` (`TableID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE `electronic_menu`.`OrderItem` (
  `OrderItemID` INT(11) NOT NULL,
  `OrderID` INT(11) NOT NULL,
  `MenuItemID` INT(11) NOT NULL,
  PRIMARY KEY (`OrderItemID`),
  INDEX `Order_idx` (`OrderID` ASC),
  INDEX `MenuItem_idx` (`MenuItemID` ASC),
  CONSTRAINT `Order`
    FOREIGN KEY (`OrderID`)
    REFERENCES `electronic_menu`.`Order` (`OrderID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `MenuItem`
    FOREIGN KEY (`MenuItemID`)
    REFERENCES `electronic_menu`.`MenuItem` (`MenuItemID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

