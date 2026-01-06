using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("learning_records")]
public partial class LearningRecord
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("proctoring_object_type")]
    [Unicode(false)]
    public string? ProctoringObjectType { get; set; }

    [Column("proctoring_object_id")]
    public long? ProctoringObjectId { get; set; }

    [Column("proctoring_object_name")]
    [Unicode(false)]
    public string? ProctoringObjectName { get; set; }

    [Column("proctoring_system_id")]
    public long? ProctoringSystemId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("is_finish_record")]
    public bool? IsFinishRecord { get; set; }

    [Column("num_failed_checked_foto")]
    public long? NumFailedCheckedFoto { get; set; }

    [Column("check_foto_state_id")]
    [Unicode(false)]
    public string? CheckFotoStateId { get; set; }

    [Column("download_materials")]
    public bool? DownloadMaterials { get; set; }

    [Column("active_session_id")]
    [Unicode(false)]
    public string? ActiveSessionId { get; set; }

    [Column("active_session_finish_date", TypeName = "datetime")]
    public DateTime? ActiveSessionFinishDate { get; set; }

    [Column("proctors_id", TypeName = "xml")]
    public string? ProctorsId { get; set; }

    [Column("archive_proctors_id", TypeName = "xml")]
    public string? ArchiveProctorsId { get; set; }

    [Column("is_prefer_proctor")]
    public bool? IsPreferProctor { get; set; }

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
