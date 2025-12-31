using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("poll_procedures")]
public partial class PollProcedure
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

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("web_display")]
    public bool? WebDisplay { get; set; }

    [Column("status")]
    public long? Status { get; set; }

    [Column("is_model")]
    public bool? IsModel { get; set; }

    [Column("str_sub_bosses_ids")]
    [Unicode(false)]
    public string? StrSubBossesIds { get; set; }

    [Column("trigger_type")]
    [Unicode(false)]
    public string? TriggerType { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("equal_hash")]
    [Unicode(false)]
    public string? EqualHash { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
