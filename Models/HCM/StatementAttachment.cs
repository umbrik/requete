using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("statement_attachments")]
public partial class StatementAttachment
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("path")]
    [Unicode(false)]
    public string? Path { get; set; }

    [Column("usage_type")]
    [Unicode(false)]
    public string? UsageType { get; set; }

    [Column("content_type")]
    [Unicode(false)]
    public string? ContentType { get; set; }

    [Column("length")]
    [Unicode(false)]
    public string? Length { get; set; }

    [Column("file_hash")]
    [Unicode(false)]
    public string? FileHash { get; set; }

    [Column("file_url")]
    [Unicode(false)]
    public string? FileUrl { get; set; }

    [Column("statement_id")]
    public long? StatementId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
