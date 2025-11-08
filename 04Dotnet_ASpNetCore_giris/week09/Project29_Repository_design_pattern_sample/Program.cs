using Project29_Repository_design_pattern_sample.Data;
using Project29_Repository_design_pattern_sample.Data.Abstract;
using Project29_Repository_design_pattern_sample.Data.Concrete;
using Project29_Repository_design_pattern_sample.Data.Entities;

namespace Project29_Repository_design_pattern_sample;

class Program
{
    static void Main(string[] args)
    {
       using var context = new AppDbContext();
        ICourseRepository courseRepository = new CourseRepository(context);
        // IStudentRepository studentRepository = new StudentRepository(context);

        Console.WriteLine("..... Kurs Yönetim Sistemi .....");
        // courseRepository.Add(new Course { Name = "Web API Geliştirme" });
        // courseRepository.AddToCourse(1, 105);
        var course = courseRepository.GetCourseWithStudents(102);
        Console.WriteLine(course.Name);
        foreach (var studentCourse in course.StudentCourses)
        {
            Console.WriteLine(studentCourse.Student!.FullName);
        }
    }
}
