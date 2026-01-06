using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("education_methods")]
public partial class EducationMethod
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("course_id")]
    public long? CourseId { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("cost_nds")]
    public double? CostNds { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("cost_type")]
    [Unicode(false)]
    public string? CostType { get; set; }

    [Column("duration")]
    public double? Duration { get; set; }

    [Column("duration_days")]
    public long? DurationDays { get; set; }

    [Column("person_num")]
    public long? PersonNum { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

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

    [Column("event_form")]
    [Unicode(false)]
    public string? EventForm { get; set; }

    [Column("event_type_id")]
    public long? EventTypeId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
