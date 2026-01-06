using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("operations")]
public partial class Operation
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

    [Column("category")]
    [Unicode(false)]
    public string? Category { get; set; }

    [Column("operation_type")]
    public long? OperationType { get; set; }

    [Column("action")]
    [Unicode(false)]
    public string? Action { get; set; }

    [Column("operation_catalog_list")]
    [Unicode(false)]
    public string? OperationCatalogList { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("group")]
    [Unicode(false)]
    public string? Group { get; set; }

    [Column("is_system")]
    public bool? IsSystem { get; set; }

    [Column("remote_action_id")]
    public long? RemoteActionId { get; set; }

    [Column("use_script")]
    public bool? UseScript { get; set; }

    [Column("use_access_eval")]
    public bool? UseAccessEval { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("priority")]
    public long? Priority { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
