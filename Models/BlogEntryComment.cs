using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("blog_entry_comments")]
public partial class BlogEntryComment
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("blog_entry_id")]
    public long? BlogEntryId { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("creator_name")]
    [Unicode(false)]
    public string? CreatorName { get; set; }

    [Column("message")]
    [Unicode(false)]
    public string? Message { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("like_id")]
    public long? LikeId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
