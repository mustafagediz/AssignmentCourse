using DataAccess.Abstracts;

namespace DataAccess.Concretes;

public class InstructorRepository:IInstructorRepository
{
    public List<Course> GetAll()
    {
        throw new NotImplementedException();
    }

    public Instructor GetById(int id)
    {
        throw new NotImplementedException();
    }
}