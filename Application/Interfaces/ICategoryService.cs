using Application.ViewModels;

namespace Application.Interfaces
{
    public interface ICategoryService
    {
        CategoryViewModel GetCategories();
        void Create(CategoryViewModel categoryViewModel);
    }
}
