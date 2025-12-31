using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("chatbot_chats")]
public partial class ChatbotChat
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

    [Column("last_message_date", TypeName = "datetime")]
    public DateTime? LastMessageDate { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("bot_id")]
    [Unicode(false)]
    public string? BotId { get; set; }

    [Column("chatbot_stage_id")]
    public long? ChatbotStageId { get; set; }

    [Column("chatbot_type_id")]
    public long? ChatbotTypeId { get; set; }

    [Column("chatbot_id")]
    public long? ChatbotId { get; set; }

    [Column("conversation_id")]
    public long? ConversationId { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("prolongation_date", TypeName = "datetime")]
    public DateTime? ProlongationDate { get; set; }

    [Column("escalation_action")]
    [Unicode(false)]
    public string? EscalationAction { get; set; }

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

    [Column("use_escalation")]
    public bool? UseEscalation { get; set; }

    [Column("escalation_date", TypeName = "datetime")]
    public DateTime? EscalationDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
