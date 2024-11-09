using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
namespace WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ApplicantSkills> ApplicantSkills { get; set; }

        public DbSet<Application> Application { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Districts> Districts { get; set; }

        public DbSet<Job> Job { get; set; }

        public DbSet<jobSeekers> JobSeekers { get; set; }

        public DbSet<JobSkills> JobSkills { get; set; }

        public DbSet<Notification> Notification { get; set; }

        public DbSet<Permissions> Permissions { get; set; }

        public DbSet<Provinces> Provinces { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Skillscategory> skillscategories {  get; set; }
        
        public DbSet<User> Users { get; set; }
        
        public DbSet<Wards> Wards { get; set; }

        
    }
}
