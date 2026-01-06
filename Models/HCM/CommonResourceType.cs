using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.resource_types")]
public partial class CommonResourceType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("ext")]
    [Unicode(false)]
    public string? Ext { get; set; }

    [Column("is_media")]
    public bool? IsMedia { get; set; }

    [Column("use_cache")]
    public bool? UseCache { get; set; }
}
