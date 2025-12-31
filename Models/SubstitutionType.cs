using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("substitution_types")]
public partial class SubstitutionType
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

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("operation_codes")]
    [Unicode(false)]
    public string? OperationCodes { get; set; }

    [Column("operation_id", TypeName = "xml")]
    public string? OperationId { get; set; }

    [Column("remote_action_codes")]
    [Unicode(false)]
    public string? RemoteActionCodes { get; set; }

    [Column("remote_action_id", TypeName = "xml")]
    public string? RemoteActionId { get; set; }

    [Column("data_str")]
    [Unicode(false)]
    public string? DataStr { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
