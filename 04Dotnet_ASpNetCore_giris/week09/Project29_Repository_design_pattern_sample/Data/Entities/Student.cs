using System;

namespace Project29_Repository_design_pattern_sample.Data.Entities;

public class Student
{
 public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    //Navi
    public List<StudentCourse> StudentCourses { get; set; } = [];
}
