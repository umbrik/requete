using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("compound_program_education_methods")]
public partial class CompoundProgramEducationMethod
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("program_id")]
    public long? ProgramId { get; set; }

    [Column("parent_progpam_id")]
    public long? ParentProgpamId { get; set; }

    [Column("position")]
    public long? Position { get; set; }

    [Column("compound_program_id")]
    public long? CompoundProgramId { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("education_method_id")]
    public long? EducationMethodId { get; set; }

    [Column("education_method_name")]
    [Unicode(false)]
    public string? EducationMethodName { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("cost_type")]
    [Unicode(false)]
    public string? CostType { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("person_num")]
    public long? PersonNum { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("object_code")]
    [Unicode(false)]
    public string? ObjectCode { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("duration_days")]
    public long? DurationDays { get; set; }
}
