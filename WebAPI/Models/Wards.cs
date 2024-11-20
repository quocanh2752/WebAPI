using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Phường
    public class Ward
    {
        [Key]
        public int WardId { get; set; }

        [ForeignKey(nameof(District))]
        public int DistrictId { get; set; }
        public District District { get; set; }

        [Required]
        public string WardName { get; set; }
    }
}
