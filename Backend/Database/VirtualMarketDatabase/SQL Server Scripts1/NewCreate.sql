CREATE DATABASE MarketDB2


CREATE TABLE MarketUsers(
UserID INT NOT NULL,
Username VARCHAR NOT NULL,
UserAge INT NOT NULL,
UserPassword VARCHAR NOT NULL,
PRIMARY KEY(UserID)
);

CREATE TABLE MarketIndicator(
IndicatorID INT NOT NULL,
IndicatorName VARCHAR(50) NOT NULL,
PRIMARY KEY(IndicatorID)
);

CREATE TABLE IndicatorAnalysis(
IndicatorID INT,
IndicatorCurrentPrice DECIMAL NOT NULL,
IndicatorStartPrice DECIMAL,
IndicatorImage IMAGE,
IndicatorEndPrice DECIMAL,
IndicatorDirection VARCHAR(10),
IndicatorDescription VARCHAR(255),
FOREIGN KEY (IndicatorID) REFERENCES MarketIndicator
);

CREATE TABLE Market(
MarketID INT NOT NULL,
MarketName VARCHAR(10) NOT NULL,
MarketCurrentPrice DECIMAL NOT NULL,
PRIMARY KEY(MarketID)
);

CREATE TABLE MarketAnalysis(
MarketID INT NOT NULL,
IndicatorID INT NOT NULL,
MarketStartPrice DECIMAL,
MarketEndPrice DECIMAL,
MarketDirection VARCHAR(10),
MarketDescription VARCHAR(255) ,
MarketStartImage IMAGE,
MarketResultImage IMAGE,
IndicatorDirection VARCHAR(50),
FOREIGN KEY (MarketID) REFERENCES Market,
FOREIGN KEY (IndicatorID) REFERENCES MarketIndicator
);