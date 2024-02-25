using DataAccess.Abstracts;

namespace Business.Concretes;

// CourseManager.cs
public class CourseManager : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public CourseManager(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
    }

    public List<Course> GetAllCourses()
    {
        return _courseRepository.GetAll();
    }

    public Course GetCourseById(int id)
    {
        return _courseRepository.GetById(id);
    }

    public void AddCourse(Course course)
    {
        // İş kuralları, validation kontrolleri vs. eklenebilir
        _courseRepository.Add(course);
    }

    public void UpdateCourse(Course course)
    {
        _courseRepository.Update(course);
    }

    public void DeleteCourse(int id)
    {
        _courseRepository.Delete(id);
    }
}

