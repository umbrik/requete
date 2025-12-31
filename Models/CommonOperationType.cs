using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.operation_types")]
public partial class CommonOperationType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("type")]
    public long? Type { get; set; }

    [Column("operation_catalog")]
    [Unicode(false)]
    public string? OperationCatalog { get; set; }
}
