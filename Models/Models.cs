using System.ComponentModel.DataAnnotations.Schema;

namespace requete.Models;

[Table("collaborators")]
public partial class Collaborator
{
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("fullname")]
    public string? Fullname { get; set; }
}

[Table("learnings")]
public partial class Learning
{
    [Column("id")]
    public long Id { get; set; }

    [Column("course_name")]
    public string? Course { get; set; }

    [Column("person_fullname")]
    public string? Fullname { get; set; }
}

public class SessionData
{
    public long SessionId { get; set; }
    public long UserId { get; set; }
    public string? UserFullname { get; set; }
}