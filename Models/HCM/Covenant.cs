using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("covenants")]
public partial class Covenant
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("close_date", TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    [Column("period_work")]
    public long? PeriodWork { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("cost_nds")]
    public double? CostNds { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("proc_pay_bank")]
    public long? ProcPayBank { get; set; }

    [Column("proc_pay_collab")]
    public long? ProcPayCollab { get; set; }

    [Column("proc_deduct")]
    public long? ProcDeduct { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("education_method_id")]
    public long? EducationMethodId { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

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
