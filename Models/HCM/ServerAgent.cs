using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("server_agents")]
public partial class ServerAgent
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

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("trigger_type")]
    [Unicode(false)]
    public string? TriggerType { get; set; }

    [Column("period")]
    public long? Period { get; set; }

    [Column("start_time")]
    [Unicode(false)]
    public string? StartTime { get; set; }

    [Column("finish_time")]
    [Unicode(false)]
    public string? FinishTime { get; set; }

    [Column("all_day")]
    public bool? AllDay { get; set; }

    [Column("start_day")]
    public long? StartDay { get; set; }

    [Column("start_week_day")]
    public long? StartWeekDay { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("last_run_date", TypeName = "datetime")]
    public DateTime? LastRunDate { get; set; }

    [Column("block")]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
