Use [CodingTaskDB]
Go


CREATE USER User1 WITHOUT LOGIN;  
CREATE USER User2 WITHOUT LOGIN;
CREATE USER User3 WITHOUT LOGIN;
CREATE USER User4 WITHOUT LOGIN;
CREATE USER User5 WITHOUT LOGIN;
GO


CREATE SCHEMA Sales
GO
CREATE TABLE Sales.Orders
(  
	OrderID int,  
	UserAccess nvarchar(50),  
	Product nvarchar(50)
);  


INSERT INTO Sales.Orders  VALUES (1, 'User1', 'Laptop');
INSERT INTO Sales.Orders  VALUES (2, 'User1', 'Earphones');
INSERT INTO Sales.Orders  VALUES (3, 'User2', 'Tablet');
INSERT INTO Sales.Orders  VALUES (4, 'User2', 'Console');
INSERT INTO Sales.Orders  VALUES (5, 'User3', 'Radio');
INSERT INTO Sales.Orders  VALUES (6, 'User3', 'Smartwatch');
INSERT INTO Sales.Orders  VALUES (7, 'User4', 'TV');
INSERT INTO Sales.Orders  VALUES (8, 'User4', 'Microphone');
INSERT INTO Sales.Orders  VALUES (9, 'User5', 'PC');
INSERT INTO Sales.Orders  VALUES (10, 'User5', 'Speaker');


SELECT * FROM Sales.Orders;


GRANT SELECT ON Sales.Orders TO User1;  
GRANT SELECT ON Sales.Orders TO User2;
GRANT SELECT ON Sales.Orders TO User3;  
GRANT SELECT ON Sales.Orders TO User4;  
GRANT SELECT ON Sales.Orders TO User5;
GO


CREATE SCHEMA Security;  
GO  
  
CREATE FUNCTION Security.SecurityPredicate(@UserAccess AS nvarchar(50))  
    RETURNS TABLE  WITH SCHEMABINDING  
AS  
    RETURN SELECT 1 AS SecurityPredicate_Result
	WHERE @UserAccess = USER_NAME() OR USER_NAME() = 'User5';
GO


CREATE SECURITY POLICY SalesFilter
ADD FILTER PREDICATE Security.SecurityPredicate(UserAccess)
ON Sales.Orders
WITH (STATE = ON);  
GO


GRANT SELECT ON Security.SecurityPredicate TO User1;  
GRANT SELECT ON Security.SecurityPredicate TO User2;  
GRANT SELECT ON Security.SecurityPredicate TO User3;  
GRANT SELECT ON Security.SecurityPredicate TO User4;
GRANT SELECT ON Security.SecurityPredicate TO User5; 


EXECUTE AS USER = 'User1';  
SELECT * FROM Sales.Orders;
REVERT;  
  
EXECUTE AS USER = 'User2';  
SELECT * FROM Sales.Orders;
REVERT;  
  
EXECUTE AS USER = 'User3';  
SELECT * FROM Sales.Orders;
REVERT;  
  
EXECUTE AS USER = 'User4';  
SELECT * FROM Sales.Orders;
REVERT;  

EXECUTE AS USER = 'User5';  
SELECT * FROM Sales.Orders;
REVERT;


ALTER SECURITY POLICY SalesFilter  
WITH (STATE = OFF);


DROP USER User1;
DROP USER User2;
DROP USER User3;
DROP USER User4;
DROP USER User5;

DROP SECURITY POLICY SalesFilter;
DROP TABLE Sales.Orders;
DROP FUNCTION Security.SecurityPredicate;
DROP SCHEMA Security;
DROP SCHEMA Sales;