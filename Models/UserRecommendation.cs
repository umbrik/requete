using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("user_recommendations")]
public partial class UserRecommendation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("context_object_id")]
    public long? ContextObjectId { get; set; }

    [Column("context_object_type")]
    [Unicode(false)]
    public string? ContextObjectType { get; set; }

    [Column("context_object_name")]
    [Unicode(false)]
    public string? ContextObjectName { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
