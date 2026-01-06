using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.print_form_types")]
public partial class CommonPrintFormType
{
    [Key]
    [Column("id")]
    [StringLength(128)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("content_type")]
    [Unicode(false)]
    public string? ContentType { get; set; }

    [Column("extension")]
    [Unicode(false)]
    public string? Extension { get; set; }
}
