using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Kĩ năng ứng tuyển
    // Bảng ApplicantSkills
    public class ApplicantSkill
    {
        public int ApplicantSkillId { get; set; } // PK
        public int JobSeekerId { get; set; } // FK tới JobSeeker
        public int SkillCategoryId { get; set; } // FK tới SkillCategory

        // Quan hệ
        public JobSeeker JobSeeker { get; set; }
        public SkillCategory SkillCategory { get; set; }
    }


}
