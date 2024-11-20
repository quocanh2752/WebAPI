using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    //Kĩ năng Công việc
    // Bảng JobSkills
    public class JobSkill
    {
        public int JobSkillId { get; set; } // PK
        public int JobId { get; set; } // FK tới Job
        public int SkillCategoryId { get; set; } // FK tới SkillCategory

        // Quan hệ
        public Job Job { get; set; }
        public SkillCategory SkillCategory { get; set; }
    }


}
