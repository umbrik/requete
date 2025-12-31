using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("object_links")]
public partial class ObjectLink
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

    [Column("recommender_algorithm_id")]
    public long? RecommenderAlgorithmId { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("calc_date", TypeName = "datetime")]
    public DateTime? CalcDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
