using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.availability_states")]
public partial class CommonAvailabilityState
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("text_color")]
    [Unicode(false)]
    public string? TextColor { get; set; }

    [Column("bk_color")]
    [Unicode(false)]
    public string? BkColor { get; set; }
}
