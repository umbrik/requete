using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("collaborators")]
public partial class Collaborator
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

    [Column("login")]
    [Unicode(false)]
    public string? Login { get; set; }

    [Column("short_login")]
    [Unicode(false)]
    public string? ShortLogin { get; set; }

    [Column("lowercase_login")]
    [Unicode(false)]
    public string? LowercaseLogin { get; set; }

    [Column("email")]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("phone")]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("mobile_phone")]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("sex")]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column("pict_url")]
    [Unicode(false)]
    public string? PictUrl { get; set; }

    [Column("position_id")]
    public long? PositionId { get; set; }

    [Column("position_name")]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [Column("position_parent_id")]
    public long? PositionParentId { get; set; }

    [Column("position_parent_name")]
    [Unicode(false)]
    public string? PositionParentName { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("org_name")]
    [Unicode(false)]
    public string? OrgName { get; set; }

    [Column("place_id")]
    public long? PlaceId { get; set; }

    [Column("region_id")]
    public long? RegionId { get; set; }

    [Column("category_id", TypeName = "xml")]
    public string? CategoryId { get; set; }

    [Column("web_banned")]
    public bool? WebBanned { get; set; }

    [Column("is_arm_admin")]
    public bool? IsArmAdmin { get; set; }

    [Column("is_content_admin")]
    public bool? IsContentAdmin { get; set; }

    [Column("is_application_admin")]
    public bool? IsApplicationAdmin { get; set; }

    [Column("role_id")]
    [Unicode(false)]
    public string? RoleId { get; set; }

    [Column("is_candidate")]
    public bool? IsCandidate { get; set; }

    [Column("candidate_status_type_id")]
    public long? CandidateStatusTypeId { get; set; }

    [Column("candidate_id")]
    public long? CandidateId { get; set; }

    [Column("is_outstaff")]
    public bool? IsOutstaff { get; set; }

    [Column("is_dismiss")]
    public bool? IsDismiss { get; set; }

    [Column("position_date", TypeName = "datetime")]
    public DateTime? PositionDate { get; set; }

    [Column("hire_date", TypeName = "datetime")]
    public DateTime? HireDate { get; set; }

    [Column("dismiss_date", TypeName = "datetime")]
    public DateTime? DismissDate { get; set; }

    [Column("in_request_black_list")]
    public bool? InRequestBlackList { get; set; }

    [Column("allow_personal_chat_request")]
    public bool? AllowPersonalChatRequest { get; set; }

    [Column("level_id")]
    public long? LevelId { get; set; }

    [Column("grade_id")]
    public long? GradeId { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("person_object_profile_id", TypeName = "xml")]
    public string? PersonObjectProfileId { get; set; }

    [Column("current_state")]
    [Unicode(false)]
    public string? CurrentState { get; set; }

    [Column("next_state_date", TypeName = "datetime")]
    public DateTime? NextStateDate { get; set; }

    [Column("development_potential_id")]
    public long? DevelopmentPotentialId { get; set; }

    [Column("efficiency_estimation_id")]
    public long? EfficiencyEstimationId { get; set; }

    [Column("consent_kedo")]
    public bool? ConsentKedo { get; set; }

    [Column("consent_kedo_date", TypeName = "datetime")]
    public DateTime? ConsentKedoDate { get; set; }

    [Column("provider_legal_id")]
    [Unicode(false)]
    public string? ProviderLegalId { get; set; }

    [Column("snils")]
    [Unicode(false)]
    public string? Snils { get; set; }

    [Column("cost_center_id")]
    public long? CostCenterId { get; set; }

    [Column("disp_birthdate")]
    public bool? DispBirthdate { get; set; }

    [Column("disp_birthdate_year")]
    public bool? DispBirthdateYear { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
