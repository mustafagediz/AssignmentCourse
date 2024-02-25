namespace DataAccess.Abstracts;

public interface IInstructorRepository
{
    List<Course> GetAll();
    Instructor GetById(int id);
}