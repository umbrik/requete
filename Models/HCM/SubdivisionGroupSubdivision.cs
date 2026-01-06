using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("subdivision_group_subdivisions")]
public partial class SubdivisionGroupSubdivision
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("subdivision_group_id")]
    public long? SubdivisionGroupId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("is_dynamic")]
    public bool? IsDynamic { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("subdivision_name")]
    [Unicode(false)]
    public string? SubdivisionName { get; set; }
}
