using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("sale_contracts")]
public partial class SaleContract
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

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("is_agent_contract")]
    public bool? IsAgentContract { get; set; }

    [Column("agent_org_id")]
    public long? AgentOrgId { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("client_org_id")]
    public long? ClientOrgId { get; set; }

    [Column("client_manager_id")]
    public long? ClientManagerId { get; set; }

    [Column("manager_id")]
    public long? ManagerId { get; set; }

    [Column("parent_sale_contract_id")]
    public long? ParentSaleContractId { get; set; }

    [Column("number")]
    [Unicode(false)]
    public string? Number { get; set; }

    [Column("serial_number")]
    [Unicode(false)]
    public string? SerialNumber { get; set; }

    [Column("date_signature", TypeName = "datetime")]
    public DateTime? DateSignature { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("client_legal")]
    [Unicode(false)]
    public string? ClientLegal { get; set; }

    [Column("provider_legal")]
    [Unicode(false)]
    public string? ProviderLegal { get; set; }

    [Column("client_legal_name")]
    [Unicode(false)]
    public string? ClientLegalName { get; set; }

    [Column("provider_legal_name")]
    [Unicode(false)]
    public string? ProviderLegalName { get; set; }

    [Column("bad_debt")]
    public bool? BadDebt { get; set; }

    [Column("contract_cost")]
    public double? ContractCost { get; set; }

    [Column("currency_type_id")]
    [Unicode(false)]
    public string? CurrencyTypeId { get; set; }

    [Column("contract_signature")]
    [Unicode(false)]
    public string? ContractSignature { get; set; }

    [Column("prev_contract_id")]
    public long? PrevContractId { get; set; }

    [Column("contract_type")]
    public long? ContractType { get; set; }

    [Column("sent_date", TypeName = "datetime")]
    public DateTime? SentDate { get; set; }

    [Column("recipient")]
    [Unicode(false)]
    public string? Recipient { get; set; }

    [Column("consignment_document_number")]
    [Unicode(false)]
    public string? ConsignmentDocumentNumber { get; set; }

    [Column("is_received")]
    public bool? IsReceived { get; set; }

    [Column("received_date", TypeName = "datetime")]
    public DateTime? ReceivedDate { get; set; }

    [Column("docs_comment")]
    [Unicode(false)]
    public string? DocsComment { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

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
