using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("device_regs")]
public partial class DeviceReg
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("device_id")]
    [Unicode(false)]
    public string? DeviceId { get; set; }

    [Column("last_access_date", TypeName = "datetime")]
    public DateTime? LastAccessDate { get; set; }

    [Column("mobile_app_config_id")]
    public long? MobileAppConfigId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

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

    [Column("tokens", TypeName = "xml")]
    public string? Tokens { get; set; }
}
