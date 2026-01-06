using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("event_assessment_plans")]
public partial class EventAssessmentPlan
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("expert_person_id")]
    public long? ExpertPersonId { get; set; }

    [Column("expert_person_fullname")]
    [Unicode(false)]
    public string? ExpertPersonFullname { get; set; }

    [Column("expert_person_position_name")]
    [Unicode(false)]
    public string? ExpertPersonPositionName { get; set; }

    [Column("date_start", TypeName = "datetime")]
    public DateTime? DateStart { get; set; }

    [Column("is_done")]
    public bool? IsDone { get; set; }

    [Column("assessment_type")]
    [Unicode(false)]
    public string? AssessmentType { get; set; }

    [Column("assessment_type_id")]
    [Unicode(false)]
    public string? AssessmentTypeId { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
