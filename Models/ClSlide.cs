using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("cl_slides")]
public partial class ClSlide
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

    [Column("cl_course_id")]
    public long? ClCourseId { get; set; }

    [Column("cl_module_id")]
    public long? ClModuleId { get; set; }

    [Column("master_id")]
    public long? MasterId { get; set; }

    [Column("master_code")]
    [Unicode(false)]
    public string? MasterCode { get; set; }

    [Column("is_master")]
    public bool? IsMaster { get; set; }

    [Column("is_splash")]
    public bool? IsSplash { get; set; }

    [Column("sid")]
    public long? Sid { get; set; }

    [Column("flag_locked")]
    [Unicode(false)]
    public string? FlagLocked { get; set; }

    [Column("greedy_person_id")]
    public long? GreedyPersonId { get; set; }

    [Column("greedy_person_fullname")]
    [Unicode(false)]
    public string? GreedyPersonFullname { get; set; }

    [Column("flag_completion")]
    public bool? FlagCompletion { get; set; }

    [Column("approval_status")]
    public long? ApprovalStatus { get; set; }

    [Column("stamp")]
    public long? Stamp { get; set; }

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
