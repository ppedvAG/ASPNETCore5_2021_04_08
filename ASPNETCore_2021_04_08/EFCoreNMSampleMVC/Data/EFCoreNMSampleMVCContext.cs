using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCoreNMSampleMVC.Models;

namespace EFCoreNMSampleMVC.Data
{
    public class EFCoreNMSampleMVCContext : DbContext
    {
        public EFCoreNMSampleMVCContext (DbContextOptions<EFCoreNMSampleMVCContext> options)
            : base(options)
        {
        }

        public DbSet<EFCoreNMSampleMVC.Models.Author> Author { get; set; }
    }
}
