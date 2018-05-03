USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV_V1')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV_V1') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV_V1]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTV_V1]
GO

USE [QLTV_V1]
GO

/****** Object:  Table [dbo].[tbl_typeReaders]    Script Date: 5/2/2018 10:30:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_typeReaders](
	[Id_typeReaders] [int] NOT NULL,
	[Name_typeReaders] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_typeReaders] PRIMARY KEY CLUSTERED 
(
	[Id_typeReaders] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLTV_V1]
GO

/****** Object:  Table [dbo].[tbl_Employee]    Script Date: 5/2/2018 10:35:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Employee](
	[Id_Employee] [nvarchar](10) NOT NULL,
	[Name_Employee] [nvarchar](50) NOT NULL,
	[Birthday] [datetime2](7) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Employee] PRIMARY KEY CLUSTERED 
(
	[Id_Employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [QLTV_V1]
GO

/****** Object:  Table [dbo].[tbl_Readers]    Script Date: 5/2/2018 10:27:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Readers](
	[Id_Readers] [nvarchar](10) NOT NULL,
	[Name_Readers] [nvarchar](50) NOT NULL,
	[Id_typeReaders] [int] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Birthday] [datetime2](7) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Card_Date] [datetime2](7) NOT NULL,
	[Id_Employee] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_Readers] PRIMARY KEY CLUSTERED 
(
	[Id_Readers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--USE [QLTV_V1]
--GO

--/****** Object:  Table [dbo].[Table_1]    Script Date: 5/3/2018 3:50:00 PM ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--CREATE TABLE [dbo].[Table_1](
--	[id] [int] NOT NULL,
--	[Name] [nvarchar](50) NOT NULL,
-- CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
--(
--	[id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO


USE [QLTV_V1]
GO

INSERT INTO[dbo].[tbl_typeReaders]([Id_typeReaders],[Name_typeReaders]) VALUES(1,N'Normal')
GO
INSERT INTO[dbo].[tbl_typeReaders]([Id_typeReaders],[Name_typeReaders]) VALUES(2,N'Friendly')
GO
INSERT INTO[dbo].[tbl_typeReaders]([Id_typeReaders],[Name_typeReaders]) VALUES(3,N'VIP')
GO

USE [QLTV_V1]
GO


INSERT INTO [dbo].[tbl_Employee]([Id_Employee],[Name_Employee],[Address],[Birthday])VALUES(N'16000001',N'Nguyễn Văn An',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Employee]([Id_Employee],[Name_Employee],[Address],[Birthday]) VALUES(N'16000002',N'Nguyễn Văn Huy',N'1 Cống Quỳnh, Quận 1, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Employee]([Id_Employee],[Name_Employee],[Address],[Birthday]) VALUES(N'16000003',N'Nguyễn Văn Tùng',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Employee]([Id_Employee],[Name_Employee],[Address],[Birthday]) VALUES(N'16000004',N'Nguyễn Quang Minh',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Employee]([Id_Employee],[Name_Employee],[Address],[Birthday]) VALUES(N'16000005',N'Nguyễn Nhật Trường',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))

USE [QLTV_V1]
GO

INSERT INTO [dbo].[tbl_Readers]([Id_Readers],[Id_typeReaders],[Name_Readers],[Address],[Birthday],[Email],[Card_Date],[Id_Employee]) VALUES(N'15000001',1,N'Nguyễn Văn An',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'qltv@gmail.com',convert(datetime,'12/30/2020 00:00:00',101),N'16000001')
GO
INSERT INTO [dbo].[tbl_Readers]([Id_Readers],[Id_typeReaders],[Name_Readers],[Address],[Birthday],[Email],[Card_Date],[Id_Employee]) VALUES(N'15000002',2,N'Nguyễn Văn Huy',N'1 Cống Quỳnh, Quận 1, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'qltv@gmail.com',convert(datetime,'12/30/2020 00:00:00',101),N'16000001')
GO
INSERT INTO [dbo].[tbl_Readers]([Id_Readers],[Id_typeReaders],[Name_Readers],[Address],[Birthday],[Email],[Card_Date],[Id_Employee]) VALUES(N'15000003',3,N'Nguyễn Văn Tùng',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'qltv@gmail.com',convert(datetime,'12/30/2020 00:00:00',101),N'16000001')
GO
INSERT INTO [dbo].[tbl_Readers]([Id_Readers],[Id_typeReaders],[Name_Readers],[Address],[Birthday],[Email],[Card_Date],[Id_Employee]) VALUES(N'15000004',1,N'Nguyễn Quang Minh',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'qltv@gmail.com',convert(datetime,'12/30/2020 00:00:00',101),N'16000001')
GO
INSERT INTO [dbo].[tbl_Readers]([Id_Readers],[Id_typeReaders],[Name_Readers],[Address],[Birthday],[Email],[Card_Date],[Id_Employee]) VALUES(N'15000005',2,N'Nguyễn Nhật Trường',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'qltv@gmail.com',convert(datetime,'12/30/2020 00:00:00',101),N'16000001')