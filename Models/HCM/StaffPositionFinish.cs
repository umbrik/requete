using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("staff_position_finishs")]
public partial class StaffPositionFinish
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

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("subdivision_name")]
    [Unicode(false)]
    public string? SubdivisionName { get; set; }

    [Column("position_id")]
    public long? PositionId { get; set; }

    [Column("position_name")]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [Column("position_finish_date", TypeName = "datetime")]
    public DateTime? PositionFinishDate { get; set; }

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
