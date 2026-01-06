using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("person_activity_infos")]
public partial class PersonActivityInfo
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("chat_last_activity_date", TypeName = "datetime")]
    public DateTime? ChatLastActivityDate { get; set; }

    [Column("presence_state_id")]
    public long? PresenceStateId { get; set; }

    [Column("update_date", TypeName = "datetime")]
    public DateTime? UpdateDate { get; set; }
}
