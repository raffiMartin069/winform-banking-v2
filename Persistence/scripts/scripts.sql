USE PCB;

INSERT INTO [dbo].[DepositMode] ([Mode])
VALUES 
    ('Express Send')

SELECT WDRAW.Id, USR.Fullname, USR.AccountNumber, WDRAW.PreviousBalance, WDRAW.CurrentBalance, 
	WDRAW.DateUpdate, WDRAW.TimeUpdated 
	FROM Withdraw 
	AS 
	WDRAW
	INNER JOIN 
	[dbo].[User] 
	AS 
	USR 
	ON WDRAW.UserId = USR.Id

SELECT * FROM [dbo].[WithdrawMode]

INSERT INTO [dbo].[Gender] VALUES ('Male'), ('Female'), ('Non-Binary'), ('Prefer not to say') 

SELECT * FROM [dbo].[Gender]

INSERT INTO [dbo].[MarriageStatus] VALUES ('Married'), ('Single'), ('Divored'), ('Separated')

SELECT * FROM [dbo].[MarriageStatus]

INSERT INTO [dbo].[Role] VALUES ('Admin'), ('Client')

SELECT * FROM [dbo].[Role]

INSERT INTO [dbo].[WithdrawMode] ([Mode])
VALUES 
    ('Cash Deposit'),
    ('Cheque Deposit'),
    ('Bank Transfer'),
    ('ATM Deposit'),
    ('Direct Deposit'),
    ('Online Bank Transfer'),
    ('Wire Transfer'),
    ('Payroll Deposit');
