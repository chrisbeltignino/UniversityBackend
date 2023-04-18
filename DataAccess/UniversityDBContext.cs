using Microsoft.EntityFrameworkCore;
using UniversityBackend.Models.DataModels;

namespace UniversityBackend.DataAccess
{
    public class UniversityDBContext : DbContext 
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }

        // 1. Add DBSets (Tables of our Data Base)
        public DbSet<User>? Users { get; set; }

    }
}
