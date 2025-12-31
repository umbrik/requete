using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.field_types")]
public partial class CommonFieldType
{
    [Key]
    [Column("name")]
    [StringLength(128)]
    [Unicode(false)]
    public string Name { get; set; } = null!;
}
