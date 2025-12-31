using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("calendar_events")]
public partial class CalendarEvent
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

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

    [Column("is_exception")]
    public bool? IsException { get; set; }

    [Column("instance_code")]
    [Unicode(false)]
    public string? InstanceCode { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("place_id")]
    public long? PlaceId { get; set; }

    [Column("region_id")]
    public long? RegionId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("plan_start_date", TypeName = "datetime")]
    public DateTime? PlanStartDate { get; set; }

    [Column("plan_end_date", TypeName = "datetime")]
    public DateTime? PlanEndDate { get; set; }

    [Column("participant_ids", TypeName = "xml")]
    public string? ParticipantIds { get; set; }

    [Column("tutor_ids", TypeName = "xml")]
    public string? TutorIds { get; set; }

    [Column("scheduler_week_days_ids", TypeName = "xml")]
    public string? SchedulerWeekDaysIds { get; set; }

    [Column("start_time")]
    [Unicode(false)]
    public string? StartTime { get; set; }

    [Column("end_time")]
    [Unicode(false)]
    public string? EndTime { get; set; }

    [Column("scheduler_type_id")]
    [Unicode(false)]
    public string? SchedulerTypeId { get; set; }

    [Column("week_type_id")]
    [Unicode(false)]
    public string? WeekTypeId { get; set; }

    [Column("confirm_participant_ids", TypeName = "xml")]
    public string? ConfirmParticipantIds { get; set; }

    [Column("not_participate_participant_ids", TypeName = "xml")]
    public string? NotParticipateParticipantIds { get; set; }

    [Column("next_start_date", TypeName = "datetime")]
    public DateTime? NextStartDate { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("notification_reminder_date", TypeName = "datetime")]
    public DateTime? NotificationReminderDate { get; set; }
}
