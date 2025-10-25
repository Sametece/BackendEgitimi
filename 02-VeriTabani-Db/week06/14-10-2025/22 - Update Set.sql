-- UPDATE Komutu Asla Where olmadan Kullanılmamalıdır.
-- 80 ıd li organic Tofu3 ürünümüzün QuantityPerUnit kolonuna bilgi gireceğiz.
-- yani ilgili kaydı  güncelleyeceğiz

UPDATE Products 
       SET QuantityPerUnit = '12-550 ml bottles'
	      Where ProductID = 80

		  
UPDATE Products 
      Set UnitPrice = UnitPrice * 1.20