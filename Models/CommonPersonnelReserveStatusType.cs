using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.personnel_reserve_status_types")]
public partial class CommonPersonnelReserveStatusType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("bk_color")]
    [Unicode(false)]
    public string? BkColor { get; set; }
}
