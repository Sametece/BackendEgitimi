-- Hiç ürün olmayan kategorileri listele

Select c.CategoryName , p.ProductName 
     From Categories c LEFT JOIN Products p On c.CategoryID = p.CategoryID
	 Where p.CategoryID is NULL
	 
-- Hiç satışı yapılmayan kategorileri göster

SELECT c.CategoryName, o.OrderID
      From [ORDER Details] od 
	  INNER JOIN Orders o ON o.OrderID = od.OrderID
	  INNER JOIN Products p ON od.ProductID = p.ProductID
	  INNER JOIN Categories c ON c.CategoryID = p.CategoryID
Where o.OrderID is NULL