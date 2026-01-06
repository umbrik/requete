using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("web_modes")]
public partial class WebMode
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

    [Column("is_default")]
    public bool? IsDefault { get; set; }

    [Column("is_default_admin")]
    public bool? IsDefaultAdmin { get; set; }

    [Column("catalog_name")]
    [Unicode(false)]
    public string? CatalogName { get; set; }

    [Column("placeholder_template_id")]
    public long? PlaceholderTemplateId { get; set; }

    [Column("web_design_id")]
    public long? WebDesignId { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("use_fcache")]
    public bool? UseFcache { get; set; }

    [Column("searchable_portal")]
    public bool? SearchablePortal { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
