using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("workspace_configs")]
public partial class WorkspaceConfig
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

    [Column("is_enabled")]
    public bool? IsEnabled { get; set; }

    [Column("labels_file_url")]
    [Unicode(false)]
    public string? LabelsFileUrl { get; set; }

    [Column("default_theme_id")]
    [Unicode(false)]
    public string? DefaultThemeId { get; set; }

    [Column("show_conversation")]
    public bool? ShowConversation { get; set; }

    [Column("show_calendar")]
    public bool? ShowCalendar { get; set; }

    [Column("show_task")]
    public bool? ShowTask { get; set; }

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
