using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("recommender_select_collaborators")]
public partial class RecommenderSelectCollaborator
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

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

    [Column("recommender_algorithm_id")]
    public long? RecommenderAlgorithmId { get; set; }

    [Column("base_object_id")]
    public long? BaseObjectId { get; set; }

    [Column("base_object_type")]
    [Unicode(false)]
    public string? BaseObjectType { get; set; }

    [Column("base_object_name")]
    [Unicode(false)]
    public string? BaseObjectName { get; set; }

    [Column("selected_object_id")]
    public long? SelectedObjectId { get; set; }

    [Column("selected_object_type")]
    [Unicode(false)]
    public string? SelectedObjectType { get; set; }

    [Column("selected_object_name")]
    [Unicode(false)]
    public string? SelectedObjectName { get; set; }

    [Column("created_object_id")]
    public long? CreatedObjectId { get; set; }

    [Column("created_object_type")]
    [Unicode(false)]
    public string? CreatedObjectType { get; set; }

    [Column("created_object_name")]
    [Unicode(false)]
    public string? CreatedObjectName { get; set; }

    [Column("implemented")]
    public bool? Implemented { get; set; }

    [Column("selected_date", TypeName = "datetime")]
    public DateTime? SelectedDate { get; set; }

    [Column("implemented_date", TypeName = "datetime")]
    public DateTime? ImplementedDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
