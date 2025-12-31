using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("recruitment_events")]
public partial class RecruitmentEvent
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("vacancy_id")]
    public long? VacancyId { get; set; }

    [Column("estaff_event_type_id")]
    public long? EstaffEventTypeId { get; set; }

    [Column("estaff_event_type_status_id")]
    public long? EstaffEventTypeStatusId { get; set; }

    [Column("recruitment_system_id")]
    public long? RecruitmentSystemId { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

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
