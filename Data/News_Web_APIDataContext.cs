using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using News_Web_API.Model;

namespace News_Web_API.Models
{
    public class News_Web_APIDataContext : DbContext
    {
        public News_Web_APIDataContext (DbContextOptions<News_Web_APIDataContext> options)
            : base(options)
        {
        }

        public DbSet<News_Web_API.Model.Report> Report { get; set; }
    }
}
