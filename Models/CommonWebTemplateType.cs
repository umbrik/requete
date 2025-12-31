using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.web_template_types")]
public partial class CommonWebTemplateType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("url")]
    [Unicode(false)]
    public string? Url { get; set; }

    [Column("mode")]
    [Unicode(false)]
    public string? Mode { get; set; }

    [Column("wvars", TypeName = "xml")]
    public string? Wvars { get; set; }

    [Column("wvars_selector")]
    [Unicode(false)]
    public string? WvarsSelector { get; set; }
}
