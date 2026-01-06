using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("personnel_events")]
public partial class PersonnelEvent
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

    [Column("event_status")]
    [Unicode(false)]
    public string? EventStatus { get; set; }

    [Column("personnel_event_type_id")]
    public long? PersonnelEventTypeId { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("date_processed", TypeName = "datetime")]
    public DateTime? DateProcessed { get; set; }

    [Column("date_cancel", TypeName = "datetime")]
    public DateTime? DateCancel { get; set; }

    [Column("date_delete", TypeName = "datetime")]
    public DateTime? DateDelete { get; set; }

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
