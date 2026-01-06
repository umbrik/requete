using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("schedule_days")]
public partial class ScheduleDay
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("schedule_type_id")]
    public long? ScheduleTypeId { get; set; }

    [Column("schedule_type_name")]
    [Unicode(false)]
    public string? ScheduleTypeName { get; set; }

    [Column("rest_collaborator_schedule_id")]
    public long? RestCollaboratorScheduleId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("start_time")]
    [Unicode(false)]
    public string? StartTime { get; set; }

    [Column("finish_time")]
    [Unicode(false)]
    public string? FinishTime { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
