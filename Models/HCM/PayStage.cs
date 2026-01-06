using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("pay_stages")]
public partial class PayStage
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

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("client_org_id")]
    public long? ClientOrgId { get; set; }

    [Column("sale_contract_id")]
    public long? SaleContractId { get; set; }

    [Column("agent_contract_id")]
    public long? AgentContractId { get; set; }

    [Column("is_agent_sale_contract")]
    public bool? IsAgentSaleContract { get; set; }

    [Column("agent_org_id")]
    public long? AgentOrgId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("is_prepayment")]
    public bool? IsPrepayment { get; set; }

    [Column("cost_type")]
    [Unicode(false)]
    public string? CostType { get; set; }

    [Column("min_cost")]
    public double? MinCost { get; set; }

    [Column("max_cost")]
    public double? MaxCost { get; set; }

    [Column("fact_cost")]
    public double? FactCost { get; set; }

    [Column("type_id")]
    [Unicode(false)]
    public string? TypeId { get; set; }

    [Column("closing_method")]
    [Unicode(false)]
    public string? ClosingMethod { get; set; }

    [Column("cost_center_id")]
    public long? CostCenterId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("is_autoclosing")]
    public bool? IsAutoclosing { get; set; }

    [Column("autoclosing_period")]
    public long? AutoclosingPeriod { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
