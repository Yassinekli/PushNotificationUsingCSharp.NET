create database [Test Push Notification DB]

USE [Test Push Notification DB]

CREATE TABLE [dbo].[SubscribersSet](
	[Subscriber_ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[endPoint] [nvarchar](max) NOT NULL,
	[auth] [nvarchar](max) NOT NULL,
	[p256dh] [nvarchar](max) NOT NULL
)
