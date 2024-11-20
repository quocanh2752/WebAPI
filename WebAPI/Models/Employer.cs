using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Doanh nghiệp
    public class Employer
    {
        public int EmployerId { get; set; } // PK
        public int UserId { get; set; } // FK tới User

        public string CompanyName { get; set; } // Tên công ty
        public string CompanyDescription { get; set; } // Mô tả công ty
        public string Address { get; set; } // Địa chỉ
        public string WebsiteUrl { get; set; } // Đường dẫn website
        public DateTime CreatedAt { get; set; } // Ngày tạo

        // Quan hệ
        public User User { get; set; } // Navigation property
    }
}
