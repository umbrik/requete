using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("common.charts")]
public partial class CommonChart
{
    [Key]
    [Column("chart_id")]
    [StringLength(128)]
    [Unicode(false)]
    public string ChartId { get; set; } = null!;

    [Column("chart_type")]
    [Unicode(false)]
    public string? ChartType { get; set; }

    [Column("chart_subtypes", TypeName = "xml")]
    public string? ChartSubtypes { get; set; }

    [Column("chart_name")]
    [Unicode(false)]
    public string? ChartName { get; set; }

    [Column("icon")]
    [Unicode(false)]
    public string? Icon { get; set; }

    [Column("xcolor")]
    [Unicode(false)]
    public string? Xcolor { get; set; }

    [Column("xcolor2")]
    [Unicode(false)]
    public string? Xcolor2 { get; set; }

    [Column("xoverlap")]
    public long? Xoverlap { get; set; }

    [Column("xcolor_line")]
    [Unicode(false)]
    public string? XcolorLine { get; set; }

    [Column("flag_show_axis")]
    public bool? FlagShowAxis { get; set; }

    [Column("thickness")]
    public long? Thickness { get; set; }

    [Column("flag_color_datapoints")]
    public bool? FlagColorDatapoints { get; set; }

    [Column("flag_right_angle_axes")]
    public bool? FlagRightAngleAxes { get; set; }

    [Column("flag_foreign_caption")]
    public bool? FlagForeignCaption { get; set; }

    [Column("flag_show_percent")]
    public bool? FlagShowPercent { get; set; }
}
