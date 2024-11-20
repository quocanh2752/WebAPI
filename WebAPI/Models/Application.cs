using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Ứng tuyển
    // Bảng Application
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }

        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }
        public Job Job { get; set; }

        [ForeignKey(nameof(JobSeeker))]
        public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        [Required]
        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
