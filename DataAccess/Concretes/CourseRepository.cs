using DataAccess.Abstracts;

namespace DataAccess.Concretes;

public class CourseRepository:ICourseRepository
{
    private List<Course> _courses; // Örnek bir veritabanı simulasyonu için

    public CourseRepository()
    {
        _courses = new List<Course>();
        // Örnek verileri ekleyebilirsiniz
        _courses.Add(new Course { Id = 1, Title = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)", Year = 2022, CategoryId = 1, InstructorId = 1 });
        _courses.Add(new Course { Id = 2, Title = "Yazılım Geliştirici Yetiştirme Kampı (ANGULAR)", Year = 2022, CategoryId = 2, InstructorId = 2 });
        _courses.Add(new Course { Id = 3, Title = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)", Year = 2023, CategoryId = 1, InstructorId = 1 });
        _courses.Add(new Course { Id = 4, Title = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA", Year = 2022, CategoryId = 1, InstructorId = 1 });
        _courses.Add(new Course { Id = 5, Title = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", Year = 2022, CategoryId = 2, InstructorId = 2 });
        _courses.Add(new Course { Id = 6, Title = "Yazılım Geliştirici Yetiştirme Kampı (JAVA - REACT)", Year = 2022, CategoryId = 1, InstructorId = 1 });
        _courses.Add(new Course { Id = 7, Title = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", Year = 2024, CategoryId = 1, InstructorId = 1 });
        _courses.Add(new Course { Id = 8, Title = "Programlamaya Giriş için Temel Kurs", Year = 2022, CategoryId = 2, InstructorId = 2 });

    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course GetById(int id)
    {
        return _courses.FirstOrDefault(c => c.Id == id);
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Update(Course course)
    {
        var existingCourse = _courses.FirstOrDefault(c => c.Id == course.Id);
        if (existingCourse != null)
        {
            existingCourse.Title = course.Title;
            existingCourse.Year = course.Year;
            existingCourse.CategoryId = course.CategoryId;
            existingCourse.InstructorId = course.InstructorId;
        }
    }

    public void Delete(int id)
    {
        var courseToRemove = _courses.FirstOrDefault(c => c.Id == id);
        if (courseToRemove != null)
        {
            _courses.Remove(courseToRemove);
        }
    }
}