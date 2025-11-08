using System;
using Project29_Repository_design_pattern_sample.Data.Entities;

namespace Project29_Repository_design_pattern_sample.Data.Abstract;

public interface ICourseRepository
{
// Course ile ilgili yapılabilecek DB işlemlerini burada belirliyoruz.
    void Add(Course course);
    void AddToCourse(int studentId, int courseId);
    Course GetCourseWithStudents(int courseId);
    // void Update(Course course);
    // void Delete(int courseId);
    // void RemoveFromCourse(int studentId, int courseId);
}
