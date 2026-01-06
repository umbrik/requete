using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("assessments")]
public partial class Assessment
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("title")]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("duration_days")]
    public long? DurationDays { get; set; }

    [Column("passing_score")]
    public double? PassingScore { get; set; }

    [Column("not_display_unfinished_score")]
    public bool? NotDisplayUnfinishedScore { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("use_proctoring")]
    public bool? UseProctoring { get; set; }

    [Column("external_type")]
    [Unicode(false)]
    public string? ExternalType { get; set; }

    [Column("publish_url")]
    [Unicode(false)]
    public string? PublishUrl { get; set; }

    [Column("win_width")]
    [Unicode(false)]
    public string? WinWidth { get; set; }

    [Column("win_height")]
    [Unicode(false)]
    public string? WinHeight { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("enable_anonymous_access")]
    public bool? EnableAnonymousAccess { get; set; }

    [Column("access_level")]
    public long? AccessLevel { get; set; }

    [Column("access_roles", TypeName = "xml")]
    public string? AccessRoles { get; set; }

    [Column("access_groups", TypeName = "xml")]
    public string? AccessGroups { get; set; }

    [Column("access_org_id")]
    public long? AccessOrgId { get; set; }

    [Column("access_site_id")]
    public long? AccessSiteId { get; set; }

    [Column("access_host_id")]
    public long? AccessHostId { get; set; }

    [Column("web_mode_id")]
    public long? WebModeId { get; set; }

    [Column("operator")]
    [Unicode(false)]
    public string? Operator { get; set; }

    [Column("conditions", TypeName = "xml")]
    public string? Conditions { get; set; }

    [Column("conditions_qual")]
    [Unicode(false)]
    public string? ConditionsQual { get; set; }

    [Column("access_subdivision_group_id")]
    public long? AccessSubdivisionGroupId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("testing_system_id")]
    public long? TestingSystemId { get; set; }
}
