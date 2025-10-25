-- Count Adet için Sum Toplama için Avg ortalama min max 

SELECT
  count(*) ,
  sum(od.UnitPrice * od.Quantity*(1-od.Discount)) As 'Toplam Ciro'
  avg(od.UnitPrice * od.Quantity*(1-od.Discount))
From [Order Details] od
