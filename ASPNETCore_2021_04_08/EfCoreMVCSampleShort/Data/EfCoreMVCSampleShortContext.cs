using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EfCoreMVCSampleShort.Models;

namespace EfCoreMVCSampleShort.Data
{
    public class EfCoreMVCSampleShortContext : DbContext
    {
        public EfCoreMVCSampleShortContext (DbContextOptions<EfCoreMVCSampleShortContext> options)
            : base(options)
        {
        }

        public DbSet<EfCoreMVCSampleShort.Models.Blog> Blog { get; set; }
        public DbSet<EfCoreMVCSampleShort.Models.Comment> Comment { get; set; }
    }
}
