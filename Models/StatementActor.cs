using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("statement_actors")]
public partial class StatementActor
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("path")]
    [Unicode(false)]
    public string? Path { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("statement_id")]
    public long? StatementId { get; set; }

    [Column("mbox")]
    [Unicode(false)]
    public string? Mbox { get; set; }

    [Column("mbox_sha1sum")]
    [Unicode(false)]
    public string? MboxSha1sum { get; set; }

    [Column("openid")]
    [Unicode(false)]
    public string? Openid { get; set; }

    [Column("account_home_page")]
    [Unicode(false)]
    public string? AccountHomePage { get; set; }

    [Column("account_name")]
    [Unicode(false)]
    public string? AccountName { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
