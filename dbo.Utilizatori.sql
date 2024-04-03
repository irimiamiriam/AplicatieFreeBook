CREATE TABLE [dbo].[Utilizatori] (
    [IdUtilizator]          INT   IDENTITY (1, 1) NOT NULL,
    [NumePrenumeUtilizator] NVARCHAR(MAX) NOT NULL,
    [ParolaUtilizator]      NTEXT NOT NULL,
    [EmailUtilizator]       NTEXT NOT NULL,
    [ClasaUtilizator]       NTEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUtilizator] ASC)
);

