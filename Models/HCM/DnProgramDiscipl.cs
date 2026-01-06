using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_program_discipls")]
public partial class DnProgramDiscipl
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

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("faculty_id")]
    public long? FacultyId { get; set; }

    [Column("chair_id")]
    public long? ChairId { get; set; }

    [Column("discipline_id")]
    public long? DisciplineId { get; set; }

    [Column("academ_year_id")]
    public long? AcademYearId { get; set; }

    [Column("all_laboriousn_audit")]
    public long? AllLaboriousnAudit { get; set; }

    [Column("all_laboriousn_indep")]
    public long? AllLaboriousnIndep { get; set; }

    [Column("control_form")]
    public long? ControlForm { get; set; }

    [Column("educat_form_id")]
    public long? EducatFormId { get; set; }

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
