using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationRESTSkilet.Models
{
    public class SolutionContext : DbContext
    {
        public SolutionContext(DbContextOptions<SolutionContext> options) : base(options)
        {

        }

        public DbSet<SolutionItem> SolutionItems { get; set; }
    }

}
