using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("wiki_articles")]
public partial class WikiArticle
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

    [Column("wiki_base_id")]
    public long? WikiBaseId { get; set; }

    [Column("content_type")]
    [Unicode(false)]
    public string? ContentType { get; set; }

    [Column("wiki_article_type_id")]
    public long? WikiArticleTypeId { get; set; }

    [Column("acquaint_type_id")]
    [Unicode(false)]
    public string? AcquaintTypeId { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("author_id", TypeName = "xml")]
    public string? AuthorId { get; set; }

    [Column("author_boss_type_id", TypeName = "xml")]
    public string? AuthorBossTypeId { get; set; }

    [Column("position")]
    public long? Position { get; set; }

    [Column("publicate_date", TypeName = "datetime")]
    public DateTime? PublicateDate { get; set; }

    [Column("critical_publicate_date", TypeName = "datetime")]
    public DateTime? CriticalPublicateDate { get; set; }

    [Column("acquaint_group_ids", TypeName = "xml")]
    public string? AcquaintGroupIds { get; set; }

    [Column("annotation")]
    [Unicode(false)]
    public string? Annotation { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("experts")]
    [Unicode(false)]
    public string? Experts { get; set; }

    [Column("files_id", TypeName = "xml")]
    public string? FilesId { get; set; }

    [Column("current_hash")]
    [Unicode(false)]
    public string? CurrentHash { get; set; }

    [Column("processed_embedding_hash")]
    [Unicode(false)]
    public string? ProcessedEmbeddingHash { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("access_group_ids", TypeName = "xml")]
    public string? AccessGroupIds { get; set; }

    [Column("enable_anonymous_access")]
    public bool? EnableAnonymousAccess { get; set; }
}
