using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("event_results")]
public partial class EventResult
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("event_name")]
    [Unicode(false)]
    public string? EventName { get; set; }

    [Column("event_start_date", TypeName = "datetime")]
    public DateTime? EventStartDate { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("event_result_type_id")]
    public long? EventResultTypeId { get; set; }

    [Column("is_assist")]
    public bool? IsAssist { get; set; }

    [Column("is_confirm")]
    public bool? IsConfirm { get; set; }

    [Column("is_banned")]
    public bool? IsBanned { get; set; }

    [Column("not_participate")]
    public bool? NotParticipate { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("score")]
    public double? Score { get; set; }

    [Column("last_sending_date", TypeName = "datetime")]
    public DateTime? LastSendingDate { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("cost_center_id")]
    public long? CostCenterId { get; set; }

    [Column("not_pay")]
    public bool? NotPay { get; set; }

    [Column("guest")]
    public bool? Guest { get; set; }

    [Column("expense_sum")]
    public double? ExpenseSum { get; set; }

    [Column("object_resource_id")]
    public long? ObjectResourceId { get; set; }

    [Column("certificate_id")]
    public long? CertificateId { get; set; }

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
