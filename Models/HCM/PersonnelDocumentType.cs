using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("personnel_document_types")]
public partial class PersonnelDocumentType
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

    [Column("org_signature_types", TypeName = "xml")]
    public string? OrgSignatureTypes { get; set; }

    [Column("person_signature_types", TypeName = "xml")]
    public string? PersonSignatureTypes { get; set; }

    [Column("person_first_signature")]
    public bool? PersonFirstSignature { get; set; }

    [Column("print_form_id")]
    public long? PrintFormId { get; set; }

    [Column("custom_web_template_id")]
    public long? CustomWebTemplateId { get; set; }

    [Column("personnel_event_code")]
    [Unicode(false)]
    public string? PersonnelEventCode { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
