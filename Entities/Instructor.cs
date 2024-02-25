// Instructor.cs
public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Course> Courses { get; set; }
}