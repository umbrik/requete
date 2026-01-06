using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.knowledge_parts_objects")]
public partial class CommonKnowledgePartsObject
{
    [Key]
    [Column("knowledge_parts_object_id")]
    [StringLength(128)]
    [Unicode(false)]
    public string KnowledgePartsObjectId { get; set; } = null!;

    [Column("form_url")]
    [Unicode(false)]
    public string? FormUrl { get; set; }

    [Column("is_functional")]
    public bool? IsFunctional { get; set; }
}
