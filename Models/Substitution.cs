using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("substitutions")]
public partial class Substitution
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("substitution_type_id")]
    public long? SubstitutionTypeId { get; set; }

    [Column("target_object_type")]
    [Unicode(false)]
    public string? TargetObjectType { get; set; }

    [Column("target_object_selector")]
    [Unicode(false)]
    public string? TargetObjectSelector { get; set; }

    [Column("target_object_id", TypeName = "xml")]
    public string? TargetObjectId { get; set; }

    [Column("data_str")]
    [Unicode(false)]
    public string? DataStr { get; set; }

    [Column("person_selector")]
    [Unicode(false)]
    public string? PersonSelector { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
