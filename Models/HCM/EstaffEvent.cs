using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("estaff_events")]
public partial class EstaffEvent
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code_event")]
    [Unicode(false)]
    public string? CodeEvent { get; set; }

    [Column("event_name")]
    [Unicode(false)]
    public string? EventName { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("vacancy_id")]
    public long? VacancyId { get; set; }

    [Column("vacancy_name")]
    [Unicode(false)]
    public string? VacancyName { get; set; }

    [Column("vacancy_code")]
    [Unicode(false)]
    public string? VacancyCode { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("estaff_event_type_id")]
    public long? EstaffEventTypeId { get; set; }

    [Column("estaff_event_type_name")]
    [Unicode(false)]
    public string? EstaffEventTypeName { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("objects")]
    [Unicode(false)]
    public string? Objects { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("linked_object_url")]
    [Unicode(false)]
    public string? LinkedObjectUrl { get; set; }

    [Column("event_status_id")]
    [Unicode(false)]
    public string? EventStatusId { get; set; }

    [Column("estaff_event_eid")]
    public long? EstaffEventEid { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }
}
