using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("staff_positions")]
public partial class StaffPosition
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

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("org_name")]
    [Unicode(false)]
    public string? OrgName { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("subdivision_name")]
    [Unicode(false)]
    public string? SubdivisionName { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("profession_id")]
    public long? ProfessionId { get; set; }

    [Column("profession_category_id")]
    public long? ProfessionCategoryId { get; set; }

    [Column("bonus_profile_id")]
    public long? BonusProfileId { get; set; }

    [Column("kpi_profile_id")]
    public long? KpiProfileId { get; set; }

    [Column("kpi_profiles_id", TypeName = "xml")]
    public string? KpiProfilesId { get; set; }

    [Column("knowledge_profile_id")]
    public long? KnowledgeProfileId { get; set; }

    [Column("competence_profile_id")]
    public long? CompetenceProfileId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
