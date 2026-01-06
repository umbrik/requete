using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("hosts")]
public partial class Host
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

    [Column("hostname")]
    [Unicode(false)]
    public string? Hostname { get; set; }

    [Column("port")]
    public long? Port { get; set; }

    [Column("host")]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("portal_auth_type")]
    [Unicode(false)]
    public string? PortalAuthType { get; set; }

    [Column("allow_lds_auth")]
    public bool? AllowLdsAuth { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
