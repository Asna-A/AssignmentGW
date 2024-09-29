Create a table students and insert names in Malayalam

	create table students(id int identity(1,1) primary key,name nvarchar(50));
	insert into students(name) values (N'ആലീസ്'),(N'അനു'),(N'വിജയ്');

Retrieve all employees who work in Sales, Marketing, or IT departments.

	select * from Employees where Department in ('Sales', 'Marketing','IT');

Find all employees with salaries ranging from $50,000 to $75,000 (inclusive).

	select * from Employees where Salary between 50000 and 75000;

List all employees whose last name begins with the letter 'S'.

	select * from Employees where LastName like 'S%';

Display all employees with exactly five letters in their first name.

	select * from Employees where FirstName like '_____';

Find employees whose last name starts with either 'B', 'R', or 'S'.

	select * from Employees where LastName like 'B%' or LastName like 'R%' or LastName like 'S%';

Retrieve all employees whose first name begins with any letter from 'A' through 'M'.

	select * from Employees where FirstName like '[A-M]%'

List employees whose last name doesn't start with a vowel (A, E, I, O, U).

	select * from Employees where LastName like '[^A,E,I,O,U]%'

Identify employees earning more than $80,000 annually. 

	select * from Employees where Salary>80000

Find employees who joined the company before 2020.

	select * from Employees where HireDate<'2020'

List all employees not named 'John' (first name).

	select * from Employees where FirstName!='John'

Identify Marketing department employees earning $60,000 or less who were hired after June 30, 2019.

	select * from Employees where Department='Marketing' 	and Salary<=60000 and HireDate>'2019-6-30'

Find employees whose first name contains the letters 'an' anywhere and ends with 'e'.

	select * from Employees where FirstName='%an%e'

Calculate the total sales amount for each product. Display the ProductID and total sales amount.

select ProductID,Sum(Quantity*UnitPrice) as SalesAmount from Sales  group by(ProductId);

Find the average quantity sold per sale for each product category.
	
	select P.Category,avg(S.Quantity) as average_quantity from Sales S,Products P where S.ProductId=P.Productid group by P.Category; 

List the top 5 customers by their total purchase amount. Include the CustomerID and total purchase amount.

select top 5 CustomerID ,sum(Quantity*unitprice) as total_purchase_amount from Sales group by Customerid order by total_purchase_amount desc

Determine the number of sales made each month in the year 2023. Display the month and the count of sales.

	select month(saledate) as month,count(saleid) as count from sales where year(saledate)='2023' group by month(saledate) 

Calculate the total revenue for each state, but only for states with more than $10,000 in total sales.

	select C.state,sum(S.quantity*S.unitprice) as total_revenue from Sales S,Customers C where C.customerid=S.customerid  group by C.state having sum(S.quantity*S.unitprice)>10000

Find products that have been sold more than 100 times in total. Display the ProductID, ProductName, and the total quantity sold.

	select P.ProductID,P.ProductName,sum(S.quantity) as total_count from Products P ,Sales S where P.productid=S.productid group by P.productid,P.ProductName having sum(quantity)>100

For each customer, find the date of their first purchase and the date of their most recent purchase.

	select C.customerID,min(S.saledate) as firstpurchase,max(S.saledate) as lastpurchase from Customers C ,Sales S where C.customerid=S.customerid group by C.customerid

Find the customers who have made purchases on at least 5 different dates. Display the CustomerID and the count of distinct purchase dates.

	select customerID,count(distinct Saledate) as number_of_saledate from sales group by customerID having count(distinct Saledate)>=5






	
