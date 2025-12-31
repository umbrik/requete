using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("position_commons")]
public partial class PositionCommon
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

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("min_salary")]
    public double? MinSalary { get; set; }

    [Column("max_salary")]
    public double? MaxSalary { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("position_familys")]
    [Unicode(false)]
    public string? PositionFamilys { get; set; }

    [Column("allow_outstaff")]
    public bool? AllowOutstaff { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("kpi_profile_id")]
    public long? KpiProfileId { get; set; }

    [Column("kpi_profiles_id", TypeName = "xml")]
    public string? KpiProfilesId { get; set; }

    [Column("bonus_profile_id")]
    public long? BonusProfileId { get; set; }

    [Column("knowledge_profile_id")]
    public long? KnowledgeProfileId { get; set; }

    [Column("parent_position_common_id", TypeName = "xml")]
    public string? ParentPositionCommonId { get; set; }

    [Column("grade_ids", TypeName = "xml")]
    public string? GradeIds { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
