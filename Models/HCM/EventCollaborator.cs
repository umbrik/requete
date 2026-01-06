using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("event_collaborators")]
public partial class EventCollaborator
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("type_id")]
    [Unicode(false)]
    public string? TypeId { get; set; }

    [Column("event_type_id")]
    public long? EventTypeId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("person_num")]
    public long? PersonNum { get; set; }

    [Column("unnamed_person_num")]
    public long? UnnamedPersonNum { get; set; }

    [Column("organizational_form")]
    [Unicode(false)]
    public string? OrganizationalForm { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("education_org_name")]
    [Unicode(false)]
    public string? EducationOrgName { get; set; }

    [Column("total_cost")]
    public double? TotalCost { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("is_public")]
    public bool? IsPublic { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("is_model")]
    public bool? IsModel { get; set; }

    [Column("duration_fact")]
    public long? DurationFact { get; set; }

    [Column("collaborator_id")]
    public long? CollaboratorId { get; set; }

    [Column("education_method_id")]
    public long? EducationMethodId { get; set; }

    [Column("education_program_id")]
    public long? EducationProgramId { get; set; }

    [Column("education_plan_id")]
    public long? EducationPlanId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("is_collaborator")]
    public bool? IsCollaborator { get; set; }

    [Column("is_tutor")]
    public bool? IsTutor { get; set; }

    [Column("is_preparation")]
    public bool? IsPreparation { get; set; }
}
