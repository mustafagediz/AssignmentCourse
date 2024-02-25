﻿// Category.cs
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Course> Courses { get; set; }
}