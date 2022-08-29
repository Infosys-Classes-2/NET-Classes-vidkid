CREATE TABLE [dbo].[Person] (
    [Id]      INT          NOT NULL,
    [Name]    VARCHAR (50) NULL,
    [Address] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
--Insert data into table
INSERT INTO Person (Name, Address)
VALUES ('Vidkid', 'Ktm');
INSERT INTO Person (Name, Address)
VALUES ('Dhiraj', 'lalbandi');

--Query
Select * from Person