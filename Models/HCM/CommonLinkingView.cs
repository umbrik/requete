using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.linking_views")]
public partial class CommonLinkingView
{
    [Key]
    [Column("name")]
    [StringLength(128)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("catalog_name")]
    [Unicode(false)]
    public string? CatalogName { get; set; }

    [Column("disp_name")]
    [Unicode(false)]
    public string? DispName { get; set; }

    [Column("title")]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("view_url")]
    [Unicode(false)]
    public string? ViewUrl { get; set; }
}
