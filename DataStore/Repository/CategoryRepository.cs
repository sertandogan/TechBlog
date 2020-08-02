using DataStore.Repository.Base;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly TechBlogDbContext _context;
        public CategoryRepository(TechBlogDbContext context) : base(context)
        {
            _context = context;
        }

        public Category GetCategory(int id)
        {
            return _context.Set<Category>().Find(id);
        }

    }
}
