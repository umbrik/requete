using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("vacancys")]
public partial class Vacancy
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

    [Column("source_id")]
    [Unicode(false)]
    public string? SourceId { get; set; }

    [Column("profession_id")]
    public long? ProfessionId { get; set; }

    [Column("profession_area_id")]
    [Unicode(false)]
    public string? ProfessionAreaId { get; set; }

    [Column("region_id")]
    public long? RegionId { get; set; }

    [Column("schedule_work_id")]
    [Unicode(false)]
    public string? ScheduleWorkId { get; set; }

    [Column("schedule_id")]
    public long? ScheduleId { get; set; }

    [Column("educ_type_id")]
    [Unicode(false)]
    public string? EducTypeId { get; set; }

    [Column("employment_type_id")]
    [Unicode(false)]
    public string? EmploymentTypeId { get; set; }

    [Column("work_condition_id")]
    public long? WorkConditionId { get; set; }

    [Column("work_mode_id")]
    public long? WorkModeId { get; set; }

    [Column("wage_system_id")]
    public long? WageSystemId { get; set; }

    [Column("material_liability_id")]
    public long? MaterialLiabilityId { get; set; }

    [Column("vacancy_reason_id")]
    public long? VacancyReasonId { get; set; }

    [Column("work_experience_id")]
    public long? WorkExperienceId { get; set; }

    [Column("min_age")]
    public long? MinAge { get; set; }

    [Column("max_age")]
    public long? MaxAge { get; set; }

    [Column("min_wage")]
    public long? MinWage { get; set; }

    [Column("max_wage")]
    public long? MaxWage { get; set; }

    [Column("avg_wage")]
    public long? AvgWage { get; set; }

    [Column("currency_type_id")]
    [Unicode(false)]
    public string? CurrencyTypeId { get; set; }

    [Column("min_budget")]
    public long? MinBudget { get; set; }

    [Column("max_budget")]
    public long? MaxBudget { get; set; }

    [Column("budget_currency_type_id")]
    [Unicode(false)]
    public string? BudgetCurrencyTypeId { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("subordination")]
    [Unicode(false)]
    public string? Subordination { get; set; }

    [Column("pub_date", TypeName = "datetime")]
    public DateTime? PubDate { get; set; }

    [Column("edit_date", TypeName = "datetime")]
    public DateTime? EditDate { get; set; }

    [Column("pub_period")]
    public long? PubPeriod { get; set; }

    [Column("close_date", TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    [Column("is_closed")]
    public bool? IsClosed { get; set; }

    [Column("collaborator_id")]
    public long? CollaboratorId { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("org_name")]
    [Unicode(false)]
    public string? OrgName { get; set; }

    [Column("sub_id")]
    public long? SubId { get; set; }

    [Column("sub_name")]
    [Unicode(false)]
    public string? SubName { get; set; }

    [Column("recruiter_id")]
    public long? RecruiterId { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("url")]
    [Unicode(false)]
    public string? Url { get; set; }

    [Column("comment")]
    [Unicode(false)]
    public string? Comment { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
