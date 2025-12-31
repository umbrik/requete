using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("staff_subs")]
public partial class StaffSub
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("basic_collaborator_id")]
    public long? BasicCollaboratorId { get; set; }

    [Column("basic_collaborator_fullname")]
    [Unicode(false)]
    public string? BasicCollaboratorFullname { get; set; }

    [Column("is_boss")]
    public bool? IsBoss { get; set; }

    [Column("is_disbanded")]
    public bool? IsDisbanded { get; set; }
}
