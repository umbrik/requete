using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.annals_item_types")]
public partial class CommonAnnalsItemType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("data_id")]
    [Unicode(false)]
    public string? DataId { get; set; }

    [Column("item_id")]
    [Unicode(false)]
    public string? ItemId { get; set; }
}
