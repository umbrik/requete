using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("knowledge_acquaints")]
public partial class KnowledgeAcquaint
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("knowledge_part_id")]
    public long? KnowledgePartId { get; set; }

    [Column("knowledge_part_name")]
    [Unicode(false)]
    public string? KnowledgePartName { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_id")]
    public long? PersonPositionId { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_position_code")]
    [Unicode(false)]
    public string? PersonPositionCode { get; set; }

    [Column("person_org_id")]
    public long? PersonOrgId { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_org_code")]
    [Unicode(false)]
    public string? PersonOrgCode { get; set; }

    [Column("person_subdivision_id")]
    public long? PersonSubdivisionId { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }

    [Column("person_subdivision_code")]
    [Unicode(false)]
    public string? PersonSubdivisionCode { get; set; }

    [Column("person_instance_id")]
    [Unicode(false)]
    public string? PersonInstanceId { get; set; }

    [Column("person_code")]
    [Unicode(false)]
    public string? PersonCode { get; set; }

    [Column("level_id")]
    [Unicode(false)]
    public string? LevelId { get; set; }

    [Column("level_index")]
    public long? LevelIndex { get; set; }

    [Column("level_name")]
    [Unicode(false)]
    public string? LevelName { get; set; }

    [Column("sec_object_type")]
    [Unicode(false)]
    public string? SecObjectType { get; set; }

    [Column("sec_object_id")]
    public long? SecObjectId { get; set; }

    [Column("sec_object_name")]
    [Unicode(false)]
    public string? SecObjectName { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("type_id")]
    [Unicode(false)]
    public string? TypeId { get; set; }

    [Column("confirmation_date", TypeName = "datetime")]
    public DateTime? ConfirmationDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("confirmation_type")]
    [Unicode(false)]
    public string? ConfirmationType { get; set; }

    [Column("confirmation_expert_type")]
    [Unicode(false)]
    public string? ConfirmationExpertType { get; set; }

    [Column("confirmation_boss_type_id")]
    public long? ConfirmationBossTypeId { get; set; }

    [Column("project_participant_id")]
    public long? ProjectParticipantId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
