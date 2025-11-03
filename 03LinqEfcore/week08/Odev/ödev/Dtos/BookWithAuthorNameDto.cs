using System;

namespace ödev.Dtos;

public class BookWithAuthorNameDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
}
