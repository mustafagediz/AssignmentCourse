using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes;

// CategoryManager.cs
public class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
    }

    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public Category GetCategoryById(int id)
    {
        throw new NotImplementedException();
    }
}
