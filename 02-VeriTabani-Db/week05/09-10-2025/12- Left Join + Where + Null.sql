-- Hiç Sipariş Vermemiş Müşterileri Sıralayalım
SELECT 
   c.CompanyName , o.OrderID
      From Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
	  WHERE o.OrderID is NULL
	  