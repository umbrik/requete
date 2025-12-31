using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("benefit_profiles")]
public partial class BenefitProfile
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

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("position_family_id")]
    public long? PositionFamilyId { get; set; }

    [Column("subdivision_group_id")]
    public long? SubdivisionGroupId { get; set; }

    [Column("person_region_id")]
    public long? PersonRegionId { get; set; }

    [Column("subdivision_region_id")]
    public long? SubdivisionRegionId { get; set; }

    [Column("person_place_id")]
    public long? PersonPlaceId { get; set; }

    [Column("subdivision_place_id")]
    public long? SubdivisionPlaceId { get; set; }

    [Column("work_form_id")]
    public long? WorkFormId { get; set; }

    [Column("working_condition_type_id")]
    public long? WorkingConditionTypeId { get; set; }

    [Column("work_experience")]
    public long? WorkExperience { get; set; }

    [Column("position_commons_ids", TypeName = "xml")]
    public string? PositionCommonsIds { get; set; }

    [Column("grades_ids", TypeName = "xml")]
    public string? GradesIds { get; set; }

    [Column("benefits_ids", TypeName = "xml")]
    public string? BenefitsIds { get; set; }

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
