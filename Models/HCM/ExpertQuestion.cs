using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("expert_questions")]
public partial class ExpertQuestion
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("normative_date", TypeName = "datetime")]
    public DateTime? NormativeDate { get; set; }

    [Column("answer_date", TypeName = "datetime")]
    public DateTime? AnswerDate { get; set; }

    [Column("question")]
    [Unicode(false)]
    public string? Question { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("expert_id")]
    public long? ExpertId { get; set; }

    [Column("status")]
    public bool? Status { get; set; }

    [Column("is_faq")]
    public bool? IsFaq { get; set; }

    [Column("is_disclosed")]
    public bool? IsDisclosed { get; set; }

    [Column("question_file_id")]
    public long? QuestionFileId { get; set; }

    [Column("answer_file_id")]
    public long? AnswerFileId { get; set; }

    [Column("knowledge_parts")]
    [Unicode(false)]
    public string? KnowledgeParts { get; set; }

    [Column("tags")]
    [Unicode(false)]
    public string? Tags { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
