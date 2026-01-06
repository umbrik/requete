using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("working_conditions")]
public partial class WorkingCondition
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

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_id")]
    public long? PersonPositionId { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_position_code")]
    [Unicode(false)]
    public string? PersonPositionCode { get; set; }

    [Column("person_org_id")]
    public long? PersonOrgId { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_org_code")]
    [Unicode(false)]
    public string? PersonOrgCode { get; set; }

    [Column("person_subdivision_id")]
    public long? PersonSubdivisionId { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }

    [Column("person_subdivision_code")]
    [Unicode(false)]
    public string? PersonSubdivisionCode { get; set; }

    [Column("person_instance_id")]
    [Unicode(false)]
    public string? PersonInstanceId { get; set; }

    [Column("person_code")]
    [Unicode(false)]
    public string? PersonCode { get; set; }

    [Column("is_model")]
    public bool? IsModel { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("probationary_duration")]
    public long? ProbationaryDuration { get; set; }

    [Column("position_name")]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [Column("place_name")]
    [Unicode(false)]
    public string? PlaceName { get; set; }

    [Column("place_id")]
    public long? PlaceId { get; set; }

    [Column("working_condition_type_id")]
    public long? WorkingConditionTypeId { get; set; }

    [Column("salary_payment_type_id")]
    public long? SalaryPaymentTypeId { get; set; }

    [Column("work_form_id")]
    public long? WorkFormId { get; set; }

    [Column("payment_remuneration")]
    [Unicode(false)]
    public string? PaymentRemuneration { get; set; }

    [Column("salary")]
    public long? Salary { get; set; }

    [Column("currency_type_id")]
    [Unicode(false)]
    public string? CurrencyTypeId { get; set; }

    [Column("work_schedule_type_id")]
    public long? WorkScheduleTypeId { get; set; }

    [Column("daily_duration")]
    public long? DailyDuration { get; set; }

    [Column("weekly_duration")]
    public long? WeeklyDuration { get; set; }

    [Column("start_work_type")]
    [Unicode(false)]
    public string? StartWorkType { get; set; }

    [Column("start_work_time")]
    [Unicode(false)]
    public string? StartWorkTime { get; set; }

    [Column("end_work_time")]
    [Unicode(false)]
    public string? EndWorkTime { get; set; }

    [Column("lunch_break_duration")]
    public double? LunchBreakDuration { get; set; }

    [Column("lunch_break_type")]
    [Unicode(false)]
    public string? LunchBreakType { get; set; }

    [Column("start_lunch_break_time")]
    [Unicode(false)]
    public string? StartLunchBreakTime { get; set; }

    [Column("end_lunch_break_time")]
    [Unicode(false)]
    public string? EndLunchBreakTime { get; set; }

    [Column("shifts_number")]
    public long? ShiftsNumber { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
