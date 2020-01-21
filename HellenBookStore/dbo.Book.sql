CREATE TABLE [dbo].[Book] (
    [ISBN]      VARCHAR (50) NOT NULL,
    [Title]     VARCHAR (50) NOT NULL,
    [Author]    VARCHAR (50) NOT NULL,
    [Price]     DECIMAL(10, 2)         NOT NULL,
    [QtyOnHand] INT          NOT NULL,
    [ImageName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ISBN] ASC)
);

