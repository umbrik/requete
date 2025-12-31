using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("course_parts")]
public partial class CoursePart
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

    [Column("course_id")]
    public long? CourseId { get; set; }

    [Column("part_code")]
    [Unicode(false)]
    public string? PartCode { get; set; }

    [Column("parent_part_code")]
    [Unicode(false)]
    public string? ParentPartCode { get; set; }

    [Column("part_name")]
    [Unicode(false)]
    public string? PartName { get; set; }

    [Column("part_type")]
    [Unicode(false)]
    public string? PartType { get; set; }

    [Column("course_module_id")]
    public long? CourseModuleId { get; set; }

    [Column("assessment_id")]
    public long? AssessmentId { get; set; }

    [Column("activity_id")]
    public long? ActivityId { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }
}
