using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.months")]
public partial class CommonMonth
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("number")]
    public long? Number { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("name_genitive")]
    [Unicode(false)]
    public string? NameGenitive { get; set; }

    [Column("days")]
    public long? Days { get; set; }

    [Column("quarter")]
    public long? Quarter { get; set; }
}
