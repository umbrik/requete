using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("forum_entrys")]
public partial class ForumEntry
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("closed")]
    public bool? Closed { get; set; }

    [Column("pinned")]
    public bool? Pinned { get; set; }

    [Column("how2show")]
    [Unicode(false)]
    public string? How2show { get; set; }

    [Column("author_info")]
    [Unicode(false)]
    public string? AuthorInfo { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("forum_id")]
    public long? ForumId { get; set; }

    [Column("parent_forum_entry_id")]
    public long? ParentForumEntryId { get; set; }

    [Column("main_forum_entry_id")]
    public long? MainForumEntryId { get; set; }

    [Column("is_moder_approved")]
    public bool? IsModerApproved { get; set; }

    [Column("last_create_date", TypeName = "datetime")]
    public DateTime? LastCreateDate { get; set; }

    [Column("child_num")]
    public long? ChildNum { get; set; }

    [Column("remote_ip")]
    [Unicode(false)]
    public string? RemoteIp { get; set; }

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
}
