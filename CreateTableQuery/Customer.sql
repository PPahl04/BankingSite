/****** Object:  Table [dbo].[Customer]    Script Date: 24.10.2025 02:49:11 ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](10) NOT NULL,
	[LastName] [nchar](10) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[EmailAddress] [nchar](50) NOT NULL,
	[Address_ID] [int] NOT NULL,
 CONSTRAINT [PK_Customer_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Address] FOREIGN KEY([Address_ID])
REFERENCES [dbo].[Address] ([ID])

ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Address]