using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("learning_task_results")]
public partial class LearningTaskResult
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("learning_task_id")]
    public long? LearningTaskId { get; set; }

    [Column("learning_task_name")]
    [Unicode(false)]
    public string? LearningTaskName { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("expert_id")]
    public long? ExpertId { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("mark")]
    public long? Mark { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("start_execution_date", TypeName = "datetime")]
    public DateTime? StartExecutionDate { get; set; }

    [Column("finish_execution_date", TypeName = "datetime")]
    public DateTime? FinishExecutionDate { get; set; }

    [Column("plan_start_date", TypeName = "datetime")]
    public DateTime? PlanStartDate { get; set; }

    [Column("plan_end_date", TypeName = "datetime")]
    public DateTime? PlanEndDate { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("expired")]
    public bool? Expired { get; set; }

    [Column("education_plan_id")]
    public long? EducationPlanId { get; set; }

    [Column("active_learning_id")]
    public long? ActiveLearningId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
