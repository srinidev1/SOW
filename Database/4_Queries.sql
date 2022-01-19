Use SOW
GO

/* a.	Show all customers with a last name that starts with 'S' */
 Select [CustomerID]
      ,[FirstName]
      ,[LastName]
      ,[EmailAddress]
  From [SOW].[dbo].[Customer] Where LastName Like 'S%';

/*b.	Return a count of customers in Wyoming */
 Select Count(C.CustomerID) AS NumberOfCustomers From [SOW].[dbo].[Customer] C
   Inner Join [SOW].[dbo].[Address] A On C.CustomerID = A.CustomerID
    Where A.City = 'Wyoming';

 /*c.	Set the email address to null for any customers in Madison, WI */
  Update C
	Set C.EmailAddress = Null
  From Customer C
  Inner Join Address A 
    On C.CustomerID = A.CustomerID
  Inner Join State S
   On A.StateId = S.StateID
  Where S.State = 'WI' And A.City = 'Madison';

  /*d.	Select all customers that do not have an address in the system */
  Select C.* From [dbo].[Customer] C
   Left Outer Join [dbo].[Address] A On C.CustomerID = A.CustomerID
    Where A.AddressID Is Null;

 /*e.	Select all customers where the zip code is not all numbers  */
  Select C.* From [dbo].[Customer] C
   Inner Join [dbo].[Address] A On C.CustomerID = A.CustomerID
  Where IsNumeric(A.ZipCode) = 0;

  /* f.	Delete all customers in the state of New York */
  Delete C 
    From [dbo].[Customer] C
  Inner Join Address A 
    On C.CustomerID = A.CustomerID
  Inner Join State S
   On A.StateId = S.StateID
  Where S.State = 'NY';
  
  /*g.	Rank the States based on the number of customers. */
  ;With CustomerCount As
  (
    Select S.State
			,Count(C.CustomerId) As NumberOfCustomers
	  From [dbo].[Customer] C
	  Inner Join Address A 
		On C.CustomerID = A.CustomerID
	  Inner Join State S
	   On A.StateId = S.StateID
	  Group by S.State
  )
  Select State
        ,DENSE_RANK() OVER (ORDER BY CustomerCount.NumberOfCustomers desc) AS [Rank] 
      From  CustomerCount;
  
  /*h.	Select all the customers with gmail-email address  */
  Select * From [dbo].[Customer] C
   Where C.EmailAddress 
   Like '%gmail.com';

   /*i.	Show all the customers who have more than 2 addresses. */
   Select * From [dbo].[Customer] C1
   Inner Join 
	(Select A.CustomerID
	   From [dbo].[Customer] C
	   Inner Join Address A 
		 On C.CustomerID = A.CustomerID
	   Group by A.CustomerID Having Count(*) > 2) A1
   On C1.CustomerID = A1.CustomerID;





