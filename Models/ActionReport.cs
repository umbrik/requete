using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("action_reports")]
public partial class ActionReport
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("completed")]
    public bool? Completed { get; set; }

    [Column("exchange_server_id")]
    public long? ExchangeServerId { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("data_file_url")]
    [Unicode(false)]
    public string? DataFileUrl { get; set; }

    [Column("last_upload_date", TypeName = "datetime")]
    public DateTime? LastUploadDate { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
