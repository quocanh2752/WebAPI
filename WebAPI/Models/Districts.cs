using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    //Quận, huyện
    public class District
    {
        [Key]
        public int DistrictId { get; set; }

        [ForeignKey(nameof(Province))]
        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        [Required]
        public string DistrictName { get; set; }

        public ICollection<Ward> Wards { get; set; }
    }
}
