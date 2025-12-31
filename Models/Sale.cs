using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("sales")]
public partial class Sale
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

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("status_id")]
    public long? StatusId { get; set; }

    [Column("number")]
    [Unicode(false)]
    public string? Number { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("client_org_id")]
    public long? ClientOrgId { get; set; }

    [Column("project_id")]
    public long? ProjectId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("client_manager_id")]
    public long? ClientManagerId { get; set; }

    [Column("manager_id")]
    public long? ManagerId { get; set; }

    [Column("cost")]
    public long? Cost { get; set; }

    [Column("currency_type_id")]
    [Unicode(false)]
    public string? CurrencyTypeId { get; set; }

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
