-- JOIN
-- INNER JOIN : Birleştirilicek olan her iki tablodaki eşleşen kayıtları getir.
-- Hangi Ürün hangi Kategoride

Select p.ProductName,c.CategoryName AS 'Kategori Ad'
      FROM Products p INNER JOIN Categories c 
	  On p.CategoryID = c.CategoryID