using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("conversations")]
public partial class Conversation
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

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("conversation_type_id")]
    public long? ConversationTypeId { get; set; }

    [Column("format_id")]
    [Unicode(false)]
    public string? FormatId { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("custom_state_id")]
    [Unicode(false)]
    public string? CustomStateId { get; set; }

    [Column("is_public")]
    public bool? IsPublic { get; set; }

    [Column("position_priority")]
    public long? PositionPriority { get; set; }

    [Column("list_css")]
    [Unicode(false)]
    public string? ListCss { get; set; }

    [Column("objects", TypeName = "xml")]
    public string? Objects { get; set; }

    [Column("active_object_type")]
    [Unicode(false)]
    public string? ActiveObjectType { get; set; }

    [Column("active_object_name")]
    [Unicode(false)]
    public string? ActiveObjectName { get; set; }

    [Column("active_object_id")]
    public long? ActiveObjectId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("participants_id", TypeName = "xml")]
    public string? ParticipantsId { get; set; }

    [Column("prohibit_write")]
    public bool? ProhibitWrite { get; set; }

    [Column("can_call")]
    public bool? CanCall { get; set; }

    [Column("can_change_participant")]
    public bool? CanChangeParticipant { get; set; }

    [Column("can_show_additional_info")]
    public bool? CanShowAdditionalInfo { get; set; }

    [Column("update_participant")]
    public bool? UpdateParticipant { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }
}
