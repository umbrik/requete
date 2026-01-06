using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("objective_translates")]
public partial class ObjectiveTranslate
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("assessment_appraise_id")]
    public long? AssessmentAppraiseId { get; set; }

    [Column("translator_person_id")]
    public long? TranslatorPersonId { get; set; }

    [Column("translator_person_fullname")]
    [Unicode(false)]
    public string? TranslatorPersonFullname { get; set; }

    [Column("translator_objective_id")]
    [Unicode(false)]
    public string? TranslatorObjectiveId { get; set; }

    [Column("translator_objective_name")]
    [Unicode(false)]
    public string? TranslatorObjectiveName { get; set; }

    [Column("translator_pa_id")]
    public long? TranslatorPaId { get; set; }

    [Column("recipient_person_id")]
    public long? RecipientPersonId { get; set; }

    [Column("recipient_objective_id")]
    [Unicode(false)]
    public string? RecipientObjectiveId { get; set; }

    [Column("recipient_objective_name")]
    [Unicode(false)]
    public string? RecipientObjectiveName { get; set; }

    [Column("recipient_pa_id")]
    public long? RecipientPaId { get; set; }

    [Column("recipient_person_fullname")]
    [Unicode(false)]
    public string? RecipientPersonFullname { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
