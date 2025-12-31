using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("contract_types")]
public partial class ContractType
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

    [Column("current_number")]
    [Unicode(false)]
    public string? CurrentNumber { get; set; }

    [Column("prefix")]
    [Unicode(false)]
    public string? Prefix { get; set; }

    [Column("suffix")]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [Column("default_flag")]
    public bool? DefaultFlag { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
