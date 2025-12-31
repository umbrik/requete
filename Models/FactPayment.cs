using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("fact_payments")]
public partial class FactPayment
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("client_org_id")]
    public long? ClientOrgId { get; set; }

    [Column("agent_org_id")]
    public long? AgentOrgId { get; set; }

    [Column("client_legal")]
    [Unicode(false)]
    public string? ClientLegal { get; set; }

    [Column("provider_legal")]
    [Unicode(false)]
    public string? ProviderLegal { get; set; }

    [Column("agent_legal")]
    [Unicode(false)]
    public string? AgentLegal { get; set; }

    [Column("client_legal_name")]
    [Unicode(false)]
    public string? ClientLegalName { get; set; }

    [Column("provider_legal_name")]
    [Unicode(false)]
    public string? ProviderLegalName { get; set; }

    [Column("agent_legal_name")]
    [Unicode(false)]
    public string? AgentLegalName { get; set; }

    [Column("cost_currency_type_id")]
    [Unicode(false)]
    public string? CostCurrencyTypeId { get; set; }

    [Column("cost_value")]
    public double? CostValue { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("expense_id")]
    public long? ExpenseId { get; set; }

    [Column("comment")]
    [Unicode(false)]
    public string? Comment { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
