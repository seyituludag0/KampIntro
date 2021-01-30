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
-- Products.CategoryID = Categories.CategoryID birbirine eşitse join et demek 
-- on demek durumunda şartında

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID


--		Farklı SQL JOIN Türleri
--		İşte SQL'deki farklı JOIN türleri:

--		(INNER) JOIN : Her iki tabloda da eşleşen değerlere sahip kayıtları döndürür

--		LEFT (OUTER) JOIN : Soldaki tablodan tüm kayıtları ve sağ tablodan eşleşen kayıtları döndürür
--		RIGHT (OUTER) JOIN: : Sağ tablodan tüm kayıtları ve soldaki tablodan eşleşen kayıtları döndürür
--		FULL (OUTER) JOIN : Sol veya sağ tabloda bir eşleşme olduğunda tüm kayıtları döndürür



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

SELECT DISTINCT City BirdenFazlaOlup1KereTekrarEdenSehirleri FROM Customers -- Sorgu sonucunda tekrar eden city leri yani (London x2 Berlin x4 gibi gibi) sonuçları 1er tane dönecektir.

SELECT COUNT(DISTINCT City) BirdenFazlaOlup1KereTekrarEdenSehirlerinSayısı from Customers

select * from Customers c where c.CustomerID = 'PARIS'

--			=	Equal					Eşittir
--			>	Greater than			Büyüktür	
--			<	Less than				Küçüktür
--			>=	Greater than or equal	Büyük eşittir
--			<=	Less than or equal		Küçük eşittir
--			<>	Eşit değil. Not: SQL'in bazı sürümlerinde bu operatör! = Olarak yazılabilir. (FARKLI)
--			BETWEEN:	Belirli bir aralık arasında
--			LIKE	
--			IN	Bir sütun için birden çok olası değeri belirtmek için


select * from Products where UnitPrice between 10 and 40

---------------------LIKE
--LIKE operatörü, bir sütundaki belirli bir modeli aramak için bir WHERE yan tümcesinde kullanılır.

--Genellikle LIKE işleci ile birlikte kullanılan iki joker karakter vardır:

--% - Yüzde işareti sıfır, bir veya birden çok karakteri temsil eder
--_ - Alt çizgi tek bir karakteri temsil eder

-- WHERE CustomerName LIKE 'a%'			"A" ile başlayan tüm değerleri bulur
-- WHERE CustomerName LIKE '%a'			"A" ile biten tüm değerleri bulur
-- WHERE CustomerName LIKE '%dev%'		Herhangi bir konumda "dev" bulunan değerleri bulur
-- WHERE CustomerName LIKE '_r%'		İkinci harfi "r" bulunan tüm değerleri bulur
-- WHERE CustomerName LIKE 'a_%'		"A" ile başlayan ve en az 2 karakter uzunluğunda olan tüm değerleri bulur
-- WHERE CustomerName LIKE 'a__%'		"A" ile başlayan ve en az 3 karakter uzunluğunda olan tüm değerleri bulur
-- WHERE ContactName LIKE 'a%o'			"A" ile başlayan ve "o" ile biten tüm değerleri bulur
-- SELECT * FROM Customers WHERE CustomerName NOT LIKE 'a%'			"a" ile başlamayan bir CustomerName'e sahip tüm müşterileri seçer			


select * from Customers where City like 'London'
-- Herhangi bir tablonun içerisinde geçen bir kelimeyi ya da harfi yazdığınızda eşleşen tüm sonuçları listeleyecektir.
-- Yukarıdaki şekilde like kullanımı aslında where ile sorgulama ile aynı mantıkla çalışmaktadır. 
-- City alanının aranılan kelime ile tam olarak eşit olması gerekmektedir.

select * from Customers where City like 'B%'
-- % işareti B harfi ile başlayan tüm kayıtları bize listeler. Kayıtların sadece H harfi ile başlaması gerekmektedir.
--Tam tersi olarak sonu T harfi ile biten kayıtları listelemek isteyebiliriz.

select * from Customers where City like '%t'
-- Burada da % işaretini baş tarafa yazmış olduk. Bu sorgu ile sonu t harfi ile biten tüm kayıtlar listelenecektir.

select * from Products where ProductName LIKE '%x%'
-- Başlangıç değeri ya da bitiş değerine göre değilde içerisinde geçen bir değere göre arama yapmak isteyebilirsiniz.
-- Bunun için arama yapacağınız harf ya da kelimenin başına ve sonuna % ifadesini koymamız gerekecetir.

select * from Products where ProductName LIKE '_i%'
-- _ işareti ile birinci harfin herhangi bir harf olabileceğini belirttik. 2. harfimizin i harfi olduğunu söyledik.

select * from Products where ProductName LIKE '%[xyzj]%' 
-- İçerisinde bu harfler geçen dataları listeler.

SELECT * FROM Customers WHERE Country='Germany' AND (City='Berlin' OR City='München');

insert into Products (ProductName, UnitPrice) values ('Telefon', '1000')

select * from Products  where ProductName like '%fon%'

--UPDATE [tablo adı] SET [yeni bilgiler] WHERE [şartlar]

--UPDATE personel SET bolum='İdari'

update Customers set City= 'Sehir'
--tüm şehir isimlerini Sehir olarak değiştirdi

update Customers set CompanyName = 'Turkey' where City = 'London'
-- where kullanmak zorunlu değil. Where kullanırsak tümünü günceller.

select * from Customers where City like '%London%'

update Products set ProductName = 'Çay' where ProductName = 'Chai'
-- Chai olan dataları Çay olarak güncelledi

update Products set UnitsOnOrder = 2 where UnitsOnOrder = 1

select * from Products where UnitsOnOrder like '2'

delete from Customers where CustomerID = 'PARIS'

select * from Customers where CustomerID like '%PARIS%'

delete from Customers -- Tüm tambloyu siler

select top 3 * from Customers -- Tablonun yukarısından ilk 3 satırını listeler.

select top 50 percent * from Customers
--"Müşteriler" tablosundaki kayıtların ilk% 50'sini seçer

select top 3 * from Customers where City = 'London'

select min (UnitPrice) as EnDüşükÜcret from Products -- (as) alias (takma ad)

select max (UnitPrice) as EnYüksekÜcret from Products

--The COUNT() işlevi, belirtilen bir ölçütle eşleşen satır sayısını döndürür. -- Null değerler sayılmaz.
select count (ProductID) ToplamUrunAdedi from Products

--The AVG() işlevi, sayısal bir sütunun ortalama değerini döndürür. -- Null değerler sayılmaz.
-- tüm ürünlerin ortalama fiyatını bulur
select AVG (UnitPrice)TümÜrünlerinOrtalamaFiyatı from Products

--The SUM() işlevi, bir sayısal sütunun toplamını döndürür.
SELECT SUM(UnitsInStock) ToplamStokAdedi FROM Products

--												 Wildcards

-- % Sıfır veya daha fazla karakteri temsil eder						bl% finds bl, black, blue, and blob
-- _ Tek bir karakteri temsil eder										h_t finds hot, hat, and hit
-- [] Parantez içindeki herhangi bir karakteri temsil eder				h[oa]t finds hot and hat, but not hit
-- ^ Parantez içinde olmayan herhangi bir karakteri temsil eder			h[^oa]t finds hit, but not hot and hat
-- - Bir dizi karakteri temsil eder										c[a-b]t finds cat and cbt


SELECT * FROM Customers WHERE city IN ('Berlin', 'London','Madrid')
 --"Madrid", "Fransa" veya "İngiltere" de bulunan tüm müşterileri seçer

 SELECT * FROM Customers WHERE Country NOT IN ('Germany', 'France', 'UK')
 -- "Almanya", "Fransa" veya "İngiltere" konumunda OLMAYAN tüm müşterileri seçer

 SELECT * FROM Customers WHERE Country IN (SELECT Country FROM Suppliers)
 -- Tedarikçilerle aynı ülkelerden olan tüm müşterileri seçer

 SELECT * FROM Products WHERE Price BETWEEN 10 AND 20 AND CategoryID NOT IN (1,2,3)
-- Fiyatı 10 ile 20 ARASINDA olan tüm ürünleri seçer. Ayrıca; Kategori Kimliği 1,2 veya 3 olan ürünleri gösterme

SELECT City FROM Customers UNION SELECT City FROM Suppliers ORDER BY City
-- hem "Müşteriler" hem de "Tedarikçiler" tablosundaki şehirleri (yalnızca farklı değerler) döndürür

SELECT City FROM Customers UNION ALL SELECT City FROM Suppliers ORDER BY City
--hem "Müşteriler" hem de "Tedarikçiler" tablosundaki şehirleri (yinelenen değerler) döndürür

SELECT City, Country FROM Customers WHERE Country='Germany' UNION SELECT City, Country FROM Suppliers 
WHERE Country='Germany'
ORDER BY City
-- hem "Müşteriler" hem de "Tedarikçiler" tablosundan Alman şehirlerini (yalnızca farklı değerler) döndürür

