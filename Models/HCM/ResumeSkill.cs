using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("resume_skills")]
public partial class ResumeSkill
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("resume_id")]
    public long? ResumeId { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_position")]
    [Unicode(false)]
    public string? PersonPosition { get; set; }

    [Column("creator_person_id")]
    public long? CreatorPersonId { get; set; }

    [Column("creator_person_fullname")]
    [Unicode(false)]
    public string? CreatorPersonFullname { get; set; }

    [Column("skill_id")]
    public long? SkillId { get; set; }

    [Column("skill_name")]
    [Unicode(false)]
    public string? SkillName { get; set; }

    [Column("skill_id_with_levels")]
    public long? SkillIdWithLevels { get; set; }

    [Column("level_id")]
    [Unicode(false)]
    public string? LevelId { get; set; }

    [Column("level_name")]
    [Unicode(false)]
    public string? LevelName { get; set; }
}
