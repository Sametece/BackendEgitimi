
SELECT ProductName,UnitsInStock
FROM Products 
-- Where ProductName Like 'c%' -- c ile başlayan ifadeler  
Where ProductName like '%u' -- u ile bitenler
