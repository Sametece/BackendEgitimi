--  Hangi çalıan hangi müşterinin siparişini hangi kargo firmasıyla göndermiş ?
-- Çalışan  Müşteri Kargo  Şirketi

SELECT 
e.FirstName || ' ' || e.LastName AS [Çalışan],
c.CompanyName AS [Müşteri],
o.ShipName As [Kargo Şirketi] ,
c.Country AS [ÜLKE] 
      From Orders o
	  INNER JOIN Customers c ON o.CustomerID = c.CustomerID
	  INNER JOIN  Employees e ON o.EmployeeID = e.EmployeeID
	  
Where c.Country = 'Germany'