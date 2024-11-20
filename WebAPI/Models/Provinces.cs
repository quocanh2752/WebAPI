using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Tỉnh
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }

        [Required]
        public string ProvinceName { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}
