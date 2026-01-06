using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("doc_types")]
public partial class DocType
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

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("disp_name")]
    [Unicode(false)]
    public string? DispName { get; set; }

    [Column("is_crave_for_reboot")]
    public bool? IsCraveForReboot { get; set; }

    [Column("custom_web_template_id")]
    public long? CustomWebTemplateId { get; set; }

    [Column("custom_admin_template_id")]
    public long? CustomAdminTemplateId { get; set; }

    [Column("access_block_type")]
    [Unicode(false)]
    public string? AccessBlockType { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
