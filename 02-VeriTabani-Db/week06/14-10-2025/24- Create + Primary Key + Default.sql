CREATE Table Departments2 (

   Id INTEGER PRIMARY KEY AUTOINCREMENT,
   Name TEXT NOT Null ,
   Location TEXT DEFAULT 'Merkez Ofis' 

)

INSERT INTO Departments2 (Name) VALUES ('Satış'),('IT')