using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.language_levels")]
public partial class CommonLanguageLevel
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }
}
