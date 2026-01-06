using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("contest_marks")]
public partial class ContestMark
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("contest_id")]
    public long? ContestId { get; set; }

    [Column("contest_name")]
    [Unicode(false)]
    public string? ContestName { get; set; }

    [Column("participant_id")]
    public long? ParticipantId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("general_mark")]
    [Unicode(false)]
    public string? GeneralMark { get; set; }

    [Column("judge_id")]
    public long? JudgeId { get; set; }

    [Column("value")]
    [Unicode(false)]
    public string? Value { get; set; }

    [Column("rating")]
    public double? Rating { get; set; }

    [Column("place")]
    public long? Place { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
