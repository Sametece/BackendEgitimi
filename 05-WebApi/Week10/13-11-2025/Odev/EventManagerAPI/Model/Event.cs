using System;
using EventManagerAPI.ValidationAttributes;

namespace EventManagerAPI.Model;

public class Event
{
   public int Id { get; set; }
    
    [MustStartWithUppercase]
   public string Name { get; set; } = string.Empty;
  
  [DescriptionMustNotContainName]
   public string Description { get; set; } = string.Empty;
  
   [NoPastDate]
   public DateTime EventDate { get; set; }


   
}
