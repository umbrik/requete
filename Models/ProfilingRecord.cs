using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("profiling_records")]
public partial class ProfilingRecord
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("ticks")]
    public long? Ticks { get; set; }

    [Column("url")]
    [Unicode(false)]
    public string? Url { get; set; }

    [Column("sid")]
    [Unicode(false)]
    public string? Sid { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("template_type")]
    [Unicode(false)]
    public string? TemplateType { get; set; }

    [Column("template_id")]
    public long? TemplateId { get; set; }

    [Column("parent_template_type")]
    [Unicode(false)]
    public string? ParentTemplateType { get; set; }

    [Column("parent_template_id")]
    public long? ParentTemplateId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
