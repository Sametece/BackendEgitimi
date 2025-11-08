using System;

namespace Project29_Repository_design_pattern_sample.Data.Entities;

public class Course
{
  public int Id { get; set; }

    public string Name { get; set; } = string.Empty;



    // Navi 

    public List<StudentCourse> StudentCourses { get; set; } = [];
}
