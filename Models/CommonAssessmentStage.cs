using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.assessment_stages")]
public partial class CommonAssessmentStage
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("is_period_dependent")]
    public bool? IsPeriodDependent { get; set; }

    [Column("access", TypeName = "xml")]
    public string? Access { get; set; }
}
