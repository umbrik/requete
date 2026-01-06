using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("connections")]
public partial class Connection
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("course_id")]
    public long? CourseId { get; set; }

    [Column("part_code")]
    [Unicode(false)]
    public string? PartCode { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("user_code")]
    [Unicode(false)]
    public string? UserCode { get; set; }

    [Column("user_fullname")]
    [Unicode(false)]
    public string? UserFullname { get; set; }

    [Column("active_learning_id")]
    public long? ActiveLearningId { get; set; }

    [Column("learning_xml")]
    [Unicode(false)]
    public string? LearningXml { get; set; }

    [Column("state")]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("delete_date", TypeName = "datetime")]
    public DateTime? DeleteDate { get; set; }

    [Column("terminate_date", TypeName = "datetime")]
    public DateTime? TerminateDate { get; set; }

    [Column("unauthorized")]
    public bool? Unauthorized { get; set; }

    [Column("host_path")]
    [Unicode(false)]
    public string? HostPath { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
