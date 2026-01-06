using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("acquaints")]
public partial class Acquaint
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

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("normative_date", TypeName = "datetime")]
    public DateTime? NormativeDate { get; set; }

    [Column("acquaint_num")]
    public long? AcquaintNum { get; set; }

    [Column("acquainted_num")]
    public long? AcquaintedNum { get; set; }

    [Column("collaborators")]
    [Unicode(false)]
    public string? Collaborators { get; set; }

    [Column("status")]
    public bool? Status { get; set; }

    [Column("reacquaintance_period")]
    public long? ReacquaintancePeriod { get; set; }

    [Column("assessments_id", TypeName = "xml")]
    public string? AssessmentsId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
