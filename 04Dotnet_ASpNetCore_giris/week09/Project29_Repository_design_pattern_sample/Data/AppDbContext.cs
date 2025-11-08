using System;
using Microsoft.EntityFrameworkCore;
using Project29_Repository_design_pattern_sample.Data.Entities;

namespace Project29_Repository_design_pattern_sample.Data;

public class AppDbContext:DbContext
{
   public DbSet<Course> Courses { get; set; }
   
   public DbSet<Student> Students { get; set; }

   public DbSet<StudentCourse> StudentCourses { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=RepositoryDesignPattern.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        List<Student> students = [
            new() { Id=1, FullName="Öğrenci 1"},
            new() { Id=2, FullName="Öğrenci 2"},
            new() { Id=3, FullName="Öğrenci 3"},
            new() { Id=4, FullName="Öğrenci 4"}
        ];
        List<Course> courses = [
            new() { Id=101, Name="Kurs 1"},
            new() { Id=102, Name="Kurs 2"},
            new() { Id=103, Name="Kurs 3"},
            new() { Id=104, Name="Kurs 4"}
        ];
        List<StudentCourse> studentCourses = [
            new() { StudentId=1, CourseId=101 },
            new() { StudentId=1, CourseId=102},
            new() { StudentId=1, CourseId=103},

            new() { StudentId=2, CourseId=101},

            new() { StudentId=3, CourseId=102},
            new() { StudentId=3, CourseId=103},

            new() { StudentId=4, CourseId=103},
            new() { StudentId=4, CourseId=104},
            new() { StudentId=4, CourseId=102}
        ];
        modelBuilder.Entity<Student>().HasData(students);
        modelBuilder.Entity<Course>().HasData(courses);
        modelBuilder.Entity<StudentCourse>().HasData(studentCourses);
    }
}
