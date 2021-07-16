# user-manager
Sample CRUD user manager dashboard provided by Dapper


Database structure:
|Column|Type|Not Null?|
|-|-|-|
|Id|int|+|
|LastName|nvarchar(50)|+|
|FirstName|nvarchar(50)|+|
|BirthYear|int|+|
|Login|nvarchar(50)|+|
|IsAdmin|bit|+|

<details>
  <summary>Generated SQL script</summary>


  ```sql
  USE [<Your database name>]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 16.07.2021 23:47:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[BirthYear] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
  ```
  
  
</details>
