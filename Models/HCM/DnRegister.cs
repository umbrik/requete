using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_registers")]
public partial class DnRegister
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("control_event_id")]
    public long? ControlEventId { get; set; }

    [Column("type_id")]
    [Unicode(false)]
    public string? TypeId { get; set; }

    [Column("faculty_id")]
    public long? FacultyId { get; set; }

    [Column("chair_id")]
    public long? ChairId { get; set; }

    [Column("discipl_id")]
    public long? DisciplId { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }

    [Column("date_event", TypeName = "datetime")]
    public DateTime? DateEvent { get; set; }

    [Column("contr_form_id")]
    public long? ContrFormId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
