USE [QuanLySach]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 17/07/2021 3:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Id] [int] NOT NULL,
	[Type] [nvarchar](50) NULL,
	[Content] [nvarchar](50) NULL,
	[Author] [nvarchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Sach] ([Id], [Type], [Content], [Author], [Price]) VALUES (1, N'Toán', N'Toán 12', N'khong biet', 3)
INSERT [dbo].[Sach] ([Id], [Type], [Content], [Author], [Price]) VALUES (2, N'Lý', N'Vật Lý 12', N'Nguyen Thi B', 5)
INSERT [dbo].[Sach] ([Id], [Type], [Content], [Author], [Price]) VALUES (3, N'Tôi thấy hoa vàng trên cỏ xanh', N'Tình cảm', N'khong biet', 1)
INSERT [dbo].[Sach] ([Id], [Type], [Content], [Author], [Price]) VALUES (4, N'Pro ASP.NET MVC5', N'Lập trình', N'khong biet', 21)
GO
