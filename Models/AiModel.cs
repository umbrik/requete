using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("ai_models")]
public partial class AiModel
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("type_id")]
    [Unicode(false)]
    public string? TypeId { get; set; }

    [Column("code_library_id")]
    public long? CodeLibraryId { get; set; }

    [Column("library")]
    [Unicode(false)]
    public string? Library { get; set; }

    [Column("instance")]
    [Unicode(false)]
    public string? Instance { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }
}
