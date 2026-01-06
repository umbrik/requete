using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("statement_components")]
public partial class StatementComponent
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("path")]
    [Unicode(false)]
    public string? Path { get; set; }

    [Column("property_name")]
    [Unicode(false)]
    public string? PropertyName { get; set; }

    [Column("component_id")]
    [Unicode(false)]
    public string? ComponentId { get; set; }

    [Column("statement_id")]
    public long? StatementId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
