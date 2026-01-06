using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("assessment_appraises")]
public partial class AssessmentAppraise
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

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("is_model")]
    public bool? IsModel { get; set; }

    [Column("web_display")]
    public bool? WebDisplay { get; set; }

    [Column("flag_use_plan")]
    public bool? FlagUsePlan { get; set; }

    [Column("ignore_presence")]
    public bool? IgnorePresence { get; set; }

    [Column("external_display_options")]
    [Unicode(false)]
    public string? ExternalDisplayOptions { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("is_visible_auditorys")]
    public bool? IsVisibleAuditorys { get; set; }

    [Column("is_visible_evaluatings")]
    public bool? IsVisibleEvaluatings { get; set; }

    [Column("is_visible_experts")]
    public bool? IsVisibleExperts { get; set; }

    [Column("player")]
    public long? Player { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

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
