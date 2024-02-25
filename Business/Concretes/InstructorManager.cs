// InstructorManager.cs
using Business.Abstracts;
using DataAccess.Abstracts;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorRepository _instructorRepository;

    public InstructorManager(IInstructorRepository instructorRepository)
    {
        _instructorRepository = instructorRepository ?? throw new ArgumentNullException(nameof(instructorRepository));
    }
    public List<Instructor> GetAll()
    {
        throw new NotImplementedException();
    }

    public Instructor GetInstructorById(int id)
    {
        throw new NotImplementedException();
    }
}
