using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Người tìm việc
    // Bảng JobSeeker
    public class JobSeeker
    {
        [Key]
        public int JobSeekerId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        public string ProfileSummary { get; set; }
        public string ResumeUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<ApplicantSkill> ApplicantSkills { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
