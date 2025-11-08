using System;
using Microsoft.EntityFrameworkCore;
using Project29_Repository_design_pattern_sample.Data.Abstract;
using Project29_Repository_design_pattern_sample.Data.Entities;

namespace Project29_Repository_design_pattern_sample.Data.Concrete;

public class CourseRepository : ICourseRepository
{

   private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
    }

    public void AddToCourse(int studentId, int courseId)
    {
        var addEnrollment = new StudentCourse { StudentId = studentId, CourseId = courseId };
        _context.StudentCourses.Add(addEnrollment);
        _context.SaveChanges();
    }

    public Course GetCourseWithStudents(int courseId)
    {
        var result = _context
            .Courses
            .Include(c => c.StudentCourses)
            .ThenInclude(sc => sc.Student)
            .FirstOrDefault(c => c.Id == courseId);
        return result!;
    }
}
