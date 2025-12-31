using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("invoices")]
public partial class Invoice
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("is_paid")]
    public bool? IsPaid { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
