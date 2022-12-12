CREATE DATABASE ProjectWebsiteXeDapMVC
USE ProjectWebsiteXeDapMVC
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/23/2021 10:15:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[uID] [int] IDENTITY(1,1) NOT NULL,
	[user] [varchar](255) NOT NULL,
	[pass] [varchar](255) NOT NULL,
	[isBuy] [int] NOT NULL,
	[isAdmin] [int] NOT NULL,
	[fullName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[uID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuyerAccount]    Script Date: 3/23/2021 10:15:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyerAccount](
	[FullName] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [varchar](30) NULL,
	[Gender] [nvarchar](30) NULL,
	[Dob] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/23/2021 10:15:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[cid] [int] IDENTITY(1,1) NOT NULL,
	[cname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 3/23/2021 10:15:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[OrderID] [int] NOT NULL,
	[Comment] [nvarchar](4000) NULL,
	[Time] [varchar](1000) NULL,
	[Evalue] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 3/23/2021 10:15:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[Detail] [nvarchar](4000) NULL,
	[TotalPay] [money] NULL,
	[Status] [nvarchar](50) NULL,
	[DeliveryAddress] [nvarchar](1000) NULL,
	[Payment] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 3/23/2021 10:15:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[image] [nvarchar](max) NOT NULL,
	[price] [money] NOT NULL,
	[title] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[cateID] [int] NOT NULL,
	[amoutBuy] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (4, N'dat', N'202cb962ac59075b964b07152d234b70', 0, 1, N'Nguyễn Quốc Đat')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (5, N'vuong', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn quốc vượng')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (6, N'adam', N'202cb962ac59075b964b07152d234b70', 1, 0, N'ưed')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (7, N'dat2', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn Quốc Đạt')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (8, N'dat3', N'202cb962ac59075b964b07152d234b70', 1, 0, N'nguyen quoc dat')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (9, N'dat4', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn Quốc Đạt')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (10, N'adam1', N'202cb962ac59075b964b07152d234b70', 1, 0, N'nguyen quoc dat')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (11, N'dat@gmail.com', N'202cb962ac59075b964b07152d234b70', 1, 0, N'nguyen quoc dat')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (12, N'dat8', N'202cb962ac59075b964b07152d234b70', 0, 1, N'Nguyễn Quốc Đạt')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (13, N'dat9', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn Quốc Đạt')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (14, N'mra', N'202cb962ac59075b964b07152d234b70', 1, 0, N'nguyen quoc dat')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (15, N'dat10', N'202cb962ac59075b964b07152d234b70', 1, 0, N'nguyen quoc dat')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (16, N'mrax', N'202cb962ac59075b964b07152d234b70', 1, 0, N'nguyen quoc dat')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (17, N'dat11', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn Quốc Đạt 123')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (18, N'dat68', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn Quốc Đạt')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (19, N'dat86', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn Quốc Đạt')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (20, N'dat86', N'202cb962ac59075b964b07152d234b70', 1, 0, N'Nguyễn Quốc Đạt')
INSERT [dbo].[Account] ([uID], [user], [pass], [isBuy], [isAdmin], [fullName]) VALUES (21, N'truong', N'202cb962ac59075b964b07152d234b70', 1, 0, N'vương văn trường')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
INSERT [dbo].[BuyerAccount] ([FullName], [Address], [Email], [PhoneNumber], [Gender], [Dob]) VALUES (N'1', N'2', N'3', N'4', N'5', CAST(N'2000-01-02' AS Date))
INSERT [dbo].[BuyerAccount] ([FullName], [Address], [Email], [PhoneNumber], [Gender], [Dob]) VALUES (N'Nguyễn Quốc Đạt 1234', N'63 đường Vũ Hữu Lợi, phường Cửa Nam,thành phố Nam Đinh', N'Datnguyen122000@gmail.com', N'0948854268', N'Name', CAST(N'2000-01-02' AS Date))
INSERT [dbo].[BuyerAccount] ([FullName], [Address], [Email], [PhoneNumber], [Gender], [Dob]) VALUES (N'Nguyễn Quốc Đạt 1234', N'63 đường Vũ Hữu Lợi, phường Cửa Nam,thành phố Nam Đinh', N'Datnguyen122000@gmail.com', N'0948854268', N'Nam', CAST(N'2000-01-02' AS Date))
INSERT [dbo].[BuyerAccount] ([FullName], [Address], [Email], [PhoneNumber], [Gender], [Dob]) VALUES (N'Nguyễn Quốc Đạt 1234', N'63 đường Vũ Hữu Lợi, phường Cửa Nam,thành phố Nam Đinh', N'Datnguyen122000@gmail.com', N'0948854268', N'Nữ', CAST(N'2000-01-02' AS Date))
INSERT [dbo].[BuyerAccount] ([FullName], [Address], [Email], [PhoneNumber], [Gender], [Dob]) VALUES (N'vương văn trường', N'hà nội', N'truong@gmail.com', N'094885468', N'Nữ', CAST(N'2000-01-03' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([cid], [cname]) VALUES (1, N'Xe đạp phổ thông')
INSERT [dbo].[Category] ([cid], [cname]) VALUES (2, N'Xe đạp địa hình')
INSERT [dbo].[Category] ([cid], [cname]) VALUES (3, N'Xe đạp trẻ em')
INSERT [dbo].[Category] ([cid], [cname]) VALUES (4, N'Xe đạp đua')
INSERT [dbo].[Category] ([cid], [cname]) VALUES (5, N'Phụ tùng')
INSERT [dbo].[Category] ([cid], [cname]) VALUES (14, N'sdf')
INSERT [dbo].[Category] ([cid], [cname]) VALUES (15, N'sdf')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
INSERT [dbo].[Feedback] ([OrderID], [Comment], [Time], [Evalue]) VALUES (1000, N'không tốt lắm', N'23-01-2008', NULL)
INSERT [dbo].[Feedback] ([OrderID], [Comment], [Time], [Evalue]) VALUES (1000, N'không tốt lắm', N'23-01-2008', N'1*')
INSERT [dbo].[Feedback] ([OrderID], [Comment], [Time], [Evalue]) VALUES (10000, N'khá là ổn', N'23-01-2001', N'2*')
INSERT [dbo].[Feedback] ([OrderID], [Comment], [Time], [Evalue]) VALUES (23, N'khÃ¡ lÃ  tá»t', N'21-03-2021', N'5*')
INSERT [dbo].[Feedback] ([OrderID], [Comment], [Time], [Evalue]) VALUES (26, N'đã feedback chưa', N'21-03-2021', N'3*')
INSERT [dbo].[Feedback] ([OrderID], [Comment], [Time], [Evalue]) VALUES (25, N'Test feedback ok đấy', N'21-03-2021', N'3*')
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (1, N'dat', N'xx,ss', 1000.0000, N'Đang giao', N'63 đường cửa nam', N'chuyển khoản ')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (2, N'Ð?t', N'xx,ss', 1000.0000, N'Đang giao', N'63 đường cửa nam', N'ship code')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (3, N'Đạt', N'xx,ss', 1000.0000, N'đang giao', N'63 đường cửa nam', N'chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (4, N'nguyễn quốc đạt', N'1 gà 6 v?t', 300.0000, N'Đã giao', N'63 đường cửa nam', N'thanh toán khi nhận hàng')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (5, N'nguyễn quốc đạt', N'1 gà 6 vịt', 300.0000, N'đang xác nhận', N'63 đường cửa nam', N'ship code')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (6, N'Nguyễn Quốc đạt', N'6 gà 8 vịt', 72000.0000, N'đã giao xong', N'phường Cửa Bắc', N'ship code')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (7, N'nguyễn quốc đạt', N'1 gà 6 vịt', 300.0000, N'đang xác nhận', N'95 trần thái tông', N'momo')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (8, N'Nguyễn Quốc đạt', N'6 gà 8 vịt', 72000.0000, N'đã giao xong', N'phường Cửa Bắc', N'chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (12, N'nguyễn quốc vượng', N'|Xe Đạp Phổ Thông 24 Inch HMTx1x5000.0', 5010.0000, N'Chờ xác nhận', N'hà nội', N'Viettel Pay')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (13, N'nguyễn quốc vượng', N'|Xe Đạp Phổ Thông 24 Inch HMTx1x5000.0|nguyễn quôc đạt vô giáx1x9.999999999999E12', 10000000005009.0000, N'Chờ xác nhận', N'hà nội', N'Chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (14, N'mra', N'|xe đạp địa hình 11x1x200.0', 240.0000, N'Chờ xác nhận', N'hà nội', N'Momo')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (16, N'', N'', 0.0000, N'Chờ xác nhận', N'', N'Chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (18, N'mra', N'|xe đạp địa hình 8x1x200.0', 240.0000, N'Chờ xác nhận', N'hà nội', N'Chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (23, N'vương văn trường', N'|Xe đạp New 26x1x2311.0', 2321.0000, N'Đã giao', N'fpt', N'Ship Code')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (24, N'vương văn trường', N'|xe đạp địa hình 8x1x200.0', 240.0000, N'Chờ xác nhận', N'hà nội', N'Momo')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (25, N'vương văn trường', N'|xe đạp địa hình 11x1x200.0', 240.0000, N'Đã giao', N'hà nội', N'Viettel Pay')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (26, N'vương văn trường', N'|xe đạp trẻ em 3x1x100.0', 140.0000, N'Đã giao', N'hà nội', N'Chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (9, N'nguyễn quốc đạt', N'1 gà 6 vịt', 300.0000, N'đang xác nhận', N'95 trần thái tông', N'chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (10, N'nguyễn quốc vượng', N'|nguyễn quôc đạt vô giáx1x9.999999999999E12', 10000000000009.0000, N'Chờ xác nhận', N'hà nội', N'Momo')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (11, N'nguyễn quốc vượng', N'', 0.0000, N'Chờ xác nhận', N'hà nội', N'Momo')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (17, N'nguyễn quốc vượng', N'', 0.0000, N'Chờ xác nhận', N'hà nội', N'Ship Code')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (19, N'nguyễn quốc vượng', N'|nguyễn quôc đạt vô giáx1x9.999999999999E12|Xe Đạp Phổ Thông 24 Inch HMTx1x5000.0|xe đạp trẻ em 2x1x100.0', 10000000005109.0000, N'Chờ xác nhận', N'hà nội', N'Chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (20, N'nguyễn quốc vượng', N'', 0.0000, N'Chờ xác nhận', N'hà nội', N'Chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (22, N'xxxx', N'', 0.0000, N'Chờ xác nhận', N'xxx', N'Chuyển khoản')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (15, N'nguyễn quốc đat', N'|nguyễn quôc đạt vô giáx2x9.999999999999E12|xe đạp địa hình 12x1x200.0', 20000000000208.0000, N'Chờ xác nhận', N'hà nội', N'Ship Code')
INSERT [dbo].[OrderDetail] ([OrderID], [CustomerName], [Detail], [TotalPay], [Status], [DeliveryAddress], [Payment]) VALUES (21, N'xxxx', N'|Xe Đạp Phổ Thông 24 Inch HMTx1x5000.0|nguyễn quôc đạt vô giáx1x9.999999999999E12', 10000000005009.0000, N'Chờ xác nhận', N'xxx', N'Chuyển khoản')
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1140, N'xxx đạt', N'xxx', 1234.0000, N'xxx tai tồ', N'Dét ríp tòn', 1, 0)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1042, N'Xe đạp New 26', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-hong-moi-1-2.jpg', 2311.0000, N'xe đạp', N'xe đạp', 1, 234)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1031, N'Xe đạp New 26', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-hong-moi-1-2.jpg', 2311.0000, N'xe đạp', N'xe đạp', 1, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1033, N'Xe đạp New 26', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-hong-moi-1-2.jpg', 2311.0000, N'xe đạp', N'xe đạp', 1, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1035, N'Xe đạp New 26', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-hong-moi-1-2.jpg', 2311.0000, N'xe đạp', N'xe đạp', 1, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1053, N'Xe đạp New 26', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-hong-moi-1-2.jpg', 2311.0000, N'xe đạp', N'xe đạp', 1, 6)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1034, N'xe đạp phổ thông', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 1234.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1036, N'xe đạp phổ thông', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12345.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1038, N'xe đạp phổ thông 8', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12345.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 345)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1040, N'xe đạp phổ thông 9', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12345.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 345)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1041, N'xe đạp phổ thông 10', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12345.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 234)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1043, N'xe đạp phổ thông 11', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12445.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 43)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1044, N'xe đạp phổ thông 12', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12245.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1045, N'xe đạp phổ thông 13', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 122452.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 23)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1046, N'xe đạp phổ thông 14', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12452.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 43)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1047, N'xe đạp phổ thông 15', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 12451.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1048, N'xe đạp phổ thông 16', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 13451.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 76)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1049, N'xe đạp phổ thông 17', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 13452.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1050, N'xe đạp phổ thông 18', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 23452.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 67)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1051, N'xe đạp phổ thông 19', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 23450.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 3)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1052, N'xe đạp phổ thông 20', N'https://thongnhat.com.vn/wp-content/uploads/2020/10/New-24-trang-1-2.jpg', 23450.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 1, 76)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1093, N'xe đạp đua 1', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 14339.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1094, N'xe đạp đua 2', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 13339.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 57)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1095, N'xe đạp đua 3', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 13330.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 7)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1096, N'xe đạp đua 4', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 11330.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 43)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1097, N'xe đạp đua 5', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 21330.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 452)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1098, N'xe đạp đua 6', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 21331.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 3)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1099, N'xe đạp đua 7', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 21351.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1100, N'xe đạp đua 8', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 31351.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1101, N'xe đạp đua 9', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 33351.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 745)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1102, N'xe đạp đua 10', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 33352.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 23)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1103, N'xe đạp đua 11', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 34352.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1104, N'xe đạp đua 12', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 34552.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 365)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1105, N'xe đạp đua 13', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 34554.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1106, N'xe đạp đua 14', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 34654.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1107, N'xe đạp đua 15', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 94654.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 46)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1108, N'xe đạp đua 16', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 94656.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 67)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1109, N'xe đạp đua 17', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 95656.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 56)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1110, N'xe đạp đua 18', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 95658.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 76)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1111, N'xe đạp đua 19', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 15658.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 78)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1112, N'xe đạp đua 20', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl3A1Xakv0b60uSG2-NH5bYTZKPOu1N-WbHQ&usqp=CAU', 15659.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 4, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1113, N'Phụ tùng xe đạp 1', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 15759.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 45)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1114, N'Phụ tùng xe đạp 2', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 15859.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 3423)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1115, N'Phụ tùng xe đạp 3', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 15869.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 88)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1116, N'Phụ tùng xe đạp 4', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 16869.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1117, N'Phụ tùng xe đạp 5', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 16889.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1118, N'Phụ tùng xe đạp 6', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 18889.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 45)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1119, N'Phụ tùng xe đạp 7', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 18989.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1120, N'Phụ tùng xe đạp 8', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 28989.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 78)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1121, N'Phụ tùng xe đạp 9', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 29989.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 67)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1122, N'Phụ tùng xe đạp 10', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 29987.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1123, N'Phụ tùng xe đạp 11', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 49987.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 78)
GO
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1124, N'Phụ tùng xe đạp 12', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 40987.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1125, N'Phụ tùng xe đạp 13', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 41987.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 34)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1126, N'Phụ tùng xe đạp 14', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 51987.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 54)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1127, N'Phụ tùng xe đạp 15', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 51987.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1128, N'Phụ tùng xe đạp 16', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 51988.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 87)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1129, N'Phụ tùng xe đạp 17', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 52988.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 78)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1130, N'Phụ tùng xe đạp 18', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 62988.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 98)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1131, N'Phụ tùng xe đạp 19', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 63988.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 65)
INSERT [dbo].[product] ([id], [name], [image], [price], [title], [description], [cateID], [amoutBuy]) VALUES (1132, N'Phụ tùng xe đạp 20', N'https://sc01.alicdn.com/kf/HTB1GPHOagnD8KJjy1Xdq6yZsVXac.jpg_350x350.jpg', 63985.0000, N'Đây là loại xe mới nhât của chúng tôi', N'Được trang trí với màu sắc bắt mắt', 5, 43)
SET IDENTITY_INSERT [dbo].[product] OFF
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_Category] FOREIGN KEY([cateID])
REFERENCES [dbo].[Category] ([cid])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_Category]
GO