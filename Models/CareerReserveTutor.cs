using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("career_reserve_tutors")]
public partial class CareerReserveTutor
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("career_reserve_id")]
    public long? CareerReserveId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("plan_readiness_date", TypeName = "datetime")]
    public DateTime? PlanReadinessDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("readiness_percent")]
    public long? ReadinessPercent { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("tutor_id")]
    public long? TutorId { get; set; }

    [Column("tutor_type")]
    [Unicode(false)]
    public string? TutorType { get; set; }

    [Column("is_responsible")]
    public bool? IsResponsible { get; set; }

    [Column("tutor_fullname")]
    [Unicode(false)]
    public string? TutorFullname { get; set; }
}
