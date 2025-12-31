using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("object_requirements")]
public partial class ObjectRequirement
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("requirement_type")]
    [Unicode(false)]
    public string? RequirementType { get; set; }

    [Column("requirement_object_id")]
    public long? RequirementObjectId { get; set; }

    [Column("requirement_object_type")]
    [Unicode(false)]
    public string? RequirementObjectType { get; set; }

    [Column("sec_requirement_object_id")]
    public long? SecRequirementObjectId { get; set; }

    [Column("sec_requirement_object_type")]
    [Unicode(false)]
    public string? SecRequirementObjectType { get; set; }

    [Column("obligatory")]
    public bool? Obligatory { get; set; }

    [Column("requirement_value")]
    [Unicode(false)]
    public string? RequirementValue { get; set; }

    [Column("additional_param")]
    [Unicode(false)]
    public string? AdditionalParam { get; set; }
}
