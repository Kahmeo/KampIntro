--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * From Customers where City = 'Berlin'

--case insensitive
seLeCt * fRom Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by UnitPrice

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice desc --ascending --descending

select count(*) Adet from Products

select count(*) Adet from Products where CategoryID=1

select categoryID,count(*) from products where UnitPrice>20
	group by categoryID having count(*)<10

 select Products.ProductID,Products.ProductName,
			Products.UnitPrice,Categories.CategoryName 
	from products inner join Categories 
		on Products.CategoryID = Categories.CategoryID
			where products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od
	on p.ProductID = od.ProductID

select * from Products p left join [Order Details] od
	on p.ProductID = od.ProductID

select * from Customers c left join Orders o
	on c.CustomerID = o.CustomerID
		where o.CustomerID is null

select * from Products p inner join [Order Details] od
	on p.ProductID = od.ProductID
		inner join Orders o 
			on o.OrderID = od.OrderID





