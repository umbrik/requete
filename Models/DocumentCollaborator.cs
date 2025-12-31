using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("document_collaborators")]
public partial class DocumentCollaborator
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("parent_object_type")]
    [Unicode(false)]
    public string? ParentObjectType { get; set; }

    [Column("parent_object_id")]
    public long? ParentObjectId { get; set; }

    [Column("parent_object_name")]
    [Unicode(false)]
    public string? ParentObjectName { get; set; }

    [Column("site_id")]
    public long? SiteId { get; set; }

    [Column("document_id")]
    public long? DocumentId { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name")]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("can_create")]
    public bool? CanCreate { get; set; }

    [Column("can_edit")]
    public bool? CanEdit { get; set; }

    [Column("can_delete")]
    public bool? CanDelete { get; set; }
}
