using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.access_block_types")]
public partial class CommonAccessBlockType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("objects_access")]
    [Unicode(false)]
    public string? ObjectsAccess { get; set; }

    [Column("icon_url")]
    [Unicode(false)]
    public string? IconUrl { get; set; }

    [Column("first_catalog_url")]
    [Unicode(false)]
    public string? FirstCatalogUrl { get; set; }

    [Column("disp")]
    public bool? Disp { get; set; }

    [Column("sys")]
    public bool? Sys { get; set; }

    [Column("license_catalogs")]
    [Unicode(false)]
    public string? LicenseCatalogs { get; set; }

    [Column("list_index")]
    public long? ListIndex { get; set; }

    [Column("structure", TypeName = "xml")]
    public string? Structure { get; set; }

    [Column("never_saved")]
    public bool? NeverSaved { get; set; }

    [Column("is_default")]
    public bool? IsDefault { get; set; }
}
