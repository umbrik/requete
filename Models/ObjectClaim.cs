using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("object_claims")]
public partial class ObjectClaim
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

    [Column("source_type")]
    [Unicode(false)]
    public string? SourceType { get; set; }

    [Column("source_id")]
    public long? SourceId { get; set; }

    [Column("source_name")]
    [Unicode(false)]
    public string? SourceName { get; set; }

    [Column("source_code")]
    [Unicode(false)]
    public string? SourceCode { get; set; }

    [Column("source_role")]
    [Unicode(false)]
    public string? SourceRole { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("object_code")]
    [Unicode(false)]
    public string? ObjectCode { get; set; }

    [Column("element_type")]
    [Unicode(false)]
    public string? ElementType { get; set; }

    [Column("element_id")]
    public long? ElementId { get; set; }

    [Column("element_name")]
    [Unicode(false)]
    public string? ElementName { get; set; }

    [Column("element_code")]
    [Unicode(false)]
    public string? ElementCode { get; set; }

    [Column("read")]
    public bool? Read { get; set; }

    [Column("write")]
    public bool? Write { get; set; }

    [Column("delete")]
    public bool? Delete { get; set; }

    [Column("list")]
    public bool? List { get; set; }

    [Column("execute")]
    public bool? Execute { get; set; }

    [Column("access_level")]
    public long? AccessLevel { get; set; }

    [Column("value")]
    [Unicode(false)]
    public string? Value { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("is_manual")]
    public bool? IsManual { get; set; }

    [Column("data_str")]
    [Unicode(false)]
    public string? DataStr { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
