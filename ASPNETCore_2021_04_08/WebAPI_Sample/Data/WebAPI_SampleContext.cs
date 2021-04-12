using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain_Sample.Entities;

namespace WebAPI_Sample.Data
{
    public class WebAPI_SampleContext : DbContext
    {
        public WebAPI_SampleContext (DbContextOptions<WebAPI_SampleContext> options)
            : base(options)
        {
        }

        public DbSet<Domain_Sample.Entities.Blog> Blog { get; set; }
    }
}
