using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("conversation_types")]
public partial class ConversationType
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

    [Column("visible_type_id")]
    [Unicode(false)]
    public string? VisibleTypeId { get; set; }

    [Column("use_open_script")]
    public bool? UseOpenScript { get; set; }

    [Column("use_additional_info_script")]
    public bool? UseAdditionalInfoScript { get; set; }

    [Column("prohibit_write")]
    public bool? ProhibitWrite { get; set; }

    [Column("can_call")]
    public bool? CanCall { get; set; }

    [Column("can_change_participant")]
    public bool? CanChangeParticipant { get; set; }

    [Column("can_show_additional_info")]
    public bool? CanShowAdditionalInfo { get; set; }

    [Column("open_additional_info")]
    public bool? OpenAdditionalInfo { get; set; }

    [Column("chatbot_id")]
    public long? ChatbotId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
