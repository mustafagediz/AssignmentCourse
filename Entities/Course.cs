// Course.cs
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public int? CategoryId { get; set; }
    public int? InstructorId { get; set; }

    public virtual Category Category { get; set; }
    public virtual Instructor Instructor { get; set; }
}
