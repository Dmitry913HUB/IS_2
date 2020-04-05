CREATE TABLE [dbo].[Студенты] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Фамилия]  NVARCHAR (50)	NULL,
    [Имя]      NVARCHAR (50)    NULL,
    [Отчество] NVARCHAR (50)    NULL,
    [Группа]   INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Студенты_ToTable] FOREIGN KEY ([Группа]) REFERENCES [dbo].[Группа] ([Id])
);

