using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("script_queue_elems")]
public partial class ScriptQueueElem
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("start_time", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("finish_time", TypeName = "datetime")]
    public DateTime? FinishTime { get; set; }

    [Column("delay")]
    public long? Delay { get; set; }

    [Column("completed")]
    public bool? Completed { get; set; }

    [Column("delete_automatically")]
    public bool? DeleteAutomatically { get; set; }

    [Column("block")]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
