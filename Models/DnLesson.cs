using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("dn_lessons")]
public partial class DnLesson
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("faculty_id")]
    public long? FacultyId { get; set; }

    [Column("chair_id")]
    public long? ChairId { get; set; }

    [Column("discipline_id")]
    public long? DisciplineId { get; set; }

    [Column("lesson_date", TypeName = "datetime")]
    public DateTime? LessonDate { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }

    [Column("educat_event_form_id")]
    public long? EducatEventFormId { get; set; }

    [Column("auditorium_id")]
    public long? AuditoriumId { get; set; }

    [Column("stream_id")]
    public long? StreamId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
