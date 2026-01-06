using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("traning_orders")]
public partial class TraningOrder
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("number")]
    [Unicode(false)]
    public string? Number { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("signing_person_fullname")]
    [Unicode(false)]
    public string? SigningPersonFullname { get; set; }

    [Column("responsible_person_fullname")]
    [Unicode(false)]
    public string? ResponsiblePersonFullname { get; set; }

    [Column("performer_person_fullname")]
    [Unicode(false)]
    public string? PerformerPersonFullname { get; set; }

    [Column("order_type_id")]
    public long? OrderTypeId { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("pay_phase_id")]
    public long? PayPhaseId { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
