using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("person_object_links")]
public partial class PersonObjectLink
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("subject_id")]
    public long? SubjectId { get; set; }

    [Column("subject_type")]
    [Unicode(false)]
    public string? SubjectType { get; set; }

    [Column("object_catalog")]
    [Unicode(false)]
    public string? ObjectCatalog { get; set; }

    [Column("title")]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("all_can_create")]
    public bool? AllCanCreate { get; set; }

    [Column("all_can_edit")]
    public bool? AllCanEdit { get; set; }

    [Column("all_can_delete")]
    public bool? AllCanDelete { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
