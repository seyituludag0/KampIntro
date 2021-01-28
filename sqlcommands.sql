--Çalıştırmak istediğin kodu seçip Execute tuşuna bas.

--ANSII --Bu kodlar Oracle, MySql ve Postegro da da çalışır.

--Sql case insensitive dir (Büyük küçük harf duyarsızdır yani) --Örneğin sElEcT = select 

--select
select * from Products -- (*) bana tüm kolonlarıyla getir demek.

select ContactName from Customers

select ContactName,CompanyName, City from Customers

select ContactName KişiAdi,CompanyName ŞirketAdi, City Şehir from Customers

select * from Customers where City = 'London'

select * from Products where CategoryID = 1 -- Kategori ID isi 1 olan ürünleri getir demek.

select * from Products where CategoryID = 1 or CategoryID=3 -- Kategori ID isi 1 olan ürünleri yada (or) ID isi 3 olan ürünleri getir demek.

select * from Products where CategoryID = 1 and UnitPrice>10 -- Kategori ID isi 1 olan ürünleri ve (and) fiyatları 10 dan büyük olanları getir demek.

-- farklı operatörü <>

SELECT * FROM PRODUCTS ORDER BY PRODUCTNAME -- order by (sırala) demek. Bütün ürünleri seç ama isme göre sırala

select * from Products order by CategoryID, ProductName -- önce categoryId e göre onları da ProductName e göre sırala.

select * from Products order by UnitPrice -- Fiyata göre sırala demek.

select * from Products order by UnitPrice asc --ascending (artan) (defaultu asc)

select * from Products order by UnitPrice desc --descending (azalan)

select * from Products where CategoryID = 1 order by UnitPrice desc 

select Count(*) from Products -- Tüm satırları say demek Count(adet)

select count(*) Adet from Products where CategoryID=2 -- CategoryId si 2 olan tüm ürünlerin sayısını ver demek.

select CategoryID, count(*) UrunAdedi from Products  group by CategoryID

select CategoryID, count(*) UrunAdedi from Products  group by CategoryID having count(*)<10

select CategoryID, count(*) UrunAdedi from Products where UnitPrice>20  group by CategoryID having count(*)<10

--inner join sadece iki tabloda eşleşenleri bir araya getirir. Eşleşmeyen data varsa onu getirmez.
--Her zaman join lerde * ile başla.
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
--Products.CategoryID = Categories.CategoryID birbirine eşitse join et demek

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTO Data Transformation Object

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID
-- Sol (Products) da olup sağ (OrderDetails) da olmayanları getir demek. 
-- Yani Ürünler tablosunda var ama hiç satışı yok demek.

select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID -- hepsi eşleşen datalar.

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null

select * from Products p right join [Order Details] od on p.ProductID = od.ProductID

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join
Orders o on o.OrderID = od.OrderID