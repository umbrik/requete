using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("outstaff_providers")]
public partial class OutstaffProvider
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

    [Column("region_id")]
    public long? RegionId { get; set; }

    [Column("collaborator_id")]
    public long? CollaboratorId { get; set; }

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

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
