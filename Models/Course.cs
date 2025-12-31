using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("courses")]
public partial class Course
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

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("price")]
    public double? Price { get; set; }

    [Column("mastery_score")]
    public double? MasteryScore { get; set; }

    [Column("max_score")]
    public double? MaxScore { get; set; }

    [Column("yourself_start")]
    public bool? YourselfStart { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("cl_course_id")]
    public long? ClCourseId { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("base_url")]
    [Unicode(false)]
    public string? BaseUrl { get; set; }

    [Column("default_response_type_id")]
    public long? DefaultResponseTypeId { get; set; }

    [Column("mandatory_fill_response")]
    public bool? MandatoryFillResponse { get; set; }

    [Column("allow_disp_response")]
    public bool? AllowDispResponse { get; set; }

    [Column("pwt_disp")]
    public bool? PwtDisp { get; set; }

    [Column("view_type")]
    [Unicode(false)]
    public string? ViewType { get; set; }

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

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }
}
