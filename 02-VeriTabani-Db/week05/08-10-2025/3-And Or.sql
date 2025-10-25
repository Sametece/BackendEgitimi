-- sipariş tarihi belirli bir tarihden sonra olan siparişleri inceleyelim.

SELECT 
    OrderID,
	CustomerID,
	OrderDate 
	 FROM Orders
	     WHERE OrderDate >= '2023-01-01' AND CustomerID= 'ROMEY'
      