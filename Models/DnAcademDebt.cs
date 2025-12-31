using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("dn_academ_debts")]
public partial class DnAcademDebt
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

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("stream_id")]
    public long? StreamId { get; set; }

    [Column("stud_group_id")]
    public long? StudGroupId { get; set; }

    [Column("student_id")]
    public long? StudentId { get; set; }

    [Column("discipl_id")]
    public long? DisciplId { get; set; }

    [Column("contr_form_id")]
    public long? ContrFormId { get; set; }

    [Column("latest_date", TypeName = "datetime")]
    public DateTime? LatestDate { get; set; }

    [Column("liquid_date", TypeName = "datetime")]
    public DateTime? LiquidDate { get; set; }

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
