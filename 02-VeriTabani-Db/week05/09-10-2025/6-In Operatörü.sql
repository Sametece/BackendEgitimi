-- Almanya Fransa ve İngilteredeki Müşteriler

SELECT CompanyName, Country
   From Customers
  -- Where Country = 'Germany' Or Country ='France' OR Country ='UK'
 Where Country IN('Germany','France','UK')