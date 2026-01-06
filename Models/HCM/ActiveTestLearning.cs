using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("active_test_learnings")]
public partial class ActiveTestLearning
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("assessment_id")]
    public long? AssessmentId { get; set; }

    [Column("assessment_name")]
    [Unicode(false)]
    public string? AssessmentName { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }

    [Column("person_instance_id")]
    [Unicode(false)]
    public string? PersonInstanceId { get; set; }

    [Column("person_current_state")]
    [Unicode(false)]
    public string? PersonCurrentState { get; set; }

    [Column("event_id")]
    public long? EventId { get; set; }

    [Column("group_id")]
    public long? GroupId { get; set; }

    [Column("proctor_prefer_id")]
    public long? ProctorPreferId { get; set; }

    [Column("testing_link")]
    [Unicode(false)]
    public string? TestingLink { get; set; }

    [Column("start_usage_date", TypeName = "datetime")]
    public DateTime? StartUsageDate { get; set; }

    [Column("start_learning_date", TypeName = "datetime")]
    public DateTime? StartLearningDate { get; set; }

    [Column("last_usage_date", TypeName = "datetime")]
    public DateTime? LastUsageDate { get; set; }

    [Column("max_end_date", TypeName = "datetime")]
    public DateTime? MaxEndDate { get; set; }

    [Column("score")]
    public double? Score { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("time")]
    public long? Time { get; set; }

    [Column("use_proctoring")]
    public bool? UseProctoring { get; set; }

    [Column("is_self_enrolled")]
    public bool? IsSelfEnrolled { get; set; }

    [Column("max_score")]
    public double? MaxScore { get; set; }

    [Column("assessment_appraise_id")]
    public long? AssessmentAppraiseId { get; set; }

    [Column("education_plan_id")]
    public long? EducationPlanId { get; set; }

    [Column("question_num")]
    public long? QuestionNum { get; set; }

    [Column("question_answered_num")]
    public long? QuestionAnsweredNum { get; set; }

    [Column("question_passed_num")]
    public long? QuestionPassedNum { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

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
