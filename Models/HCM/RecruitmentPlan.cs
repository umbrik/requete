using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("recruitment_plans")]
public partial class RecruitmentPlan
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("state")]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("subdivision_group_id")]
    public long? SubdivisionGroupId { get; set; }

    [Column("position_family_id")]
    public long? PositionFamilyId { get; set; }

    [Column("position_type")]
    [Unicode(false)]
    public string? PositionType { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("position_name")]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [Column("vacancy_type_id")]
    public long? VacancyTypeId { get; set; }

    [Column("quantity")]
    public long? Quantity { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
