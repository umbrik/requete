using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("statistic_recs")]
public partial class StatisticRec
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

    [Column("is_enabled")]
    public bool? IsEnabled { get; set; }

    [Column("auto_calc")]
    public bool? AutoCalc { get; set; }

    [Column("last_calculate_date", TypeName = "datetime")]
    public DateTime? LastCalculateDate { get; set; }

    [Column("calc_period")]
    public long? CalcPeriod { get; set; }

    [Column("context_calc")]
    public bool? ContextCalc { get; set; }

    [Column("ready_to_analytics")]
    public bool? ReadyToAnalytics { get; set; }

    [Column("catalog_name")]
    [Unicode(false)]
    public string? CatalogName { get; set; }

    [Column("period_type", TypeName = "xml")]
    public string? PeriodType { get; set; }

    [Column("period_calc_type")]
    [Unicode(false)]
    public string? PeriodCalcType { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("depth")]
    public long? Depth { get; set; }

    [Column("norm_from")]
    public double? NormFrom { get; set; }

    [Column("norm_to")]
    public double? NormTo { get; set; }

    [Column("notification_type_id")]
    public long? NotificationTypeId { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("catalog", TypeName = "xml")]
    public string? Catalog { get; set; }

    [Column("access_block_type")]
    [Unicode(false)]
    public string? AccessBlockType { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
