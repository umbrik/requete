using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_subject_plans")]
public partial class DnSubjectPlan
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("subject")]
    [Unicode(false)]
    public string? Subject { get; set; }

    [Column("program_discipline_id")]
    public long? ProgramDisciplineId { get; set; }

    [Column("prog_disc_append_id")]
    public long? ProgDiscAppendId { get; set; }

    [Column("educat_event_id")]
    public long? EducatEventId { get; set; }

    [Column("hours")]
    public long? Hours { get; set; }

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
