using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("(ft_last_index)")]
public partial class FtLastIndex
{
    [Key]
    [Column("form")]
    [StringLength(128)]
    [Unicode(false)]
    public string Form { get; set; } = null!;

    [Column("last_ft_index_date", TypeName = "datetime")]
    public DateTime? LastFtIndexDate { get; set; }
}
