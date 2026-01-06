using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("person_hierarchys")]
public partial class PersonHierarchy
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("collaborator_id")]
    public long? CollaboratorId { get; set; }

    [Column("position_id")]
    public long? PositionId { get; set; }

    [Column("parent_sub_id")]
    public long? ParentSubId { get; set; }

    [Column("subdivision_id", TypeName = "xml")]
    public string? SubdivisionId { get; set; }

    [Column("ready")]
    public bool? Ready { get; set; }
}
