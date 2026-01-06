using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("education_plan_collaborators")]
public partial class EducationPlanCollaborator
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("program_id")]
    public long? ProgramId { get; set; }

    [Column("parent_progpam_id")]
    public long? ParentProgpamId { get; set; }

    [Column("position")]
    public long? Position { get; set; }

    [Column("education_plan_id")]
    public long? EducationPlanId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("compound_program_id")]
    public long? CompoundProgramId { get; set; }

    [Column("education_program_id")]
    public long? EducationProgramId { get; set; }

    [Column("education_method_id")]
    public long? EducationMethodId { get; set; }

    [Column("development_plan_id")]
    public long? DevelopmentPlanId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("object_code")]
    [Unicode(false)]
    public string? ObjectCode { get; set; }

    [Column("object_start_date", TypeName = "datetime")]
    public DateTime? ObjectStartDate { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("plan_date", TypeName = "datetime")]
    public DateTime? PlanDate { get; set; }

    [Column("result_type")]
    [Unicode(false)]
    public string? ResultType { get; set; }

    [Column("result_object_id")]
    public long? ResultObjectId { get; set; }

    [Column("result_object_name")]
    [Unicode(false)]
    public string? ResultObjectName { get; set; }

    [Column("result_object_code")]
    [Unicode(false)]
    public string? ResultObjectCode { get; set; }

    [Column("result_object_start_date", TypeName = "datetime")]
    public DateTime? ResultObjectStartDate { get; set; }

    [Column("result_object_finish_date", TypeName = "datetime")]
    public DateTime? ResultObjectFinishDate { get; set; }

    [Column("weight")]
    public long? Weight { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("readiness_percent")]
    public long? ReadinessPercent { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position")]
    [Unicode(false)]
    public string? PersonPosition { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }

    [Column("is_collaborator")]
    public bool? IsCollaborator { get; set; }

    [Column("is_tutor")]
    public bool? IsTutor { get; set; }
}
