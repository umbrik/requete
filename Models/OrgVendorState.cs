using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("org_vendor_states")]
public partial class OrgVendorState
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

    [Column("vendor_status_id")]
    public long? VendorStatusId { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("vendor_status_type_id")]
    [Unicode(false)]
    public string? VendorStatusTypeId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("recertification_date", TypeName = "datetime")]
    public DateTime? RecertificationDate { get; set; }

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
