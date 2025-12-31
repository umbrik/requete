using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("kpi_plans")]
public partial class KpiPlan
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

    [Column("threshold")]
    [Unicode(false)]
    public string? Threshold { get; set; }

    [Column("threshold_text")]
    [Unicode(false)]
    public string? ThresholdText { get; set; }

    [Column("threshold_value")]
    public double? ThresholdValue { get; set; }

    [Column("challenge")]
    [Unicode(false)]
    public string? Challenge { get; set; }

    [Column("challenge_text")]
    [Unicode(false)]
    public string? ChallengeText { get; set; }

    [Column("challenge_value")]
    public double? ChallengeValue { get; set; }

    [Column("plan")]
    [Unicode(false)]
    public string? Plan { get; set; }

    [Column("plan_text")]
    [Unicode(false)]
    public string? PlanText { get; set; }

    [Column("plan_value")]
    public double? PlanValue { get; set; }

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
