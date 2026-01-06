using System.ComponentModel.DataAnnotations.Schema;

namespace requete.Models;

public class SessionData
{
    public Int128 SessionId { get; set; }
    public long UserId { get; set; }
    public string? UserFullname { get; set; }
}