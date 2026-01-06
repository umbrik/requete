using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("contacts")]
public partial class Contact
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("project_id")]
    public long? ProjectId { get; set; }

    [Column("type_id")]
    public long? TypeId { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("result_id")]
    public long? ResultId { get; set; }

    [Column("initiator_person_id")]
    public long? InitiatorPersonId { get; set; }

    [Column("initiator_person_fullname")]
    [Unicode(false)]
    public string? InitiatorPersonFullname { get; set; }

    [Column("contact_person_id")]
    public long? ContactPersonId { get; set; }

    [Column("contact_person_fullname")]
    [Unicode(false)]
    public string? ContactPersonFullname { get; set; }

    [Column("contact_org_name")]
    [Unicode(false)]
    public string? ContactOrgName { get; set; }

    [Column("contact_position_name")]
    [Unicode(false)]
    public string? ContactPositionName { get; set; }

    [Column("contact_org_id")]
    public long? ContactOrgId { get; set; }

    [Column("previous_contact_id")]
    public long? PreviousContactId { get; set; }

    [Column("contact_date", TypeName = "datetime")]
    public DateTime? ContactDate { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
