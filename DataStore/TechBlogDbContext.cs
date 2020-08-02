using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
    public class TechBlogDbContext : DbContext
    {
        public TechBlogDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Category { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<CategoryPost> CategoryPost { get; set; }

    }
}
