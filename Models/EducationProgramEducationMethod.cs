using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("education_program_education_methods")]
public partial class EducationProgramEducationMethod
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("education_program_id")]
    public long? EducationProgramId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("education_method_id")]
    public long? EducationMethodId { get; set; }

    [Column("education_method_name")]
    [Unicode(false)]
    public string? EducationMethodName { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("cost_type")]
    [Unicode(false)]
    public string? CostType { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("person_num")]
    public long? PersonNum { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("duration_days")]
    public long? DurationDays { get; set; }
}
