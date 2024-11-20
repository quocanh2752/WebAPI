using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Đánh giá
    // Bảng Review
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }
        public Job Job { get; set; }

        [ForeignKey(nameof(JobSeeker))]
        public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
