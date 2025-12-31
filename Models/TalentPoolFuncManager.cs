using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("talent_pool_func_managers")]
public partial class TalentPoolFuncManager
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

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("is_native")]
    public bool? IsNative { get; set; }

    [Column("boss_type_id")]
    public long? BossTypeId { get; set; }
}
