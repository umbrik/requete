using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("event_groups")]
public partial class EventGroup
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("type_id")]
    [Unicode(false)]
    public string? TypeId { get; set; }

    [Column("event_type_id")]
    public long? EventTypeId { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("person_num")]
    public long? PersonNum { get; set; }

    [Column("unnamed_person_num")]
    public long? UnnamedPersonNum { get; set; }

    [Column("organizational_form")]
    [Unicode(false)]
    public string? OrganizationalForm { get; set; }

    [Column("education_org_id")]
    public long? EducationOrgId { get; set; }

    [Column("education_org_name")]
    [Unicode(false)]
    public string? EducationOrgName { get; set; }

    [Column("total_cost")]
    public double? TotalCost { get; set; }

    [Column("currency")]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("group_id")]
    public long? GroupId { get; set; }
}
