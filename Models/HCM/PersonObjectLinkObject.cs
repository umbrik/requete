using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("person_object_link_objects")]
public partial class PersonObjectLinkObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("person_object_id")]
    public long? PersonObjectId { get; set; }

    [Column("person_object_type")]
    [Unicode(false)]
    public string? PersonObjectType { get; set; }

    [Column("object_catalog")]
    [Unicode(false)]
    public string? ObjectCatalog { get; set; }

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

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("can_edit")]
    public bool? CanEdit { get; set; }

    [Column("can_delete")]
    public bool? CanDelete { get; set; }

    [Column("access_level")]
    public long? AccessLevel { get; set; }
}
