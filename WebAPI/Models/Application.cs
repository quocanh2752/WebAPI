using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Ứng tuyển
    public class Application
    {
        // Khóa chính (Primary Key)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }

        // Khóa ngoại kiểu int trỏ tới Công việc
        [Required(ErrorMessage = "ID công việc không được để trống.")]
        public int JobId { get; set; }

        // Navigation property cho CongViec
        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }

        // Khóa ngoại kiểu int trỏ tới NguoiTimViec
        [Required(ErrorMessage = "NguoiTimViecId không được để trống.")]
        public int JobSeekerId { get; set; }

        // Navigation property cho NguoiTimViec
        [ForeignKey("JobSeekerId")]
        public virtual JobSeeker JobSeeker { get; set; }

        // Ngày ứng tuyển
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        // Đề xuất của người ứng tuyển (có thể nullable)
        [MaxLength(500, ErrorMessage = "Đề xuất không được vượt quá 500 ký tự.")]
        public string? Proposal { get; set; }

        // Trạng thái ứng tuyển (vd: đang xem xét, đã chấp nhận, từ chối)
        [MaxLength(20)]
        public string Status { get; set; } = "Đang xem xét";

        // Chấp nhận công việc hay không
        public bool JobAccept { get; set; } = false;

        // Navigation property cho DanhGia (quan hệ một-nhiều)
        public virtual ICollection<Review> Review { get; set; } = new List<Review>();

    }
}
