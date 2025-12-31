using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("recommender_algorithms")]
public partial class RecommenderAlgorithm
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("is_enabled")]
    public bool? IsEnabled { get; set; }

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

    [Column("code_library_id")]
    public long? CodeLibraryId { get; set; }

    [Column("is_cur_user")]
    public bool? IsCurUser { get; set; }

    [Column("is_object_type")]
    public bool? IsObjectType { get; set; }

    [Column("use_cache")]
    public bool? UseCache { get; set; }

    [Column("cache_time")]
    public long? CacheTime { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }
}
