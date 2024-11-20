using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Phân Quyền
    // Bảng Permissions
    public class Permission
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }
    }

}
