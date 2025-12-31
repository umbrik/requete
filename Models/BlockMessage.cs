using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("block_messages")]
public partial class BlockMessage
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("last_message_date", TypeName = "datetime")]
    public DateTime? LastMessageDate { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("all_message_read")]
    public bool? AllMessageRead { get; set; }

    [Column("count_message")]
    public long? CountMessage { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("disabled_data")]
    public bool? DisabledData { get; set; }

    [Column("has_link")]
    public bool? HasLink { get; set; }

    [Column("has_file")]
    public bool? HasFile { get; set; }

    [Column("recipient_id", TypeName = "xml")]
    public string? RecipientId { get; set; }

    [Column("unread_recipient_id", TypeName = "xml")]
    public string? UnreadRecipientId { get; set; }

    [Column("disp_role_id", TypeName = "xml")]
    public string? DispRoleId { get; set; }

    [Column("last_message_timestamp")]
    public long? LastMessageTimestamp { get; set; }

    [Column("message_timestamps", TypeName = "xml")]
    public string? MessageTimestamps { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("new_reaction_recipient_id", TypeName = "xml")]
    public string? NewReactionRecipientId { get; set; }

    [Column("last_message")]
    [Unicode(false)]
    public string? LastMessage { get; set; }

    [Column("last_message_is_file")]
    public bool? LastMessageIsFile { get; set; }

    [Column("different_last_message", TypeName = "xml")]
    public string? DifferentLastMessage { get; set; }

    [Column("last_message_id")]
    [Unicode(false)]
    public string? LastMessageId { get; set; }

    [Column("personal_message_timestamps", TypeName = "xml")]
    public string? PersonalMessageTimestamps { get; set; }

    [Column("update")]
    public bool? Update { get; set; }
}
