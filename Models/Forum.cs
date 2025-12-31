using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("forums")]
public partial class Forum
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("permit_subscription")]
    public bool? PermitSubscription { get; set; }

    [Column("closed")]
    public bool? Closed { get; set; }

    [Column("allow_anonymous_message")]
    public bool? AllowAnonymousMessage { get; set; }

    [Column("allow_create_closed_theme")]
    public bool? AllowCreateClosedTheme { get; set; }

    [Column("allow_user_delete")]
    public bool? AllowUserDelete { get; set; }

    [Column("disp_user_status")]
    public bool? DispUserStatus { get; set; }

    [Column("need_moder_approval")]
    public bool? NeedModerApproval { get; set; }

    [Column("course_id")]
    public long? CourseId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
