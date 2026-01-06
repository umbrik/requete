using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("event_object_resources")]
public partial class EventObjectResource
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("type_id")]
    [Unicode(false)]
    public string? TypeId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("person_num")]
    public long? PersonNum { get; set; }

    [Column("place_id")]
    public long? PlaceId { get; set; }

    [Column("object_resource_id")]
    public long? ObjectResourceId { get; set; }

    [Column("object_resource_name")]
    [Unicode(false)]
    public string? ObjectResourceName { get; set; }

    [Column("object_resource_type")]
    [Unicode(false)]
    public string? ObjectResourceType { get; set; }
}
