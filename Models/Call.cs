using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("calls")]
public partial class Call
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

    [Column("conversation_id")]
    public long? ConversationId { get; set; }

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

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("plan_start_date", TypeName = "datetime")]
    public DateTime? PlanStartDate { get; set; }

    [Column("plan_end_date", TypeName = "datetime")]
    public DateTime? PlanEndDate { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("active_participants_id", TypeName = "xml")]
    public string? ActiveParticipantsId { get; set; }

    [Column("participants_id", TypeName = "xml")]
    public string? ParticipantsId { get; set; }

    [Column("entered_participants_id", TypeName = "xml")]
    public string? EnteredParticipantsId { get; set; }

    [Column("missed_unread_participants_id", TypeName = "xml")]
    public string? MissedUnreadParticipantsId { get; set; }
}
