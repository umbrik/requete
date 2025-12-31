using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("submission_recipients")]
public partial class SubmissionRecipient
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("submission_type_id")]
    public long? SubmissionTypeId { get; set; }

    [Column("submission_type_name")]
    [Unicode(false)]
    public string? SubmissionTypeName { get; set; }

    [Column("collaborator_id")]
    public long? CollaboratorId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_position_name")]
    [Unicode(false)]
    public string? PersonPositionName { get; set; }

    [Column("person_subdivision_name")]
    [Unicode(false)]
    public string? PersonSubdivisionName { get; set; }
}
