using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("position_familys")]
public partial class PositionFamily
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("parent_position_family_id")]
    public long? ParentPositionFamilyId { get; set; }

    [Column("is_dynamic")]
    public bool? IsDynamic { get; set; }

    [Column("bonus_profile_id")]
    public long? BonusProfileId { get; set; }

    [Column("competence_profile_id")]
    public long? CompetenceProfileId { get; set; }

    [Column("kpi_profile_id")]
    public long? KpiProfileId { get; set; }

    [Column("kpi_profiles_id", TypeName = "xml")]
    public string? KpiProfilesId { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("subdivision_group_id")]
    public long? SubdivisionGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
