using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_control_events")]
public partial class DnControlEvent
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

    [Column("date_event", TypeName = "datetime")]
    public DateTime? DateEvent { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("faculty_id")]
    public long? FacultyId { get; set; }

    [Column("chair_id")]
    public long? ChairId { get; set; }

    [Column("discipl_id")]
    public long? DisciplId { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }

    [Column("control_form_id")]
    public long? ControlFormId { get; set; }

    [Column("lesson_id")]
    public long? LessonId { get; set; }

    [Column("stream_id")]
    public long? StreamId { get; set; }

    [Column("stud_group_id")]
    public long? StudGroupId { get; set; }

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
