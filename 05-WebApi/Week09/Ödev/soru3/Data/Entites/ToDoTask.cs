using System;

namespace soru3.Data.Entites;

public class ToDoTask
{
   public int Id { get; set; }

   public string? Title { get; set; }

   public string? Description { get; set; }

   public bool IsCompleted { get; set; }

   public DateTime DueDate { get; set; }
}
