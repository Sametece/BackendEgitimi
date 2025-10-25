-- Her Çalışan toplam ne kadarlık satış yapmış 

SELECT 
     e.FirstName || ' ' || e.LastName As 'Calışan',
	 sum(od.UnitPrice * od.Quantity * (1-od.Discount)) AS Tutar
	   FROM 
	   Employees e INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID
	 INNER JOIN [ORDER Details] od ON o.OrderID=od.OrderID
-- Where Fromdan hemen sonra yazılır.	
	GROUP BY Calışan
	 ORDER By Tutar DESC
	   