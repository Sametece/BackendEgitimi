-- Having, Group By Whereidir
-- 5 ten fazla müşterisi olan ülkeler hangileridir ? 

Select 
       Country AS [Ülke],
	   count(*) As [Müşteri Sayısı]
	      From Customers  c 
		  Where c.Country is not Null 
		  Group By Country
		  HAVING [Müşteri Sayısı] > 10
		  ORDER By [Müşteri Sayısı] DESC