namespace Business.Abstracts;

public interface ICategoryService
{
    List<Category> GetAll();
    Category GetCategoryById(int id);
}