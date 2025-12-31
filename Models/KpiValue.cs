using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("kpi_values")]
public partial class KpiValue
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

    [Column("kpi_id")]
    public long? KpiId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("responsible_id")]
    public long? ResponsibleId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("fact")]
    public double? Fact { get; set; }

    [Column("fact_text")]
    [Unicode(false)]
    public string? FactText { get; set; }

    [Column("fact_value")]
    public double? FactValue { get; set; }

    [Column("value")]
    public double? Value { get; set; }

    [Column("object_catalog")]
    [Unicode(false)]
    public string? ObjectCatalog { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("expert_id", TypeName = "xml")]
    public string? ExpertId { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("workflow_state")]
    [Unicode(false)]
    public string? WorkflowState { get; set; }

    [Column("workflow_state_name")]
    [Unicode(false)]
    public string? WorkflowStateName { get; set; }

    [Column("workflow_person_id", TypeName = "xml")]
    public string? WorkflowPersonId { get; set; }

    [Column("workflow_matching_type")]
    [Unicode(false)]
    public string? WorkflowMatchingType { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
