using Microsoft.EntityFrameworkCore;
using WarpMe.Data.Models;

namespace WarpMe.Data
{
    public class AppDbContext : DbContext
    {
        // Database Tables
        public DbSet<LinkItem> LinkItems { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<ProfileTheme> ProfileThemes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}
