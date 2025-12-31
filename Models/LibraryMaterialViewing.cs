using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("library_material_viewings")]
public partial class LibraryMaterialViewing
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("material_id")]
    public long? MaterialId { get; set; }

    [Column("material_name")]
    [Unicode(false)]
    public string? MaterialName { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("start_viewing_date", TypeName = "datetime")]
    public DateTime? StartViewingDate { get; set; }

    [Column("last_viewing_date", TypeName = "datetime")]
    public DateTime? LastViewingDate { get; set; }

    [Column("finish_viewing_date", TypeName = "datetime")]
    public DateTime? FinishViewingDate { get; set; }

    [Column("education_plan_id")]
    public long? EducationPlanId { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("creation_user_id")]
    public long? CreationUserId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("modification_user_id")]
    public long? ModificationUserId { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
