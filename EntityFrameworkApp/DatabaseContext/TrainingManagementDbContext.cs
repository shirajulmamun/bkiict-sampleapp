using EntityFrameworkApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp.DatabaseContext
{
    public class TrainingManagementDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
