using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("collaborator_schedules")]
public partial class CollaboratorSchedule
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_id")]
    public long? PersonPositionId { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_position_code")]
    [Unicode(false)]
    public string? PersonPositionCode { get; set; }

    [Column("person_org_id")]
    public long? PersonOrgId { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_org_code")]
    [Unicode(false)]
    public string? PersonOrgCode { get; set; }

    [Column("person_subdivision_id")]
    public long? PersonSubdivisionId { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }

    [Column("person_subdivision_code")]
    [Unicode(false)]
    public string? PersonSubdivisionCode { get; set; }

    [Column("person_instance_id")]
    [Unicode(false)]
    public string? PersonInstanceId { get; set; }

    [Column("person_code")]
    [Unicode(false)]
    public string? PersonCode { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("start_time")]
    [Unicode(false)]
    public string? StartTime { get; set; }

    [Column("finish_time")]
    [Unicode(false)]
    public string? FinishTime { get; set; }

    [Column("presence_state_id")]
    public long? PresenceStateId { get; set; }

    [Column("schedule_day_id")]
    public long? ScheduleDayId { get; set; }

    [Column("interval_schedule_id")]
    public long? IntervalScheduleId { get; set; }

    [Column("schedule_type_id")]
    public long? ScheduleTypeId { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("approval_date", TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    [Column("approval_person_id")]
    public long? ApprovalPersonId { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("rest_collaborator_schedule_id")]
    public long? RestCollaboratorScheduleId { get; set; }

    [Column("reason_comment")]
    [Unicode(false)]
    public string? ReasonComment { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
