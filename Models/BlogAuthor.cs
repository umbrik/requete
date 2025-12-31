using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("blog_authors")]
public partial class BlogAuthor
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("blog_id")]
    public long? BlogId { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("person_id")]
    [Unicode(false)]
    public string? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("is_full_moderator")]
    public bool? IsFullModerator { get; set; }
}
