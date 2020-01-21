CREATE TABLE [dbo].[Order]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [CustomerId]  INT FOREIGN KEY REFERENCES Customer(CustomerId) NOT NULL,
    [OrderDate] DATE NOT NULL, 
    [SubTotal] DECIMAL(10, 2) NOT NULL, 
    [Tax] DECIMAL(10, 2) NOT NULL, 
    [Total] DECIMAL(10, 2) NOT NULL
)
