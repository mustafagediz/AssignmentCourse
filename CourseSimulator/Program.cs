using System;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;

namespace CourseManagementSystem.CourseSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dependency Injection kullanılarak servislerin oluşturulması
            ICourseService courseService = new CourseManager(new CourseRepository());
            ICategoryService categoryService = new CategoryManager(new CategoryRepository());
            IInstructorService instructorService = new InstructorManager(new InstructorRepository());

            // Örnek verilerle kurs oluşturma
            Course newCourse = new Course
            {
                Title = "Yeni Kurs",
                Year = 2024,
                CategoryId = 1, // Örnek bir kategori ID'si
                InstructorId = 1 // Örnek bir eğitmen ID'si
            };

            // Kurs ekleme
            courseService.AddCourse(newCourse);
            Console.WriteLine("Yeni kurs eklendi. Kurs Adı: " + newCourse.Title);

            // Tüm kursları getirme
            var allCourses = courseService.GetAllCourses();
            Console.WriteLine("\nTüm Kurslar:");
            foreach (var course in allCourses)
            {
                Console.WriteLine($"{course.Title} - {course.Year}");
            }

            // Kurs güncelleme
            var courseToUpdate = courseService.GetCourseById(1); // Örnek bir kurs ID'si
            if (courseToUpdate != null)
            {
                courseToUpdate.Title = "Güncellenmiş Kurs Adı";
                courseService.UpdateCourse(courseToUpdate);
                Console.WriteLine("\nKurs güncellendi. Güncellenmiş Kurs Adı: " + courseToUpdate.Title);
            }

            // Kurs silme
            int courseIdToDelete = 2; // Örnek bir kurs ID'si
            courseService.DeleteCourse(courseIdToDelete);
            Console.WriteLine($"\nKurs silindi. Kurs ID: {courseIdToDelete}");

            Console.WriteLine("\nSimülasyon Başarıyla Tamamlandı!");
        }
    }
}
