using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[PrimaryKey("Catalog", "CatalogElem", "Name")]
[Table("(spxml_foreign_arrays)")]
public partial class SpxmlForeignArray
{
    [Key]
    [Column("catalog")]
    [StringLength(64)]
    [Unicode(false)]
    public string Catalog { get; set; } = null!;

    [Key]
    [Column("catalog_elem")]
    [StringLength(64)]
    [Unicode(false)]
    public string CatalogElem { get; set; } = null!;

    [Key]
    [Column("name")]
    [StringLength(64)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("foreign_array")]
    [StringLength(96)]
    [Unicode(false)]
    public string ForeignArray { get; set; } = null!;
}
