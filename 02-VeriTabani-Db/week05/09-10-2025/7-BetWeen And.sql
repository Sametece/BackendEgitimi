-- Fiyatı 20 ile 50 arasındakileri göster
Select ProductName,UnitPrice
From Products 
-- Where UnitPrice >=20 AND UnitPrice<=50
WHERE UnitPrice BEETWEEN 20 AND 50
ORDER BY UnitPrice