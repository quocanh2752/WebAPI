using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebAPI.Models
{
    //Công việc
    // Bảng Job
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [ForeignKey(nameof(User))]
        public int EmployerId { get; set; }
        public User Employer { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public string Requirements { get; set; }
        public string SalaryRange { get; set; }

        [ForeignKey(nameof(District))]
        public int DistrictId { get; set; }
        public District District { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<JobSkill> JobSkills { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
