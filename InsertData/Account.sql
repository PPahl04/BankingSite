INSERT INTO [dbo].[Account]
           ([IBAN]
           ,[Balance]
           ,[Number]
           ,[Customer_ID])
     VALUES
           ('DE223564857926647212'
           ,2000
           ,13213
           ,(SELECT TOP 1 ID FROM [dbo].[Customer]
           WHERE FirstName = 'Anno'
           AND LastName = 'Nhyme'
           AND PhoneNumber = 012238864
           AND EmailAddress = 'anno.nhyme@yahoo.com'
           ORDER BY ID DESC))

INSERT INTO [dbo].[Account]
           ([IBAN]
           ,[Balance]
           ,[Number]
           ,[Customer_ID])
     VALUES
           ('DE223564857926649875'
           ,500
           ,13242
           ,(SELECT TOP 1 ID FROM [dbo].[Customer]
           WHERE FirstName = 'Annie'
           AND LastName = 'Nhyme'
           AND PhoneNumber = 012238559
           AND EmailAddress = 'annie.nhyme@yahoo.com'
           ORDER BY ID DESC))

INSERT INTO [dbo].[Account]
           ([IBAN]
           ,[Balance]
           ,[Number]
           ,[Customer_ID])
     VALUES
           ('DE223564857926634566'
           ,3
           ,12342
           ,(SELECT TOP 1 ID FROM [dbo].[Customer]
           WHERE FirstName = 'Nunya'
           AND LastName = 'Busnhess'
           AND PhoneNumber = 034229987
           AND EmailAddress = 'nunya.bus@outlook.com'
           ORDER BY ID DESC))

INSERT INTO [dbo].[Account]
           ([IBAN]
           ,[Balance]
           ,[Number]
           ,[Customer_ID])
     VALUES
           ('DE223564857234567891'
           ,10
           ,143543
           ,(SELECT TOP 1 ID FROM [dbo].[Customer]
           WHERE FirstName = 'Salliek'
           AND LastName = 'Songh'
           AND PhoneNumber = 03341128
           AND EmailAddress = 'salliek.songh@gmail.com'
           ORDER BY ID DESC))

INSERT INTO [dbo].[Account]
           ([IBAN]
           ,[Balance]
           ,[Number]
           ,[Customer_ID])
     VALUES
           ('DE77394755926647212'
           ,0
           ,1234223
           ,(SELECT TOP 1 ID FROM [dbo].[Customer]
           WHERE FirstName = 'Nunya'
           AND LastName = 'Busnhess'
           AND PhoneNumber = 034229987
           AND EmailAddress = 'nunya.bus@outlook.com'
           ORDER BY ID DESC))

INSERT INTO [dbo].[Account]
           ([IBAN]
           ,[Balance]
           ,[Number]
           ,[Customer_ID])
     VALUES
           ('DE84398943065064275'
           ,312040
           ,12342324
           ,(SELECT TOP 1 ID FROM [dbo].[Customer]
           WHERE FirstName = 'Nunya'
           AND LastName = 'Busnhess'
           AND PhoneNumber = 034229987
           AND EmailAddress = 'nunya.bus@outlook.com'
           ORDER BY ID DESC))