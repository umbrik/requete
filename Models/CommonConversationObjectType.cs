using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.conversation_object_types")]
public partial class CommonConversationObjectType
{
    [Key]
    [Column("object_type")]
    [StringLength(128)]
    [Unicode(false)]
    public string ObjectType { get; set; } = null!;

    [Column("is_fix_participants")]
    public bool? IsFixParticipants { get; set; }

    [Column("exclude_channel_participant")]
    public bool? ExcludeChannelParticipant { get; set; }
}
