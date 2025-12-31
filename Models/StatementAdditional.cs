using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("statement_additionals")]
public partial class StatementAdditional
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("path")]
    [Unicode(false)]
    public string? Path { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("value")]
    [Unicode(false)]
    public string? Value { get; set; }

    [Column("statement_id")]
    public long? StatementId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
