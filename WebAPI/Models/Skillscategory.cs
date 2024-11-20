namespace WebAPI.Models
{
    //Danh mục kĩ năng
    public class SkillCategory
    {
        public int SkillCategoryId { get; set; } // PK
        public string SkillName { get; set; } // Tên kỹ năng
        public string Description { get; set; } // Mô tả kỹ năng (nếu cần)

        // Quan hệ
        public ICollection<ApplicantSkill> ApplicantSkills { get; set; }
        public ICollection<JobSkill> JobSkills { get; set; }
    }

}
