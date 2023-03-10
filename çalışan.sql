USE [calisan]
GO
/****** Object:  Table [dbo].[doktorlar]    Script Date: 3.01.2023 16:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doktorlar](
	[id] [int] NOT NULL,
	[doctor] [varchar](50) NULL,
	[tc_no] [varchar](50) NULL,
 CONSTRAINT [PK_doktorlar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
