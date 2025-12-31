using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("wiki_article_communications")]
public partial class WikiArticleCommunication
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

    [Column("wiki_article_comm_type_id")]
    public long? WikiArticleCommTypeId { get; set; }

    [Column("base_wiki_article_id")]
    public long? BaseWikiArticleId { get; set; }

    [Column("child_wiki_article_id")]
    public long? ChildWikiArticleId { get; set; }

    [Column("position")]
    public long? Position { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }
}
