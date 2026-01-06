using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("order_types")]
public partial class OrderType
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

    [Column("number")]
    [Unicode(false)]
    public string? Number { get; set; }

    [Column("prefix")]
    [Unicode(false)]
    public string? Prefix { get; set; }

    [Column("suffix")]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [Column("signing_person_fullname")]
    [Unicode(false)]
    public string? SigningPersonFullname { get; set; }

    [Column("responsible_person_fullname")]
    [Unicode(false)]
    public string? ResponsiblePersonFullname { get; set; }

    [Column("performer_person_fullname")]
    [Unicode(false)]
    public string? PerformerPersonFullname { get; set; }

    [Column("default_flag")]
    public bool? DefaultFlag { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
