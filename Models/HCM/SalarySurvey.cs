using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("salary_surveys")]
public partial class SalarySurvey
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

    [Column("min_salary")]
    public double? MinSalary { get; set; }

    [Column("max_salary")]
    public double? MaxSalary { get; set; }

    [Column("avg_salary")]
    public double? AvgSalary { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("position_name")]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [Column("position_level_id")]
    public long? PositionLevelId { get; set; }

    [Column("salary_survey_source_id")]
    public long? SalarySurveySourceId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("region_id")]
    public long? RegionId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
