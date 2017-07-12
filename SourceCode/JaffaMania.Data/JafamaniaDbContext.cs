using JaffaMania.Data.DataModel;
using Microsoft.EntityFrameworkCore;

namespace JaffaMania.Data
{
    public class JafamaniaDbContext : DbContext
    {
        public JafamaniaDbContext(DbContextOptions<JafamaniaDbContext> options) : base(options)
        {
        }

        //
        //  Properties:  DbSets

        public DbSet<ContestantDto> Contestants { get; set; }

        public DbSet<AttemptDto> Attempts { get; set; }
    }
}