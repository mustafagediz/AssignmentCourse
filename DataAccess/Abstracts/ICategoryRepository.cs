namespace DataAccess.Abstracts;

public interface ICategoryRepository
{
    List<Category> GetAll();
    Category GetById(int id);
    // Diğer CRUD operasyonları
}