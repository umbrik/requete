using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("recommendations")]
public partial class Recommendation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("fullname")]
    [Unicode(false)]
    public string? Fullname { get; set; }

    [Column("phone")]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("email")]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("work_phone")]
    [Unicode(false)]
    public string? WorkPhone { get; set; }

    [Column("mobile_phone")]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("vacancy_id")]
    public long? VacancyId { get; set; }

    [Column("vacancy_name")]
    [Unicode(false)]
    public string? VacancyName { get; set; }

    [Column("src_person_id")]
    public long? SrcPersonId { get; set; }

    [Column("src_person_fullname")]
    [Unicode(false)]
    public string? SrcPersonFullname { get; set; }

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
