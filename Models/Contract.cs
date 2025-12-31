using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("contracts")]
public partial class Contract
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

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("number")]
    [Unicode(false)]
    public string? Number { get; set; }

    [Column("contract_type_id")]
    public long? ContractTypeId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("cost_nds")]
    public double? CostNds { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("files_count")]
    public long? FilesCount { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
