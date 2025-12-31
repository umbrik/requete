using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("download_packages")]
public partial class DownloadPackage
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("package_id")]
    [Unicode(false)]
    public string? PackageId { get; set; }

    [Column("exchange_server_id")]
    public long? ExchangeServerId { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("package_date", TypeName = "datetime")]
    public DateTime? PackageDate { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
