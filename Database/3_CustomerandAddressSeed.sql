Use SOW
Go

IF NOT EXISTS (SELECT * FROM [dbo].[Customer])
Begin

 DECLARE @v_WisStateId int;
 DECLARE @v_NewYorkStateId int;
 DECLARE @v_DEStateId int;
 DECLARE @v_CustomerId int;

 SELECT @v_WisStateId = StateID FROM [dbo].[State] 
	WHERE State = 'WI';

 SELECT @v_NewYorkStateId = StateID FROM [dbo].[State] 
	WHERE State = 'NY';	 

 SELECT @v_DEStateId = StateID FROM [dbo].[State] 
	WHERE State = 'DE';	 

 /* Insert Customer Details  */  
 INSERT INTO [dbo].[Customer](FirstName, LastName, EmailAddress)
	VALUES ('White', 'Clover', 'White@test.com');
 Select @v_CustomerId =   (SELECT SCOPE_IDENTITY()) ;

 /*Insert Address */
  INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Address Line1', 'Address Line2','Dover','D19901',@v_DEStateId);

 INSERT INTO [dbo].[Customer](FirstName, LastName, EmailAddress)
	VALUES ('Wilman', 'Kala', 'Wilman@GMAIL.com');
 Select @v_CustomerId =   (SELECT SCOPE_IDENTITY()) ;

 /*Insert Address */
  INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Address Line1', 'Address Line2','Wyoming','82001',@v_WisStateId);

  INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Second Address Line1', 'Address Line2','Wyoming','82001',@v_WisStateId);

   INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Third Address Line1', 'Address Line2','Wyoming','82001',@v_WisStateId);

 

 INSERT INTO [dbo].[Customer](FirstName, LastName, EmailAddress)
	VALUES ('Wolski', 'Sam', 'Wolski@gmail.com');
 Select @v_CustomerId =   (SELECT SCOPE_IDENTITY()) ;

 /*Insert Address */
  INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Address Line1', 'Address Line2','Wyoming','82001',@v_WisStateId);

  --Second address
  INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Second Address Line1', 'Second Address Line2','Wyoming','82001',@v_WisStateId);


 INSERT INTO [dbo].[Customer](FirstName, LastName, EmailAddress)
	VALUES ('Cardinal', 'Tom', 'Wolski@test.com');
 Select @v_CustomerId =   (SELECT SCOPE_IDENTITY()) ;

 /*Insert Address */
  INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Address Line1', 'Address Line2','Madison','53558',@v_WisStateId);
	

  INSERT INTO [dbo].[Customer](FirstName, LastName, EmailAddress)
	VALUES ('Hekkan', 'Burger', 'Burger@test.com');
 Select @v_CustomerId =   (SELECT SCOPE_IDENTITY()) ;

 /*Insert Address */
  INSERT INTO [dbo].[Address](CustomerID, Line1, Line2,City,ZipCode,StateId)
	VALUES (@v_CustomerId, 'Address Line1', 'Address Line2','New York','10001',@v_NewYorkStateId);
	
	 
 INSERT INTO [dbo].[Customer](FirstName, LastName, EmailAddress)
	VALUES ('Tom', 'Smith', 'Smith@test.com');
 Select @v_CustomerId =   (SELECT SCOPE_IDENTITY()) ;


 End