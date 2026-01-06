using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("pay_phases")]
public partial class PayPhase
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("event_name")]
    [Unicode(false)]
    public string? EventName { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("invoice_sum")]
    public double? InvoiceSum { get; set; }

    [Column("draft_sum")]
    public double? DraftSum { get; set; }

    [Column("act_sum")]
    public double? ActSum { get; set; }

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
