USE [DB56]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 15/04/2019 4:54:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 15/04/2019 4:54:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[CNIC] [nchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Salary] [money] NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[Address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[CNIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan_Application]    Script Date: 15/04/2019 4:54:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan_Application](
	[App_ID] [int] NOT NULL,
	[Reason_Loan] [varchar](200) NOT NULL,
	[Loan_Amount] [money] NOT NULL,
	[Pay_Back_time] [datetime] NOT NULL,
	[Loan_ID] [int] NOT NULL,
	[CNIC] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Loan_Application] PRIMARY KEY CLUSTERED 
(
	[App_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan_Approval]    Script Date: 15/04/2019 4:54:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan_Approval](
	[Approval_ID] [int] NOT NULL,
	[No_of_Installments] [int] NOT NULL,
	[Installments_Amount] [money] NOT NULL,
	[Discription] [varchar](200) NOT NULL,
	[Approved_date] [datetime] NOT NULL,
 CONSTRAINT [PK_Loan_Approval] PRIMARY KEY CLUSTERED 
(
	[Approval_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan_Info]    Script Date: 15/04/2019 4:54:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan_Info](
	[App_ID] [int] NOT NULL,
	[Pay_ID] [int] NOT NULL,
	[Status] [varchar](10) NOT NULL,
	[Reason_Of_Rejection] [varchar](100) NOT NULL,
	[Approval_ID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan_Policy]    Script Date: 15/04/2019 4:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan_Policy](
	[Loan_ID] [int] NOT NULL,
	[Loan_type] [varchar](10) NOT NULL,
	[Loan_Discription] [varchar](300) NOT NULL,
	[Amount] [money] NOT NULL,
	[Max_Installments] [int] NOT NULL,
 CONSTRAINT [PK_Loan_Policy] PRIMARY KEY CLUSTERED 
(
	[Loan_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment_Details]    Script Date: 15/04/2019 4:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment_Details](
	[Pay_ID] [int] NOT NULL,
	[Paid_Amount] [money] NOT NULL,
	[Amount_Left] [money] NOT NULL,
	[Date_of_Completion] [datetime] NOT NULL,
	[Installement_Left] [int] NOT NULL,
 CONSTRAINT [PK_Payment_Details] PRIMARY KEY CLUSTERED 
(
	[Pay_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Loan_Application]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Application_Employee] FOREIGN KEY([CNIC])
REFERENCES [dbo].[Employee] ([CNIC])
GO
ALTER TABLE [dbo].[Loan_Application] CHECK CONSTRAINT [FK_Loan_Application_Employee]
GO
ALTER TABLE [dbo].[Loan_Application]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Application_Loan_Policy] FOREIGN KEY([Loan_ID])
REFERENCES [dbo].[Loan_Policy] ([Loan_ID])
GO
ALTER TABLE [dbo].[Loan_Application] CHECK CONSTRAINT [FK_Loan_Application_Loan_Policy]
GO
ALTER TABLE [dbo].[Loan_Info]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Info_Loan_Application] FOREIGN KEY([App_ID])
REFERENCES [dbo].[Loan_Application] ([App_ID])
GO
ALTER TABLE [dbo].[Loan_Info] CHECK CONSTRAINT [FK_Loan_Info_Loan_Application]
GO
ALTER TABLE [dbo].[Loan_Info]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Info_Loan_Approval] FOREIGN KEY([Approval_ID])
REFERENCES [dbo].[Loan_Approval] ([Approval_ID])
GO
ALTER TABLE [dbo].[Loan_Info] CHECK CONSTRAINT [FK_Loan_Info_Loan_Approval]
GO
ALTER TABLE [dbo].[Loan_Info]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Info_Payment_Details] FOREIGN KEY([Pay_ID])
REFERENCES [dbo].[Payment_Details] ([Pay_ID])
GO
ALTER TABLE [dbo].[Loan_Info] CHECK CONSTRAINT [FK_Loan_Info_Payment_Details]
GO
