using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("position_assessment_forms")]
public partial class PositionAssessmentForm
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("is_done")]
    public bool? IsDone { get; set; }

    [Column("assessment_appraise_id")]
    public long? AssessmentAppraiseId { get; set; }

    [Column("scale")]
    public long? Scale { get; set; }

    [Column("grade_id")]
    public long? GradeId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
