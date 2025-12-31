using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("kpi_profiles")]
public partial class KpiProfile
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

    [Column("competence_profile_family_id")]
    public long? CompetenceProfileFamilyId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("parent_kpi_profile_id")]
    public long? ParentKpiProfileId { get; set; }

    [Column("kpi_id", TypeName = "xml")]
    public string? KpiId { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("workflow_state")]
    [Unicode(false)]
    public string? WorkflowState { get; set; }

    [Column("workflow_state_name")]
    [Unicode(false)]
    public string? WorkflowStateName { get; set; }

    [Column("workflow_person_id", TypeName = "xml")]
    public string? WorkflowPersonId { get; set; }

    [Column("workflow_matching_type")]
    [Unicode(false)]
    public string? WorkflowMatchingType { get; set; }

    [Column("workflow_main_person_id", TypeName = "xml")]
    public string? WorkflowMainPersonId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
