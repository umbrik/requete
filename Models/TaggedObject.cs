using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("tagged_objects")]
public partial class TaggedObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("catalog")]
    [Unicode(false)]
    public string? Catalog { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("doc_create_date", TypeName = "datetime")]
    public DateTime? DocCreateDate { get; set; }

    [Column("require_acknowledgement")]
    public bool? RequireAcknowledgement { get; set; }

    [Column("tag_id")]
    public long? TagId { get; set; }

    [Column("tag_name")]
    [Unicode(false)]
    public string? TagName { get; set; }
}
