namespace DataAccess.Abstracts;

public interface ICourseRepository
{
    List<Course> GetAll();
    Course GetById(int id);
    void Add(Course course);
    void Update(Course course);

    void Delete(int id);
}
