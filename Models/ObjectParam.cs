using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("object_params")]
public partial class ObjectParam
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

    [Column("is_enabled")]
    public bool? IsEnabled { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("sec_object_code")]
    [Unicode(false)]
    public string? SecObjectCode { get; set; }

    [Column("base_object_type")]
    [Unicode(false)]
    public string? BaseObjectType { get; set; }

    [Column("base_object_id")]
    public long? BaseObjectId { get; set; }

    [Column("base_object_name")]
    [Unicode(false)]
    public string? BaseObjectName { get; set; }
}
