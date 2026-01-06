using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("kpis")]
public partial class Kpi
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("parent_object_id")]
    public long? ParentObjectId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("is_kpi")]
    public bool? IsKpi { get; set; }

    [Column("kpi_group_id")]
    public long? KpiGroupId { get; set; }

    [Column("range_min")]
    public long? RangeMin { get; set; }

    [Column("range_max")]
    public long? RangeMax { get; set; }

    [Column("owners_ids")]
    [Unicode(false)]
    public string? OwnersIds { get; set; }

    [Column("formula_id")]
    public long? FormulaId { get; set; }

    [Column("scale_id")]
    public long? ScaleId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("access_block_type")]
    [Unicode(false)]
    public string? AccessBlockType { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("previous_version_object_id")]
    public long? PreviousVersionObjectId { get; set; }
}
