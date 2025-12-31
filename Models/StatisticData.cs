using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("statistic_datas")]
public partial class StatisticData
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("statistic_rec_id")]
    public long? StatisticRecId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("value")]
    public double? Value { get; set; }

    [Column("value_str")]
    [Unicode(false)]
    public string? ValueStr { get; set; }

    [Column("value_date", TypeName = "datetime")]
    public DateTime? ValueDate { get; set; }

    [Column("statistic_date", TypeName = "datetime")]
    public DateTime? StatisticDate { get; set; }

    [Column("additinal_info")]
    [Unicode(false)]
    public string? AdditinalInfo { get; set; }

    [Column("period_type")]
    [Unicode(false)]
    public string? PeriodType { get; set; }

    [Column("period_minute")]
    public long? PeriodMinute { get; set; }

    [Column("period_hour")]
    public long? PeriodHour { get; set; }

    [Column("period_day")]
    public long? PeriodDay { get; set; }

    [Column("period_month")]
    public long? PeriodMonth { get; set; }

    [Column("period_quarter")]
    public long? PeriodQuarter { get; set; }

    [Column("period_year")]
    public long? PeriodYear { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
