using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("career_trees")]
public partial class CareerTree
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("current_position_name")]
    [Unicode(false)]
    public string? CurrentPositionName { get; set; }

    [Column("position_name")]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("position_collaborator_fullname")]
    [Unicode(false)]
    public string? PositionCollaboratorFullname { get; set; }
}
