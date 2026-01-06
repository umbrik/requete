using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.content_items")]
public partial class CommonContentItem
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("html_page")]
    [Unicode(false)]
    public string? HtmlPage { get; set; }

    [Column("access_block")]
    [Unicode(false)]
    public string? AccessBlock { get; set; }
}
