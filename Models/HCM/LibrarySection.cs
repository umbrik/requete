using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("library_sections")]
public partial class LibrarySection
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

    [Column("parent_object_id")]
    public long? ParentObjectId { get; set; }

    [Column("position")]
    public long? Position { get; set; }

    [Column("link")]
    [Unicode(false)]
    public string? Link { get; set; }

    [Column("external_id")]
    [Unicode(false)]
    public string? ExternalId { get; set; }

    [Column("external_import_date", TypeName = "datetime")]
    public DateTime? ExternalImportDate { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
