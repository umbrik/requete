using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.timezones")]
public partial class CommonTimezone
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("direction")]
    public long? Direction { get; set; }

    [Column("tm")]
    public double? Tm { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }
}
