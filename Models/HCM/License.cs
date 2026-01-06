using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("licenses")]
public partial class License
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

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("computer_name")]
    [Unicode(false)]
    public string? ComputerName { get; set; }

    [Column("domain_name")]
    [Unicode(false)]
    public string? DomainName { get; set; }

    [Column("domain_short_name")]
    [Unicode(false)]
    public string? DomainShortName { get; set; }

    [Column("user_name")]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column("is_temporary")]
    public bool? IsTemporary { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("sale_contract_id")]
    public long? SaleContractId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("maintaince_date", TypeName = "datetime")]
    public DateTime? MaintainceDate { get; set; }

    [Column("users_num")]
    public long? UsersNum { get; set; }

    [Column("demo")]
    public bool? Demo { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
