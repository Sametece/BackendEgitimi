--2017 - 2018 yıllarındaki siparişleri listeleylim.

SELECT 
    OrderID,
	CustomerID,
	OrderDate 
	 FROM Orders
	     WHERE OrderDate >= '2017-01-01' AND OrderDate<='2018-12-31' AND CustomerID ='LINOD'
		 ORDER BY OrderDate