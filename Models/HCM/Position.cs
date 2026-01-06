using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("positions")]
public partial class Position
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

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("parent_object_id")]
    public long? ParentObjectId { get; set; }

    [Column("basic_collaborator_id")]
    public long? BasicCollaboratorId { get; set; }

    [Column("basic_collaborator_fullname")]
    [Unicode(false)]
    public string? BasicCollaboratorFullname { get; set; }

    [Column("basic_rate")]
    public long? BasicRate { get; set; }

    [Column("is_boss")]
    public bool? IsBoss { get; set; }

    [Column("position_date", TypeName = "datetime")]
    public DateTime? PositionDate { get; set; }

    [Column("position_finish_date", TypeName = "datetime")]
    public DateTime? PositionFinishDate { get; set; }

    [Column("is_position_finished")]
    public bool? IsPositionFinished { get; set; }

    [Column("position_assignment_type")]
    [Unicode(false)]
    public string? PositionAssignmentType { get; set; }

    [Column("position_appointment_type_id")]
    public long? PositionAppointmentTypeId { get; set; }

    [Column("competence_profile_id")]
    public long? CompetenceProfileId { get; set; }

    [Column("kpi_profile_id")]
    public long? KpiProfileId { get; set; }

    [Column("kpi_profiles_id", TypeName = "xml")]
    public string? KpiProfilesId { get; set; }

    [Column("bonus_profile_id")]
    public long? BonusProfileId { get; set; }

    [Column("knowledge_profile_id")]
    public long? KnowledgeProfileId { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("position_family_id")]
    public long? PositionFamilyId { get; set; }

    [Column("staff_position_id")]
    public long? StaffPositionId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
