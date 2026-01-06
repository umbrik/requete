using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("statements")]
public partial class Statement
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

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("create_ticks")]
    public long? CreateTicks { get; set; }

    [Column("timestamp", TypeName = "datetime")]
    public DateTime? Timestamp { get; set; }

    [Column("statement_ref_id")]
    [Unicode(false)]
    public string? StatementRefId { get; set; }

    [Column("voided")]
    public bool? Voided { get; set; }

    [Column("processed")]
    public bool? Processed { get; set; }

    [Column("learning_storage_id")]
    public long? LearningStorageId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("object_id")]
    public long? ObjectId { get; set; }

    [Column("object_type")]
    [Unicode(false)]
    public string? ObjectType { get; set; }

    [Column("object_name")]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [Column("activity_id")]
    public long? ActivityId { get; set; }

    [Column("activity_code")]
    [Unicode(false)]
    public string? ActivityCode { get; set; }

    [Column("verb_id")]
    [Unicode(false)]
    public string? VerbId { get; set; }

    [Column("verb_name")]
    [Unicode(false)]
    public string? VerbName { get; set; }

    [Column("agent_json_str")]
    [Unicode(false)]
    public string? AgentJsonStr { get; set; }

    [Column("registration")]
    [Unicode(false)]
    public string? Registration { get; set; }

    [Column("context_registration")]
    [Unicode(false)]
    public string? ContextRegistration { get; set; }

    [Column("context_instructor")]
    [Unicode(false)]
    public string? ContextInstructor { get; set; }

    [Column("context_team")]
    [Unicode(false)]
    public string? ContextTeam { get; set; }

    [Column("context_revision")]
    [Unicode(false)]
    public string? ContextRevision { get; set; }

    [Column("context_platform")]
    [Unicode(false)]
    public string? ContextPlatform { get; set; }

    [Column("context_language")]
    [Unicode(false)]
    public string? ContextLanguage { get; set; }

    [Column("context_statement")]
    [Unicode(false)]
    public string? ContextStatement { get; set; }

    [Column("result_score_max")]
    public double? ResultScoreMax { get; set; }

    [Column("result_score_min")]
    public double? ResultScoreMin { get; set; }

    [Column("result_score_raw")]
    public double? ResultScoreRaw { get; set; }

    [Column("result_score_scaled")]
    public double? ResultScoreScaled { get; set; }

    [Column("result_success")]
    public bool? ResultSuccess { get; set; }

    [Column("result_completion")]
    public bool? ResultCompletion { get; set; }

    [Column("result_response")]
    [Unicode(false)]
    public string? ResultResponse { get; set; }

    [Column("result_duration")]
    [Unicode(false)]
    public string? ResultDuration { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
