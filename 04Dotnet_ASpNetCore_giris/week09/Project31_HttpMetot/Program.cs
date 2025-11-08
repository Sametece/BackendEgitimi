using Project31_HttpMetot;

var builder = WebApplication.CreateBuilder(args);

// DI Container 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

List<Book> books = [
    new(){Id=1, Title="Suç ve Ceza", Author="Fyodor Dostoyevski"},
    new(){Id=2, Title="Yabancı", Author="Albert Camus"}
];

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

// Tüm kitapları getirme endpoint'i
app.MapGet("/api/books", () => Results.Ok(books));//Kitaplarla birlikte Status Code 200 döndür

// Id'ye göre tek bir kitap getirme endpoint'i
app.MapGet("/api/books/{id}", (int id) =>
{
    var book = books.FirstOrDefault(b => b.Id == id);
    // if (book == null)
    // {
    //     return Results.NotFound("Kitap bulunamadı!");//Kitap bulunamadığı için Status Code 404 döndür
    // }
    // return Results.Ok(book);//Kitapla birlikte Status Code 200 döndür
    return book == null ? Results.NotFound(new { Message = "Kitap Bulunumadı!" }) : Results.Ok(book);

});


// Yeni bir kitap yaratma endopointi
app.MapPost("/api/books", (Book newBook) =>
{
    var bookToCreate = new Book
    {
        Id = books.Count != 0 ? books.Max(b => b.Id) + 1 : 1,
        Title = newBook.Title,
        Author = newBook.Author
    };
    books.Add(bookToCreate);
    return Results.Created($"/api/books/{bookToCreate.Id}", bookToCreate);// Oluşturulan book bilgisi ile Status Code 201 döndür
});

// Var olan bir kitabı güncelleme endpointi
app.MapPut("/api/books/{id}", (int id, Book updatedBook) =>
{
    var bookToUpdate = books.FirstOrDefault(b => b.Id == id);
    if (bookToUpdate == null) return Results.NotFound();
    bookToUpdate.Title = updatedBook.Title;
    bookToUpdate.Author = updatedBook.Author;
    return Results.NoContent();// Status Code 204 döndür
});

// Bir kitabı silme endpointi
app.MapDelete("/api/books/{id}", (int id) =>
{
    var bookToDelete = books.FirstOrDefault(b => b.Id == id);
    if (bookToDelete != null)
    {
        books.Remove(bookToDelete);
        return Results.Ok(new { Message = $"{id} id'li kitap silindi!" });
    }
    return Results.NotFound(new {Merve=$"{id} id'li kitap bulunamadığı için silme işlemi gerçekleşmedi!"});
});


app.Run();