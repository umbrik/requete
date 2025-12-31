using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("budget_objects")]
public partial class BudgetObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("budget_id")]
    public long? BudgetId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("catalog_name")]
    [Unicode(false)]
    public string? CatalogName { get; set; }

    [Column("all")]
    public bool? All { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }
}
