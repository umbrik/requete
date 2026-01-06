using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("active_notifications")]
public partial class ActiveNotification
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("notification_id")]
    public long? NotificationId { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("subject")]
    [Unicode(false)]
    public string? Subject { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("last_send_date", TypeName = "datetime")]
    public DateTime? LastSendDate { get; set; }

    [Column("send_date", TypeName = "datetime")]
    public DateTime? SendDate { get; set; }

    [Column("recipient_person_id", TypeName = "xml")]
    public string? RecipientPersonId { get; set; }

    [Column("is_custom")]
    public bool? IsCustom { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("send_counter")]
    public long? SendCounter { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
