using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.server_settings")]
public partial class CommonServerSetting
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("user_name")]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("passive_in_modes")]
    [Unicode(false)]
    public string? PassiveInModes { get; set; }

    [Column("default_value")]
    [Unicode(false)]
    public string? DefaultValue { get; set; }
}
