using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("(spxml_blobs)")]
public partial class SpxmlBlob
{
    [Key]
    [Column("url")]
    [StringLength(256)]
    [Unicode(false)]
    public string Url { get; set; } = null!;

    [Column("data")]
    public byte[]? Data { get; set; }

    [Column("ext")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Ext { get; set; }

    [Column("ftime")]
    public byte[] Ftime { get; set; } = null!;

    [Column("created", TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column("modified", TypeName = "datetime")]
    public DateTime? Modified { get; set; }

    [Column("hashdata")]
    public byte[]? Hashdata { get; set; }
}
