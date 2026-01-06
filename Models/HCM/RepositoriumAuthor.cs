using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("repositorium_authors")]
public partial class RepositoriumAuthor
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("repositorium_id")]
    public long? RepositoriumId { get; set; }

    [Column("repositorium_name")]
    [Unicode(false)]
    public string? RepositoriumName { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }
}
