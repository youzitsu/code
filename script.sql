USE [testasp.net]
GO
/****** Object:  User [phuong]    Script Date: 6/4/2022 10:15:34 AM ******/
CREATE USER [phuong] FOR LOGIN [phuong] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[user]    Script Date: 6/4/2022 10:15:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[user] ([username], [password]) VALUES (N'docu', N'123')
INSERT [dbo].[user] ([username], [password]) VALUES (N'phuong', N'123')
GO
