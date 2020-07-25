CREATE TABLE [dbo].[Employee] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT            NOT NULL,
    [FirstName]  NVARCHAR (50)  NOT NULL,
    [LastName]   NVARCHAR (50)  NOT NULL,
    [Email_Id]   NVARCHAR (100) NOT NULL,
    [Password] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

