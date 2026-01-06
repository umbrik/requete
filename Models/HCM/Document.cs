using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("documents")]
public partial class Document
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

    [Column("parent_document_id")]
    public long? ParentDocumentId { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("custom_template_type")]
    public long? CustomTemplateType { get; set; }

    [Column("template")]
    [Unicode(false)]
    public string? Template { get; set; }

    [Column("position")]
    public long? Position { get; set; }

    [Column("is_link")]
    public bool? IsLink { get; set; }

    [Column("link_href")]
    [Unicode(false)]
    public string? LinkHref { get; set; }

    [Column("link_target")]
    [Unicode(false)]
    public string? LinkTarget { get; set; }

    [Column("permit_subscription")]
    public bool? PermitSubscription { get; set; }

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

    [Column("access_exists")]
    public bool? AccessExists { get; set; }

    [Column("catalog_list_desc")]
    [Unicode(false)]
    public string? CatalogListDesc { get; set; }

    [Column("parent_object_type")]
    [Unicode(false)]
    public string? ParentObjectType { get; set; }

    [Column("parent_object_id")]
    public long? ParentObjectId { get; set; }

    [Column("parent_object_name")]
    [Unicode(false)]
    public string? ParentObjectName { get; set; }

    [Column("status_in_knowledge_map")]
    [Unicode(false)]
    public string? StatusInKnowledgeMap { get; set; }

    [Column("kp_start_date", TypeName = "datetime")]
    public DateTime? KpStartDate { get; set; }

    [Column("kp_end_date", TypeName = "datetime")]
    public DateTime? KpEndDate { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("invariable")]
    public bool? Invariable { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
