Select * 
      From Products p
	  Where p.UnitPrice >  (Select avg(UnitPrice) from Products)