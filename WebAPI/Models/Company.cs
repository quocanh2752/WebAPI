using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Doanh nghiệp
    public class Company
    {
        // Khóa chính (Primary Key)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        // Hình ảnh của doanh nghiệp (nullable)
        public string? Image { get; set; }

        // Khóa ngoại liên kết đến NguoiDung
        [Required] // Assuming each business must have an associated user
        public int UserId { get; set; }

        // Navigation property để liên kết đến NguoiDung
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        // Tên công ty
        [MaxLength(100)]
        [Required(ErrorMessage = "Tên công ty không được để trống.")]
        public string CompanyName { get; set; }

        // Mô tả công ty (có thể nullable)
        public string? Description { get; set; }

        // Địa chỉ công ty (có thể nullable)
        [MaxLength(200)]
        public string? Address { get; set; }

        // Navigation property cho các công việc của doanh nghiệp
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

        // Khóa ngoại cho địa chỉ
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
    }
}
