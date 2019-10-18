CREATE TABLE [dbo].[Vehicles] (
    [TUID]      INT          NOT NULL,
    [OwnerID]   VARCHAR (50) NOT NULL,
    [Make]      VARCHAR (50) NULL,
    [Model]     VARCHAR (50) NULL,
    [Color]     VARCHAR (50) NULL,
    [ModelYear] INT          NULL,
    [VIN]       VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([OwnerID])
);

