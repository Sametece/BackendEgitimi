-- hangi siparişi hangi müşteri vermiş

SELECT o.OrderID,o.OrderDate,c.CompanyName
      FROM Orders o INNER JOIN Customers c 
	  ON o.CustomerID = c.CustomerID
	  ORDER By c.CompanyName