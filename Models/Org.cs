using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("orgs")]
public partial class Org
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

    [Column("disp_name")]
    [Unicode(false)]
    public string? DispName { get; set; }

    [Column("account_id")]
    public long? AccountId { get; set; }

    [Column("kpi_profile_id")]
    public long? KpiProfileId { get; set; }

    [Column("kpi_profiles_id", TypeName = "xml")]
    public string? KpiProfilesId { get; set; }

    [Column("bonus_profile_id")]
    public long? BonusProfileId { get; set; }

    [Column("place_id")]
    public long? PlaceId { get; set; }

    [Column("region_id")]
    public long? RegionId { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("tag_id", TypeName = "xml")]
    public string? TagId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
