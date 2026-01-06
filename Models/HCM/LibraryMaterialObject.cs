using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("library_material_objects")]
public partial class LibraryMaterialObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("library_material_id")]
    public long? LibraryMaterialId { get; set; }

    [Column("library_material_name")]
    [Unicode(false)]
    public string? LibraryMaterialName { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("object_catalog")]
    [Unicode(false)]
    public string? ObjectCatalog { get; set; }
}
