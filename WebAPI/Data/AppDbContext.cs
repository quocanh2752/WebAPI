using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
namespace WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Các DbSet hiện tại
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicantSkill> ApplicantSkills { get; set; }
        public DbSet<JobSkill> JobSkills { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }

        // Thêm các DbSet mới
        public DbSet<Employer> Employers { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thêm cấu hình cho các bảng mới nếu cần
            modelBuilder.Entity<Employer>(entity =>
            {
                entity.HasKey(e => e.EmployerId);

                entity.HasOne(e => e.User)
                    .WithOne()
                    .HasForeignKey<Employer>(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Address)
                    .HasMaxLength(300);

                entity.Property(e => e.WebsiteUrl)
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<SkillCategory>(entity =>
            {
                entity.HasKey(sc => sc.SkillCategoryId);

                entity.Property(sc => sc.SkillName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(sc => sc.Description)
                    .HasMaxLength(300);
            });

            // Seed dữ liệu nếu cần
            modelBuilder.Entity<Permission>().HasData(
                new Permission { RoleId = 1, RoleName = "Admin" },
                new Permission { RoleId = 2, RoleName = "Doanh nghiệp" },
                new Permission { RoleId = 3, RoleName = "Người tìm việc" }
            );
        }
    }
}