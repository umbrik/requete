using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_register_students")]
public partial class DnRegisterStudent
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("register_id")]
    public long? RegisterId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("discipl_id")]
    public long? DisciplId { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }

    [Column("date_event", TypeName = "datetime")]
    public DateTime? DateEvent { get; set; }

    [Column("contr_form_id")]
    public long? ContrFormId { get; set; }

    [Column("student_id")]
    public long? StudentId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }
}
