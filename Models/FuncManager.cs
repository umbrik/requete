using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("func_managers")]
public partial class FuncManager
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

    [Column("subordinate_position_id")]
    public long? SubordinatePositionId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_id")]
    public long? PersonPositionId { get; set; }

    [Column("staff_object_type")]
    [Unicode(false)]
    public string? StaffObjectType { get; set; }

    [Column("staff_object_id")]
    public long? StaffObjectId { get; set; }

    [Column("staff_object_name")]
    [Unicode(false)]
    public string? StaffObjectName { get; set; }

    [Column("is_native")]
    public bool? IsNative { get; set; }

    [Column("boss_type_id")]
    public long? BossTypeId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("is_finished")]
    public bool? IsFinished { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }
}
