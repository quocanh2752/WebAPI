using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebAPI.Models
{
    //Công việc
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        // Khóa ngoại liên kết đến bảng DoanhNghiep
        [Required]
        public int CompanyId { get; set; }

        // Navigation property để liên kết đến DoanhNghiep
        [ForeignKey("BusinessId")]
        public virtual Company Company { get; set; }

        // Tiêu đề công việc
        [MaxLength(200)]
        [Required(ErrorMessage = "Job title cannot be empty.")]
        public string Title { get; set; }

        // Mô tả công việc (nullable)
        public string? Description { get; set; }

        // Lương hàng tháng
        [Range(0, double.MaxValue, ErrorMessage = "Monthly salary must be greater than or equal to 0.")]
        public decimal MonthlySalary { get; set; }

        // Vị trí
        [MaxLength(100)]
        public string? Position { get; set; }

        // Trạng thái công việc
        [MaxLength(50)]
        [DefaultValue("Hiring")]
        public string Status { get; set; } = "Hiring";

        // Ngày đăng tin
        public DateTime PostedDate { get; set; } = DateTime.Now;

        // Hạn nộp hồ sơ
        public DateTime? ApplicationDeadline { get; set; }

        // Navigation property cho các ứng tuyển
        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

        // Navigation properties cho các địa điểm
        // Navigation properties for address relationships
        public string? DistrictId { get; set; } // Foreign key for districts
        public string? WardId { get; set; } // Foreign key for wards
        public string? ProvinceId { get; set; } // Foreign key for provinces

        // Navigation properties cho địa chỉ
        [ForeignKey("DistrictId")]
        public virtual Districts Districts { get; set; }

        [ForeignKey("WardId")]
        public virtual Wards Wards { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Provinces Provinces { get; set; }

        // Collection for skills related to the job
        public virtual ICollection<JobSkills> JobSkills { get; set; } = new List<JobSkills>();

    }
}
