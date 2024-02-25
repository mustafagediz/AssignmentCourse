namespace Business.Abstracts;

public interface IInstructorService
{
    List<Instructor> GetAll();
    Instructor GetInstructorById(int id);
}