using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("kpi_managers")]
public partial class KpiManager
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("manager_type")]
    [Unicode(false)]
    public string? ManagerType { get; set; }

    [Column("manager_id")]
    public long? ManagerId { get; set; }

    [Column("manager_name")]
    [Unicode(false)]
    public string? ManagerName { get; set; }

    [Column("is_owner")]
    public bool? IsOwner { get; set; }

    [Column("boss_type_id")]
    public long? BossTypeId { get; set; }
}
