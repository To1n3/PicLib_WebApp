CREATE TABLE [dbo].Picture
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [CreationDate] BIGINT NOT NULL, 
    [Author] NVARCHAR(MAX) NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    [DownloadNumber] BIGINT NOT NULL, 
    [Height] FLOAT NULL, 
    [Width] FLOAT NULL, 
    [Uri] VARCHAR(MAX) NOT NULL
)
