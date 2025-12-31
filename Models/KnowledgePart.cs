using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("knowledge_parts")]
public partial class KnowledgePart
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("parent_object_id")]
    public long? ParentObjectId { get; set; }

    [Column("knowledge_classifier_id")]
    public long? KnowledgeClassifierId { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("require_acknowledgement")]
    public bool? RequireAcknowledgement { get; set; }

    [Column("previous_version_object_id")]
    public long? PreviousVersionObjectId { get; set; }

    [Column("status_in_knowledge_map")]
    [Unicode(false)]
    public string? StatusInKnowledgeMap { get; set; }

    [Column("knowledge_part_type_id")]
    public long? KnowledgePartTypeId { get; set; }

    [Column("confirmation_type")]
    [Unicode(false)]
    public string? ConfirmationType { get; set; }

    [Column("expertise_level_index")]
    public long? ExpertiseLevelIndex { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("enable_anonymous_access")]
    public bool? EnableAnonymousAccess { get; set; }

    [Column("access_level")]
    public long? AccessLevel { get; set; }

    [Column("access_roles", TypeName = "xml")]
    public string? AccessRoles { get; set; }

    [Column("access_groups", TypeName = "xml")]
    public string? AccessGroups { get; set; }

    [Column("access_org_id")]
    public long? AccessOrgId { get; set; }

    [Column("access_site_id")]
    public long? AccessSiteId { get; set; }

    [Column("access_host_id")]
    public long? AccessHostId { get; set; }

    [Column("web_mode_id")]
    public long? WebModeId { get; set; }

    [Column("operator")]
    [Unicode(false)]
    public string? Operator { get; set; }

    [Column("conditions", TypeName = "xml")]
    public string? Conditions { get; set; }

    [Column("conditions_qual")]
    [Unicode(false)]
    public string? ConditionsQual { get; set; }

    [Column("access_subdivision_group_id")]
    public long? AccessSubdivisionGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
