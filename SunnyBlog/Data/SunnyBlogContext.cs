using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SunnyBlog.Models;

namespace SunnyBlog.Data
{
    public class SunnyBlogContext : DbContext
    {
        public SunnyBlogContext (DbContextOptions<SunnyBlogContext> options)
            : base(options)
        {
        }

        public DbSet<SunnyBlog.Models.BlogContent> BlogContent { get; set; }
    }
}
