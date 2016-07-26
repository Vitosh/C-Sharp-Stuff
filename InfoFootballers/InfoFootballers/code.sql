Use VitoshAcademyCom

CREATE TABLE Footballers
(
ID int IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(255) NOT NULL,
LastName varchar(255),
Club varchar(255),
City varchar(255)
)

INSERT INTO Footballers (FirstName,LastName,Club,City) VALUES
('Peter','The Keeper','NorthClub','Sofia'),
('Ivan','Mitov','EastClub','Plovdiv'),
('Stoyan','Mitkov','EastClub','Varna'),
('Vitosh','Doynov','EastClub','Sofia'),
('Pesho','Stoyanov','SouthClub','Varna'),
('Gosho','Kiriyakov','SouthClub','Sofia'),
('Haralampi','Iliev','SouthClub','Sofia');