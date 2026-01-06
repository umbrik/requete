using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("task_types")]
public partial class TaskType
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

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("create_task_type_id")]
    [Unicode(false)]
    public string? CreateTaskTypeId { get; set; }

    [Column("edit_task_type_id")]
    [Unicode(false)]
    public string? EditTaskTypeId { get; set; }

    [Column("view_task_type_id")]
    [Unicode(false)]
    public string? ViewTaskTypeId { get; set; }

    [Column("show_in_workspace")]
    public bool? ShowInWorkspace { get; set; }

    [Column("cannot_create_tt_less_minute")]
    public bool? CannotCreateTtLessMinute { get; set; }

    [Column("related_to_projects")]
    public bool? RelatedToProjects { get; set; }

    [Column("related_object_type")]
    [Unicode(false)]
    public string? RelatedObjectType { get; set; }

    [Column("virtual")]
    public bool? Virtual { get; set; }

    [Column("virtual_remote_collection_id")]
    public long? VirtualRemoteCollectionId { get; set; }

    [Column("virtual_remote_action_id")]
    public long? VirtualRemoteActionId { get; set; }

    [Column("workflow_remote_action_id")]
    public long? WorkflowRemoteActionId { get; set; }

    [Column("can_change_status")]
    public bool? CanChangeStatus { get; set; }

    [Column("can_change_task")]
    public bool? CanChangeTask { get; set; }

    [Column("can_delete_task")]
    public bool? CanDeleteTask { get; set; }

    [Column("related_conversation_type_id")]
    public long? RelatedConversationTypeId { get; set; }

    [Column("use_custom_wvars")]
    public bool? UseCustomWvars { get; set; }

    [Column("consider_time_in_workspace")]
    public bool? ConsiderTimeInWorkspace { get; set; }

    [Column("default_display_mode")]
    [Unicode(false)]
    public string? DefaultDisplayMode { get; set; }

    [Column("can_change_view")]
    public bool? CanChangeView { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }
}
