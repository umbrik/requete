using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_stud_centrtest_results")]
public partial class DnStudCentrtestResult
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("subject")]
    [Unicode(false)]
    public string? Subject { get; set; }

    [Column("mark")]
    public long? Mark { get; set; }

    [Column("result_date", TypeName = "datetime")]
    public DateTime? ResultDate { get; set; }

    [Column("student_id")]
    public long? StudentId { get; set; }

    [Column("student_fullname")]
    [Unicode(false)]
    public string? StudentFullname { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
