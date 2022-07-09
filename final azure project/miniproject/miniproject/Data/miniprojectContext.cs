using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using miniproject.Model;

namespace miniproject.Data
{
    public class miniprojectContext : DbContext
    {
        public miniprojectContext (DbContextOptions<miniprojectContext> options)
            : base(options)
        {
        }

        public DbSet<miniproject.Model.Product> Product { get; set; }
    }
}
