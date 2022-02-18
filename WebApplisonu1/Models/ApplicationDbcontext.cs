using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebApplisonu1.Models
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options) : base(options) { }
        public DbSet<Custmore> Custmores { get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
