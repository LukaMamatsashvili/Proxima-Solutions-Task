CREATE DATABASE CodingTaskDB

Use [CodingTaskDB]
Go

CREATE TABLE Invoices
(
	Id int NOT NULL Primary Key,
	BillingDate date NOT NULL,
	CustomerId int NOT NULL
)

CREATE TABLE Customers
(
	Id int NOT NULL Primary Key,
	Name nvarchar(50) NOT NULL,
	ReferredBy int
)

INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (1, '2022-08-24', 5)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (2, '2022-11-15', 1)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (3, '2022-05-12', 4)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (4, '2022-07-28', 8)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (5, '2022-10-21', 6)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (6, '2022-06-11', 2)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (7, '2022-03-31', 10)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (8, '2022-09-04', 7)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (9, '2022-12-25', 3)
INSERT INTO Invoices(Id, BillingDate, CustomerId) VALUES (10, '2022-04-09', 9)


INSERT INTO Customers(Id, Name, ReferredBy) VALUES (1, 'Luka', null)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (2, 'Maka', 6)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (3, 'Shota', 7)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (4, 'Nino', 3)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (5, 'Irakli', 10)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (6, 'Ana', 5)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (7, 'Gela', 1)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (8, 'Tamari', 2)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (9, 'Lasha', 8)
INSERT INTO Customers(Id, Name, ReferredBy) VALUES (10, 'Salome', null)


SELECT * FROM Invoices
SELECT * FROM Customers

SELECT Invoices.Id, Invoices.BillingDate, Customers.Name, Customers.Referredby 
FROM Customers
INNER JOIN Invoices ON Invoices.CustomerId = Customers.id
ORDER BY Invoices.BillingDate ASC

SELECT Id.Name, IsNull(RefferedBy.Name, 'Nobody') AS [Referred By] 
FROM Customers Id
LEFT JOIN Customers RefferedBy ON Id.ReferredBy = RefferedBy.Id



