using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("outstaff_order_execution_stages")]
public partial class OutstaffOrderExecutionStage
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("outstaff_order_execution_id")]
    public long? OutstaffOrderExecutionId { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("formed_date", TypeName = "datetime")]
    public DateTime? FormedDate { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("outstaff_provider_id")]
    public long? OutstaffProviderId { get; set; }

    [Column("outstaff_contract_id")]
    public long? OutstaffContractId { get; set; }

    [Column("outstaff_order_id")]
    public long? OutstaffOrderId { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("stage_id")]
    [Unicode(false)]
    public string? StageId { get; set; }

    [Column("stage_parent_id")]
    [Unicode(false)]
    public string? StageParentId { get; set; }

    [Column("stage_collaborator_id")]
    public long? StageCollaboratorId { get; set; }

    [Column("stage_date", TypeName = "datetime")]
    public DateTime? StageDate { get; set; }

    [Column("stage_fact_date", TypeName = "datetime")]
    public DateTime? StageFactDate { get; set; }

    [Column("stage_hour_num")]
    public long? StageHourNum { get; set; }

    [Column("stage_hours_worked")]
    public long? StageHoursWorked { get; set; }

    [Column("stage_is_assist")]
    public bool? StageIsAssist { get; set; }

    [Column("stage_status_type")]
    [Unicode(false)]
    public string? StageStatusType { get; set; }
}
