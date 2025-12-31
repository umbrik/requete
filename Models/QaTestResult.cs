using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("qa_test_results")]
public partial class QaTestResult
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("test_id")]
    public long? TestId { get; set; }

    [Column("test_set_id")]
    public long? TestSetId { get; set; }

    [Column("test_paramset_id")]
    public long? TestParamsetId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("work_status")]
    [Unicode(false)]
    public string? WorkStatus { get; set; }

    [Column("finish_status")]
    [Unicode(false)]
    public string? FinishStatus { get; set; }

    [Column("error_code")]
    public long? ErrorCode { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
