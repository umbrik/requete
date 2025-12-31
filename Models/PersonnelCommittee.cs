using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("personnel_committees")]
public partial class PersonnelCommittee
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

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("group_id")]
    public long? GroupId { get; set; }

    [Column("career_reserve_type_id")]
    public long? CareerReserveTypeId { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("participants_status")]
    [Unicode(false)]
    public string? ParticipantsStatus { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("committee_date", TypeName = "datetime")]
    public DateTime? CommitteeDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

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

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
