INSERT INTO [dbo].[Account] ([IBAN], [Balance], [Number], [Customer_ID])
VALUES (@IBAN, @Balance, @Number, @Customer_ID);

SELECT ID, IBAN, Balance, Number, Customer_ID FROM Account
WHERE (ID = SCOPE_IDENTITY())