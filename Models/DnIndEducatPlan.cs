using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("dn_ind_educat_plans")]
public partial class DnIndEducatPlan
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("student_id")]
    public long? StudentId { get; set; }

    [Column("discipline_id")]
    public long? DisciplineId { get; set; }

    [Column("prog_discipl_id")]
    public long? ProgDisciplId { get; set; }

    [Column("control_form_id")]
    public long? ControlFormId { get; set; }

    [Column("is_course_work")]
    [Unicode(false)]
    public string? IsCourseWork { get; set; }

    [Column("theme_course_work")]
    [Unicode(false)]
    public string? ThemeCourseWork { get; set; }

    [Column("chair_id")]
    public long? ChairId { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
