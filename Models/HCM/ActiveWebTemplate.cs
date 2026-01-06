using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("active_web_templates")]
public partial class ActiveWebTemplate
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("access_level")]
    public long? AccessLevel { get; set; }

    [Column("access_role")]
    [Unicode(false)]
    public string? AccessRole { get; set; }

    [Column("mode")]
    [Unicode(false)]
    public string? Mode { get; set; }

    [Column("web_design_id")]
    public long? WebDesignId { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("hash")]
    [Unicode(false)]
    public string? Hash { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
