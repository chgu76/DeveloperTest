# DeveloperTest

Jag har valt att använda mig av .net 8 och ett helt vanligt console-projekt och gammal hederlig anslutning till databasen. 

När det gäller enhetstestning så har jag valt XUnit. Jag har inte jobbat alls mycket med enhetstestning för att kunna avgöra vad som passar bäst i olika situationer. 


# Setting up a database
Step 1. Create a database on your preferred SQL Server using the name 'DevTest'
Step 2. Run the following script to set up a new Table in the database.

```

USE [DevTest]
GO

/****** Object:  Table [dbo].[Arguments]    Script Date: 2024-05-05 15:43:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Arguments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDT] [datetime] NOT NULL,
	[Argument1] [int] NOT NULL,
	[Argument2] [int] NOT NULL,
 CONSTRAINT [PK_Arguments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

Step 3. Enter the ConnectionString in the file app.config.  
