using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("education_method_lectors")]
public partial class EducationMethodLector
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("education_method_id")]
    public long? EducationMethodId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("cost_nds")]
    public double? CostNds { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("cost_type")]
    [Unicode(false)]
    public string? CostType { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("duration_days")]
    public long? DurationDays { get; set; }

    [Column("person_num")]
    public long? PersonNum { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }
}
