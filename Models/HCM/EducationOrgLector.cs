using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("education_org_lectors")]
public partial class EducationOrgLector
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("disp_name")]
    [Unicode(false)]
    public string? DispName { get; set; }

    [Column("is_provider_courses")]
    public bool? IsProviderCourses { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }
}
