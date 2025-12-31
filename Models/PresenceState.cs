using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("presence_states")]
public partial class PresenceState
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

    [Column("state_id")]
    [Unicode(false)]
    public string? StateId { get; set; }

    [Column("state_name")]
    [Unicode(false)]
    public string? StateName { get; set; }

    [Column("accessible")]
    public bool? Accessible { get; set; }

    [Column("is_absence")]
    public bool? IsAbsence { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("can_cancel")]
    public bool? CanCancel { get; set; }

    [Column("can_change")]
    public bool? CanChange { get; set; }

    [Column("cancel_workflow_id")]
    public long? CancelWorkflowId { get; set; }

    [Column("change_workflow_id")]
    public long? ChangeWorkflowId { get; set; }

    [Column("position")]
    public long? Position { get; set; }

    [Column("style_css")]
    [Unicode(false)]
    public string? StyleCss { get; set; }

    [Column("all_day")]
    public bool? AllDay { get; set; }

    [Column("is_sub_work_time")]
    public bool? IsSubWorkTime { get; set; }

    [Column("is_std")]
    public bool? IsStd { get; set; }

    [Column("changed")]
    public bool? Changed { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
