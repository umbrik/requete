using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("applications")]
public partial class Application
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("list_xms_url")]
    [Unicode(false)]
    public string? ListXmsUrl { get; set; }

    [Column("default_xms_url")]
    [Unicode(false)]
    public string? DefaultXmsUrl { get; set; }

    [Column("web_mode_id", TypeName = "xml")]
    public string? WebModeId { get; set; }

    [Column("vendor")]
    [Unicode(false)]
    public string? Vendor { get; set; }

    [Column("vendor_library")]
    [Unicode(false)]
    public string? VendorLibrary { get; set; }

    [Column("lic_type")]
    [Unicode(false)]
    public string? LicType { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
