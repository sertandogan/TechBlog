using Application.Interfaces;
using Application.ViewModels;
using Domain.Commands;
using Domain.Interfaces;
using Infrastructure.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMediatorHandler _bus;

        public CategoryService(ICategoryRepository categoryRepository, IMediatorHandler bus)
        {
            _categoryRepository = categoryRepository;
            _bus = bus;
        }

        public void Create(CategoryViewModel categoryViewModel)
        {
            var createCategoryCommand = new CreateCategoryCommand(
                  categoryViewModel.Name
                );

            _bus.SendCommand(createCategoryCommand);
        }

        public CategoryViewModel GetCategories()
        {
            return new CategoryViewModel()
            {
                Categories = _categoryRepository.GetAll().ToList()
            };
        }
    }
}
