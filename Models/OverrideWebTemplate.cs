using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("override_web_templates")]
public partial class OverrideWebTemplate
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

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("mode")]
    [Unicode(false)]
    public string? Mode { get; set; }

    [Column("mode_exception")]
    [Unicode(false)]
    public string? ModeException { get; set; }

    [Column("zone")]
    [Unicode(false)]
    public string? Zone { get; set; }

    [Column("custom_web_template_id")]
    public long? CustomWebTemplateId { get; set; }

    [Column("custom_web_template_name")]
    [Unicode(false)]
    public string? CustomWebTemplateName { get; set; }

    [Column("web_design_id")]
    public long? WebDesignId { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("weight")]
    public long? Weight { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("is_enabled")]
    public bool? IsEnabled { get; set; }

    [Column("wvars_num")]
    public long? WvarsNum { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
