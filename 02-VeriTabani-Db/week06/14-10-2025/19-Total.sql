
-- Toplam Satışı 50.000.000 den fazla olan çalışanları göster

SELECT 
    e.FirstName || ' ' || e.LastName AS Calisan,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS Tutar
FROM Employees e
INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID
INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY e.FirstName, e.LastName
HAVING SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) >= 50000000
ORDER BY Tutar DESC;
