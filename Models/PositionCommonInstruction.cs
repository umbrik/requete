using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("position_common_instructions")]
public partial class PositionCommonInstruction
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

    [Column("position_common_id")]
    public long? PositionCommonId { get; set; }

    [Column("position_common_name")]
    [Unicode(false)]
    public string? PositionCommonName { get; set; }

    [Column("section_instruction_id")]
    public long? SectionInstructionId { get; set; }

    [Column("section_instruction_name")]
    [Unicode(false)]
    public string? SectionInstructionName { get; set; }

    [Column("desc")]
    [Unicode(false)]
    public string? Desc { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
