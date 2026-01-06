using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.discharge_types")]
public partial class CommonDischargeType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("is_import")]
    public bool? IsImport { get; set; }

    [Column("source_name")]
    [Unicode(false)]
    public string? SourceName { get; set; }
}
