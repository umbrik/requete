using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("efficiency_grades")]
public partial class EfficiencyGrade
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

    [Column("efficiency_estimation_id")]
    public long? EfficiencyEstimationId { get; set; }

    [Column("assessment_source")]
    [Unicode(false)]
    public string? AssessmentSource { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("successor_id")]
    public long? SuccessorId { get; set; }

    [Column("personnel_reserve_id")]
    public long? PersonnelReserveId { get; set; }

    [Column("assessor_id")]
    public long? AssessorId { get; set; }

    [Column("assessment_date", TypeName = "datetime")]
    public DateTime? AssessmentDate { get; set; }

    [Column("assessment_appraise_id")]
    public long? AssessmentAppraiseId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

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
}
