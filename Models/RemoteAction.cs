using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("remote_actions")]
public partial class RemoteAction
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

    [Column("category")]
    [Unicode(false)]
    public string? Category { get; set; }

    [Column("catalog_name")]
    [Unicode(false)]
    public string? CatalogName { get; set; }

    [Column("link_name")]
    [Unicode(false)]
    public string? LinkName { get; set; }

    [Column("show_in_list")]
    public bool? ShowInList { get; set; }

    [Column("show_in_form")]
    public bool? ShowInForm { get; set; }

    [Column("url")]
    [Unicode(false)]
    public string? Url { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
