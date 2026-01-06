using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("events")]
public partial class Event
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

    [Column("is_model")]
    public bool? IsModel { get; set; }

    [Column("use_vclass")]
    public bool? UseVclass { get; set; }

    [Column("vclass_setting_id")]
    public long? VclassSettingId { get; set; }

    [Column("conversation_id")]
    public long? ConversationId { get; set; }

    [Column("compound_program_id")]
    public long? CompoundProgramId { get; set; }

    [Column("education_program_id")]
    public long? EducationProgramId { get; set; }

    [Column("education_method_id")]
    public long? EducationMethodId { get; set; }

    [Column("create_compound_program_id")]
    public long? CreateCompoundProgramId { get; set; }

    [Column("place_id")]
    public long? PlaceId { get; set; }

    [Column("vclass_host")]
    [Unicode(false)]
    public string? VclassHost { get; set; }

    [Column("record_exists")]
    public bool? RecordExists { get; set; }

    [Column("show_record")]
    public bool? ShowRecord { get; set; }

    [Column("parent_event_id")]
    public long? ParentEventId { get; set; }

    [Column("course_finished")]
    public long? CourseFinished { get; set; }

    [Column("course_process")]
    public long? CourseProcess { get; set; }

    [Column("course_started")]
    public long? CourseStarted { get; set; }

    [Column("course_began")]
    public long? CourseBegan { get; set; }

    [Column("test_finished")]
    public long? TestFinished { get; set; }

    [Column("test_process")]
    public long? TestProcess { get; set; }

    [Column("test_started")]
    public long? TestStarted { get; set; }

    [Column("test_began")]
    public long? TestBegan { get; set; }

    [Column("group_formed")]
    public bool? GroupFormed { get; set; }

    [Column("course_id")]
    public long? CourseId { get; set; }

    [Column("training_plan_id")]
    public long? TrainingPlanId { get; set; }

    [Column("is_public")]
    public bool? IsPublic { get; set; }

    [Column("is_open")]
    public bool? IsOpen { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("cost_type")]
    [Unicode(false)]
    public string? CostType { get; set; }

    [Column("budget_period_id")]
    public long? BudgetPeriodId { get; set; }

    [Column("distribute_cost_type")]
    [Unicode(false)]
    public string? DistributeCostType { get; set; }

    [Column("duration_fact")]
    public double? DurationFact { get; set; }

    [Column("duration_days_fact")]
    public double? DurationDaysFact { get; set; }

    [Column("mandatory_fill_response")]
    public bool? MandatoryFillResponse { get; set; }

    [Column("event_form")]
    [Unicode(false)]
    public string? EventForm { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("send_type")]
    [Unicode(false)]
    public string? SendType { get; set; }

    [Column("send_persons_types")]
    [Unicode(false)]
    public string? SendPersonsTypes { get; set; }

    [Column("group_educ_group_id")]
    [Unicode(false)]
    public string? GroupEducGroupId { get; set; }

    [Column("webinar_system_id")]
    public long? WebinarSystemId { get; set; }

    [Column("default_response_type_id")]
    public long? DefaultResponseTypeId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("tutor_main")]
    [Unicode(false)]
    public string? TutorMain { get; set; }

    [Column("poll_id")]
    public long? PollId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("notification_reminder_date", TypeName = "datetime")]
    public DateTime? NotificationReminderDate { get; set; }

    [Column("priority")]
    public long? Priority { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
