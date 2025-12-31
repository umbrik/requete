using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("expenses")]
public partial class Expense
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

    [Column("pay_stage_id")]
    public long? PayStageId { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("currency_type_id")]
    [Unicode(false)]
    public string? CurrencyTypeId { get; set; }

    [Column("number")]
    [Unicode(false)]
    public string? Number { get; set; }

    [Column("expense_create_date", TypeName = "datetime")]
    public DateTime? ExpenseCreateDate { get; set; }

    [Column("is_formed")]
    public bool? IsFormed { get; set; }

    [Column("payment_plan_date", TypeName = "datetime")]
    public DateTime? PaymentPlanDate { get; set; }

    [Column("is_paid")]
    public bool? IsPaid { get; set; }

    [Column("payment_fact_date", TypeName = "datetime")]
    public DateTime? PaymentFactDate { get; set; }

    [Column("bad_debt")]
    public bool? BadDebt { get; set; }

    [Column("comment")]
    [Unicode(false)]
    public string? Comment { get; set; }

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

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
