using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("tasks")]
public partial class Task
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

    [Column("task_type_id")]
    public long? TaskTypeId { get; set; }

    [Column("parent_task_id")]
    public long? ParentTaskId { get; set; }

    [Column("translated_task_id")]
    public long? TranslatedTaskId { get; set; }

    [Column("translated_target_type")]
    [Unicode(false)]
    public string? TranslatedTargetType { get; set; }

    [Column("translated_target_id")]
    public long? TranslatedTargetId { get; set; }

    [Column("assigner_id")]
    public long? AssignerId { get; set; }

    [Column("executor_type")]
    [Unicode(false)]
    public string? ExecutorType { get; set; }

    [Column("executor_id")]
    public long? ExecutorId { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("custom_state_id")]
    [Unicode(false)]
    public string? CustomStateId { get; set; }

    [Column("plan")]
    [Unicode(false)]
    public string? Plan { get; set; }

    [Column("fact")]
    [Unicode(false)]
    public string? Fact { get; set; }

    [Column("plan_value")]
    public double? PlanValue { get; set; }

    [Column("fact_value")]
    public double? FactValue { get; set; }

    [Column("value")]
    public double? Value { get; set; }

    [Column("readiness_percent")]
    public double? ReadinessPercent { get; set; }

    [Column("priority")]
    public long? Priority { get; set; }

    [Column("source_object_type")]
    [Unicode(false)]
    public string? SourceObjectType { get; set; }

    [Column("source_object_id")]
    public long? SourceObjectId { get; set; }

    [Column("pay_stage_id")]
    public long? PayStageId { get; set; }

    [Column("target_object_type")]
    [Unicode(false)]
    public string? TargetObjectType { get; set; }

    [Column("target_object_id")]
    public long? TargetObjectId { get; set; }

    [Column("fact_object_type")]
    [Unicode(false)]
    public string? FactObjectType { get; set; }

    [Column("fact_object_id")]
    public long? FactObjectId { get; set; }

    [Column("expert_id", TypeName = "xml")]
    public string? ExpertId { get; set; }

    [Column("date_plan", TypeName = "datetime")]
    public DateTime? DatePlan { get; set; }

    [Column("date_fact", TypeName = "datetime")]
    public DateTime? DateFact { get; set; }

    [Column("start_date_plan", TypeName = "datetime")]
    public DateTime? StartDatePlan { get; set; }

    [Column("end_date_plan", TypeName = "datetime")]
    public DateTime? EndDatePlan { get; set; }

    [Column("plan_budget_period_id")]
    public long? PlanBudgetPeriodId { get; set; }

    [Column("fact_budget_period_id")]
    public long? FactBudgetPeriodId { get; set; }

    [Column("plan_labor_costs")]
    public long? PlanLaborCosts { get; set; }

    [Column("fact_labor_costs")]
    public long? FactLaborCosts { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("desc")]
    [Unicode(false)]
    public string? Desc { get; set; }

    [Column("comment")]
    [Unicode(false)]
    public string? Comment { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

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

    [Column("conversation_id")]
    public long? ConversationId { get; set; }

    [Column("preparation_id", TypeName = "xml")]
    public string? PreparationId { get; set; }

    [Column("has_files")]
    public bool? HasFiles { get; set; }

    [Column("read_by_users", TypeName = "xml")]
    public string? ReadByUsers { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }
}
