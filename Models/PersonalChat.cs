using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("personal_chats")]
public partial class PersonalChat
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("chat_id")]
    public long? ChatId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("confirmed")]
    public bool? Confirmed { get; set; }

    [Column("prohibited")]
    public bool? Prohibited { get; set; }

    [Column("partner_id")]
    public long? PartnerId { get; set; }

    [Column("partner_fullname")]
    [Unicode(false)]
    public string? PartnerFullname { get; set; }

    [Column("partner_confirmed")]
    public bool? PartnerConfirmed { get; set; }

    [Column("partner_prohibited")]
    public bool? PartnerProhibited { get; set; }

    [Column("last_message_date", TypeName = "datetime")]
    public DateTime? LastMessageDate { get; set; }

    [Column("last_view_date", TypeName = "datetime")]
    public DateTime? LastViewDate { get; set; }

    [Column("last_message_text")]
    [Unicode(false)]
    public string? LastMessageText { get; set; }

    [Column("last_message_sender_id")]
    public long? LastMessageSenderId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
