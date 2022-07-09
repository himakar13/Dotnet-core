using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBaseTest_5.Models;

namespace CodeBaseTest_5.Data
{
    public class CodeBaseTest_5Context : DbContext
    {
        public CodeBaseTest_5Context (DbContextOptions<CodeBaseTest_5Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBaseTest_5.Models.Students> Students { get; set; }
    }
}
