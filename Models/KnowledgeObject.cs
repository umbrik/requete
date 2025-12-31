using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("knowledge_objects")]
public partial class KnowledgeObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("catalog")]
    [Unicode(false)]
    public string? Catalog { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("object_status")]
    [Unicode(false)]
    public string? ObjectStatus { get; set; }

    [Column("object_start_date", TypeName = "datetime")]
    public DateTime? ObjectStartDate { get; set; }

    [Column("object_end_date", TypeName = "datetime")]
    public DateTime? ObjectEndDate { get; set; }

    [Column("doc_create_date", TypeName = "datetime")]
    public DateTime? DocCreateDate { get; set; }

    [Column("knowledge_part_id")]
    public long? KnowledgePartId { get; set; }

    [Column("knowledge_part_name")]
    [Unicode(false)]
    public string? KnowledgePartName { get; set; }

    [Column("current_level_id")]
    [Unicode(false)]
    public string? CurrentLevelId { get; set; }

    [Column("current_level_name")]
    [Unicode(false)]
    public string? CurrentLevelName { get; set; }

    [Column("current_level_index")]
    public long? CurrentLevelIndex { get; set; }

    [Column("target_level_id")]
    [Unicode(false)]
    public string? TargetLevelId { get; set; }

    [Column("target_level_name")]
    [Unicode(false)]
    public string? TargetLevelName { get; set; }

    [Column("target_level_index")]
    public long? TargetLevelIndex { get; set; }

    [Column("require_acknowledgement")]
    public bool? RequireAcknowledgement { get; set; }

    [Column("knowledge_part_level_id")]
    public long? KnowledgePartLevelId { get; set; }

    [Column("acquaint_time")]
    public long? AcquaintTime { get; set; }
}
