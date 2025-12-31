using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("event_phases")]
public partial class EventPhase
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

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("is_public")]
    public bool? IsPublic { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("place_id")]
    public long? PlaceId { get; set; }

    [Column("lector_id")]
    public long? LectorId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("object_resource_id")]
    public long? ObjectResourceId { get; set; }
}
