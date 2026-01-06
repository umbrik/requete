using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.grading_option_types")]
public partial class CommonGradingOptionType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("option_id")]
    [Unicode(false)]
    public string? OptionId { get; set; }

    [Column("qti_tag")]
    [Unicode(false)]
    public string? QtiTag { get; set; }
}
