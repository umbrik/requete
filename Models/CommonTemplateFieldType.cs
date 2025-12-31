using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.template_field_types")]
public partial class CommonTemplateFieldType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("field_type")]
    [Unicode(false)]
    public string? FieldType { get; set; }

    [Column("icon")]
    [Unicode(false)]
    public string? Icon { get; set; }

    [Column("has_entries")]
    public bool? HasEntries { get; set; }
}
