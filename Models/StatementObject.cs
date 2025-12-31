using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("statement_objects")]
public partial class StatementObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("path")]
    [Unicode(false)]
    public string? Path { get; set; }

    [Column("object_id")]
    [Unicode(false)]
    public string? ObjectId { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("statement_id")]
    public long? StatementId { get; set; }

    [Column("definition_type")]
    [Unicode(false)]
    public string? DefinitionType { get; set; }

    [Column("definition_more_info")]
    [Unicode(false)]
    public string? DefinitionMoreInfo { get; set; }

    [Column("definition_interaction_type")]
    [Unicode(false)]
    public string? DefinitionInteractionType { get; set; }

    [Column("context_activity_type")]
    [Unicode(false)]
    public string? ContextActivityType { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
