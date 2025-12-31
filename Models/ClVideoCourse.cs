using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("cl_video_courses")]
public partial class ClVideoCourse
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

    [Column("last_compile_date", TypeName = "datetime")]
    public DateTime? LastCompileDate { get; set; }

    [Column("media_file_id")]
    public long? MediaFileId { get; set; }

    [Column("simple_media_file_id")]
    public long? SimpleMediaFileId { get; set; }

    [Column("authors_id", TypeName = "xml")]
    public string? AuthorsId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }
}
