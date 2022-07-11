using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_evaluation_code.Models;

namespace Final_evaluation_code.Data
{
    public class Final_evaluation_codeContext : DbContext
    {
        public Final_evaluation_codeContext (DbContextOptions<Final_evaluation_codeContext> options)
            : base(options)
        {
        }

        public DbSet<Final_evaluation_code.Models.Employee> Employee { get; set; }
    }
}
