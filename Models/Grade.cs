using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("grades")]
public partial class Grade
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("level")]
    public long? Level { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("desc")]
    [Unicode(false)]
    public string? Desc { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
