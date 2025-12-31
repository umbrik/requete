using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.learning_record_statuss")]
public partial class CommonLearningRecordStatuss
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("icon_url")]
    [Unicode(false)]
    public string? IconUrl { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }
}
