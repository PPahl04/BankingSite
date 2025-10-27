/****** Object:  Table [dbo].[Transaction]    Script Date: 25.10.2025 16:26:49 ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Transaction](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Amount] [int] NOT NULL,
	[IntendedUse] [nchar](255) NULL,
	[Type] [nchar](15) NOT NULL,
	[AccountReceiver_ID] [int] NOT NULL,
	[AccountSender_ID] [int] NOT NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_AccountReceiver] FOREIGN KEY([AccountReceiver_ID])
REFERENCES [dbo].[Account] ([ID])

ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_AccountReceiver]

ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_AccountSender] FOREIGN KEY([AccountSender_ID])
REFERENCES [dbo].[Account] ([ID])
ON DELETE CASCADE

ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_AccountSender]