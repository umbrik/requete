using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("library_materials")]
public partial class LibraryMaterial
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("author")]
    [Unicode(false)]
    public string? Author { get; set; }

    [Column("section_id")]
    public long? SectionId { get; set; }

    [Column("sections_id", TypeName = "xml")]
    public string? SectionsId { get; set; }

    [Column("year")]
    public long? Year { get; set; }

    [Column("isbn")]
    [Unicode(false)]
    public string? Isbn { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("has_digital")]
    public bool? HasDigital { get; set; }

    [Column("has_physical")]
    public bool? HasPhysical { get; set; }

    [Column("allow_download")]
    public bool? AllowDownload { get; set; }

    [Column("allow_self_viewing")]
    public bool? AllowSelfViewing { get; set; }

    [Column("online_video_prepared")]
    public bool? OnlineVideoPrepared { get; set; }

    [Column("library_material_type_id")]
    public long? LibraryMaterialTypeId { get; set; }

    [Column("library_material_formats")]
    [Unicode(false)]
    public string? LibraryMaterialFormats { get; set; }

    [Column("external_id")]
    [Unicode(false)]
    public string? ExternalId { get; set; }

    [Column("external_import_date", TypeName = "datetime")]
    public DateTime? ExternalImportDate { get; set; }

    [Column("file_name")]
    public long? FileName { get; set; }

    [Column("is_need_admin_approval")]
    public bool? IsNeedAdminApproval { get; set; }

    [Column("is_closed")]
    public bool? IsClosed { get; set; }

    [Column("image")]
    public long? Image { get; set; }

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

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("status_in_knowledge_map")]
    [Unicode(false)]
    public string? StatusInKnowledgeMap { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
