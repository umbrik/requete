using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("education_plans")]
public partial class EducationPlan
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

    [Column("group_id")]
    public long? GroupId { get; set; }

    [Column("compound_program_id")]
    public long? CompoundProgramId { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("update_status_and_activity")]
    public bool? UpdateStatusAndActivity { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("fact_finish_date", TypeName = "datetime")]
    public DateTime? FactFinishDate { get; set; }

    [Column("plan_date", TypeName = "datetime")]
    public DateTime? PlanDate { get; set; }

    [Column("last_activity_date", TypeName = "datetime")]
    public DateTime? LastActivityDate { get; set; }

    [Column("mark")]
    public long? Mark { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("readiness_percent")]
    public long? ReadinessPercent { get; set; }

    [Column("development_plan_id")]
    public long? DevelopmentPlanId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("assessment_appraise_id")]
    public long? AssessmentAppraiseId { get; set; }

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
