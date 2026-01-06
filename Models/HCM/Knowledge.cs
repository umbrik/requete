using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("knowledges")]
public partial class Knowledge
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

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("knowledge_classifier_id")]
    public long? KnowledgeClassifierId { get; set; }

    [Column("parent_object_id")]
    public long? ParentObjectId { get; set; }

    [Column("parent_catalog")]
    [Unicode(false)]
    public string? ParentCatalog { get; set; }

    [Column("has_experts")]
    public bool? HasExperts { get; set; }
}
