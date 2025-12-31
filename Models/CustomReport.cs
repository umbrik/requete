using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("custom_reports")]
public partial class CustomReport
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("object_name_type")]
    [Unicode(false)]
    public string? ObjectNameType { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("connect_2_object")]
    [Unicode(false)]
    public string? Connect2Object { get; set; }

    [Column("block")]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("access_block_type")]
    [Unicode(false)]
    public string? AccessBlockType { get; set; }

    [Column("subscription")]
    public bool? Subscription { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
