using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_discipl_blocks")]
public partial class DnDisciplBlock
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("block_id")]
    public long? BlockId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("discipl_id")]
    public long? DisciplId { get; set; }
}
