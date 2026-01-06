using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("repositorium_resources")]
public partial class RepositoriumResource
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("repositorium_id")]
    public long? RepositoriumId { get; set; }

    [Column("repositorium_name")]
    [Unicode(false)]
    public string? RepositoriumName { get; set; }

    [Column("resource_id")]
    public long? ResourceId { get; set; }
}
