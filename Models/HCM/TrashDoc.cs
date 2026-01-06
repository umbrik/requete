using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("trash_docs")]
public partial class TrashDoc
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("del_date", TypeName = "datetime")]
    public DateTime? DelDate { get; set; }

    [Column("desc")]
    [Unicode(false)]
    public string? Desc { get; set; }
}
