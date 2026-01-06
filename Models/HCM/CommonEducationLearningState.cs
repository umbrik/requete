using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.education_learning_states")]
public partial class CommonEducationLearningState
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("short_descriptor")]
    [Unicode(false)]
    public string? ShortDescriptor { get; set; }

    [Column("long_descriptor")]
    [Unicode(false)]
    public string? LongDescriptor { get; set; }

    [Column("text_color")]
    [Unicode(false)]
    public string? TextColor { get; set; }
}
