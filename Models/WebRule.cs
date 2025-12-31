using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("web_rules")]
public partial class WebRule
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

    [Column("url")]
    [Unicode(false)]
    public string? Url { get; set; }

    [Column("is_enabled")]
    public bool? IsEnabled { get; set; }

    [Column("is_pattern")]
    public bool? IsPattern { get; set; }

    [Column("use_matches")]
    public bool? UseMatches { get; set; }

    [Column("redirect_url")]
    [Unicode(false)]
    public string? RedirectUrl { get; set; }

    [Column("redirect_type")]
    public long? RedirectType { get; set; }

    [Column("redirect_web_mode_id")]
    public long? RedirectWebModeId { get; set; }

    [Column("weight")]
    public long? Weight { get; set; }

    [Column("web_design_id")]
    public long? WebDesignId { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
