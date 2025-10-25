-- fiyatı 100 den büyük olan ürünleri inceleyelim

SELECT ProductName,UnitPrice 
        from Products
		    Where UnitPrice >=100