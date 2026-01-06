using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.object_param_base_object_types")]
public partial class CommonObjectParamBaseObjectType
{
    [Key]
    [Column("name")]
    [StringLength(128)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("title")]
    [Unicode(false)]
    public string? Title { get; set; }
}
