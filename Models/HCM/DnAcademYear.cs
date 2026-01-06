using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_academ_years")]
public partial class DnAcademYear
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("start_year")]
    [Unicode(false)]
    public string? StartYear { get; set; }

    [Column("end_year")]
    [Unicode(false)]
    public string? EndYear { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("amount_week_autumnal_term")]
    public long? AmountWeekAutumnalTerm { get; set; }

    [Column("amount_week_spring_term")]
    public long? AmountWeekSpringTerm { get; set; }

    [Column("str_years")]
    [Unicode(false)]
    public string? StrYears { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
