CREATE PROCEDURE [dbo].[Bom_JW_CusSelect Procedure]
	@CustomersName Nvarchar(30)
	
AS
	select Customers_Order.Cus_Order_OrderNo,Customers.Cus_ID, Employees.Emp_Name, Products.Pro_Name,Customers_Order.Cus_Order_Price, Customers_Order.Cus_Order_EA, Customers_Order.Cus_Order_Date, Customers_Order.Cus_OrderComplete
from Customers_Order 
left JOIN Customers ON Customers_Order.Cus_ID = Customers.Cus_No 
left JOIN Products on Customers_Order.Pro_No = Products.Pro_No
left Join Employees on Customers_Order.Emp_No = Employees.Emp_No
where Customers.Cus_ID = @CustomersName

go
CREATE PROCEDURE [dbo].[Bom_JW_DateSelect Procedure]
	@Date1 Nvarchar(30),
	@Date2 nvarchar(30)	
AS
	select Customers_Order.Cus_Order_OrderNo,Customers.Cus_ID, Employees.Emp_Name, Products.Pro_Name,Customers_Order.Cus_Order_Price, Customers_Order.Cus_Order_EA, Customers_Order.Cus_Order_Date, Customers_Order.Cus_OrderComplete
from Customers_Order 
left JOIN Customers ON Customers_Order.Cus_ID = Customers.Cus_No 
left JOIN Products on Customers_Order.Pro_No = Products.Pro_No
left Join Employees on Customers_Order.Emp_No = Employees.Emp_No
where Customers_Order.Cus_Order_Date > @Date1 and Customers_Order.Cus_Order_Date < @Date2

go
CREATE PROCEDURE [dbo].[Bom_JW_ProNameSelect]	
AS
	select Pro_name from Products

go
CREATE PROCEDURE [dbo].[Bom_JW_ProNameSelect2]	
AS
	select Pro_name, Pro_Price from Products

go
CREATE PROCEDURE [dbo].[Bom_JW_ProSelect Procedure]
	@ProductsName Nvarchar(30)	
AS
	select Customers_Order.Cus_Order_OrderNo,Customers.Cus_ID, Employees.Emp_Name, Products.Pro_Name,Customers_Order.Cus_Order_Price, Customers_Order.Cus_Order_EA, Customers_Order.Cus_Order_Date, Customers_Order.Cus_OrderComplete
from Customers_Order 
left JOIN Customers ON Customers_Order.Cus_ID = Customers.Cus_No 
left JOIN Products on Customers_Order.Pro_No = Products.Pro_No
left Join Employees on Customers_Order.Emp_No = Employees.Emp_No
where Products.Pro_Name = @ProductsName

go
CREATE PROCEDURE [dbo].[Bom_JW_ProPriceChinge_Procedure]
	@ProName nvarchar (30), 
	@Price int,
	@ChaingeDate DateTime
AS
	update Products 
	set Pro_Price =@Price, Pro_ChaingePriceDate = @ChaingeDate
	where Pro_Name = @ProName
