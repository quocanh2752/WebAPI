using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Quận, huyện
    public class Districts
    {
        // Mã quận/huyện (Primary Key)
        [Key]
        [MaxLength(20)] // Giới hạn độ dài cho mã quận/huyện
        public string DistrictId { get; set; }

        // Tên quận/huyện
        [Required] // Trường bắt buộc, tương đương với NOT NULL
        [MaxLength(255)] // Giới hạn độ dài của tên
        public string DistrictName { get; set; }

        // Tên tiếng Anh của quận/huyện (có thể để trống)
        [MaxLength(255)] // Giới hạn độ dài của tên tiếng Anh
        public string NameEn { get; set; }

        // Tên đầy đủ của quận/huyện (có thể để trống)
        [MaxLength(255)] // Giới hạn độ dài của tên đầy đủ
        public string FullName { get; set; }

        // Tên đầy đủ bằng tiếng Anh (có thể để trống)
        [MaxLength(255)] // Giới hạn độ dài của tên đầy đủ bằng tiếng Anh
        public string FullNameEn { get; set; }

        // Tên mã (có thể để trống)
        [MaxLength(255)] // Giới hạn độ dài của mã code name
        public string CodeName { get; set; }

        // Mã tỉnh/thành phố (có thể để trống)
        [MaxLength(20)] // Giới hạn độ dài của mã tỉnh/thành phố
        public string ProvinceId { get; set; }

        // ID đơn vị hành chính (có thể để trống)
        public int? AdministrativeUnitId { get; set; }

        // Navigation property to relate districts with NguoiDung
        public virtual ICollection<User> Users { get; set; } = new List<User>();
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
        public virtual ICollection<Company> Company { get; set; } = new List<Company>();
    }
}
