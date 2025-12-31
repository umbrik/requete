using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("assessment_plans")]
public partial class AssessmentPlan
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("assessment_appraise_id")]
    public long? AssessmentAppraiseId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_position_id")]
    public long? PersonPositionId { get; set; }

    [Column("person_position_parent_id")]
    public long? PersonPositionParentId { get; set; }

    [Column("expert_person_id")]
    public long? ExpertPersonId { get; set; }

    [Column("expert_person_fullname")]
    [Unicode(false)]
    public string? ExpertPersonFullname { get; set; }

    [Column("expert_person_position_name")]
    [Unicode(false)]
    public string? ExpertPersonPositionName { get; set; }

    [Column("expert_person_position_id")]
    public long? ExpertPersonPositionId { get; set; }

    [Column("expert_person_position_parent_id")]
    public long? ExpertPersonPositionParentId { get; set; }

    [Column("custom_experts")]
    [Unicode(false)]
    public string? CustomExperts { get; set; }

    [Column("custom_experts_array", TypeName = "xml")]
    public string? CustomExpertsArray { get; set; }

    [Column("is_custom_experts")]
    public bool? IsCustomExperts { get; set; }

    [Column("department_id")]
    public long? DepartmentId { get; set; }

    [Column("department_name")]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [Column("flag_appraise_department")]
    public bool? FlagAppraiseDepartment { get; set; }

    [Column("is_done")]
    public bool? IsDone { get; set; }

    [Column("assessment_appraise_type")]
    [Unicode(false)]
    public string? AssessmentAppraiseType { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("boss_id")]
    public long? BossId { get; set; }

    [Column("integral_mark")]
    public double? IntegralMark { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("workflow_state")]
    [Unicode(false)]
    public string? WorkflowState { get; set; }

    [Column("workflow_state_name")]
    [Unicode(false)]
    public string? WorkflowStateName { get; set; }

    [Column("workflow_state_last_date", TypeName = "datetime")]
    public DateTime? WorkflowStateLastDate { get; set; }

    [Column("is_workflow_init")]
    public bool? IsWorkflowInit { get; set; }

    [Column("flag_is_processed")]
    public bool? FlagIsProcessed { get; set; }

    [Column("workflow_person_id")]
    public long? WorkflowPersonId { get; set; }

    [Column("workflow_end_date", TypeName = "datetime")]
    public DateTime? WorkflowEndDate { get; set; }

    [Column("index")]
    public long? Index { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("period_start", TypeName = "datetime")]
    public DateTime? PeriodStart { get; set; }

    [Column("period_end", TypeName = "datetime")]
    public DateTime? PeriodEnd { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
