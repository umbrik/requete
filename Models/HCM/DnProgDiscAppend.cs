using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_prog_disc_appends")]
public partial class DnProgDiscAppend
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

    [Column("program_discipline_id")]
    public long? ProgramDisciplineId { get; set; }

    [Column("academ_year_id")]
    public long? AcademYearId { get; set; }

    [Column("special_id")]
    public long? SpecialId { get; set; }

    [Column("specialization_id")]
    public long? SpecializationId { get; set; }

    [Column("educat_form_id")]
    [Unicode(false)]
    public string? EducatFormId { get; set; }

    [Column("qualification_id")]
    public long? QualificationId { get; set; }

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
