using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("wiki_article_communication_types")]
public partial class WikiArticleCommunicationType
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

    [Column("wiki_communication_type_id")]
    [Unicode(false)]
    public string? WikiCommunicationTypeId { get; set; }

    [Column("base_wiki_article_type_id")]
    public long? BaseWikiArticleTypeId { get; set; }

    [Column("child_wiki_article_type_id")]
    public long? ChildWikiArticleTypeId { get; set; }

    [Column("is_mandatory")]
    public bool? IsMandatory { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
