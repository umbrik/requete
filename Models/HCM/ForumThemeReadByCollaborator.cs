using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("forum_theme_read_by_collaborators")]
public partial class ForumThemeReadByCollaborator
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("forum_id")]
    public long? ForumId { get; set; }

    [Column("forum_theme_id")]
    public long? ForumThemeId { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
