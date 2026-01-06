using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("group_collaborators")]
public partial class GroupCollaborator
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("group_id")]
    public long? GroupId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("forum_id")]
    public long? ForumId { get; set; }

    [Column("tutor_id")]
    public long? TutorId { get; set; }

    [Column("tutor_fullname")]
    [Unicode(false)]
    public string? TutorFullname { get; set; }

    [Column("is_dynamic")]
    public bool? IsDynamic { get; set; }

    [Column("is_hidden")]
    public bool? IsHidden { get; set; }

    [Column("allow_social_post")]
    public bool? AllowSocialPost { get; set; }

    [Column("collaborator_id")]
    public long? CollaboratorId { get; set; }

    [Column("collaborator_fullname")]
    [Unicode(false)]
    public string? CollaboratorFullname { get; set; }

    [Column("position_id")]
    public long? PositionId { get; set; }
}
