using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("request_types")]
public partial class RequestType
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

    [Column("object_query_qual")]
    [Unicode(false)]
    public string? ObjectQueryQual { get; set; }

    [Column("is_group")]
    public bool? IsGroup { get; set; }

    [Column("forbid_rejection")]
    public bool? ForbidRejection { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("access_block_type")]
    [Unicode(false)]
    public string? AccessBlockType { get; set; }

    [Column("remote_action_id")]
    public long? RemoteActionId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
