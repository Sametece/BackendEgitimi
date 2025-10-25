SELECT 
    c.City , count(*) AS 'Müşteri Sayısı'
From Customers c 
GROUP By c.Country
ORDER By count (*) DESC