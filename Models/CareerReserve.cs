using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("career_reserves")]
public partial class CareerReserf
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

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position")]
    [Unicode(false)]
    public string? PersonPosition { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("plan_readiness_date", TypeName = "datetime")]
    public DateTime? PlanReadinessDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("readiness_percent")]
    public long? ReadinessPercent { get; set; }

    [Column("personnel_reserve_id")]
    public long? PersonnelReserveId { get; set; }

    [Column("successor_id")]
    public long? SuccessorId { get; set; }

    [Column("career_plan_id")]
    public long? CareerPlanId { get; set; }

    [Column("position_type")]
    [Unicode(false)]
    public string? PositionType { get; set; }

    [Column("position_name")]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [Column("position_id")]
    public long? PositionId { get; set; }

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("development_programs_id", TypeName = "xml")]
    public string? DevelopmentProgramsId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
