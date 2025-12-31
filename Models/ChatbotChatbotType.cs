using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("chatbot_chatbot_types")]
public partial class ChatbotChatbotType
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("chatbot_code")]
    [Unicode(false)]
    public string? ChatbotCode { get; set; }

    [Column("bot_id")]
    [Unicode(false)]
    public string? BotId { get; set; }

    [Column("chatbot_id")]
    public long? ChatbotId { get; set; }

    [Column("chatbot_type_id")]
    public long? ChatbotTypeId { get; set; }

    [Column("webhook_url")]
    [Unicode(false)]
    public string? WebhookUrl { get; set; }
}
