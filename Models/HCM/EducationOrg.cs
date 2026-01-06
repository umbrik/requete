using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("education_orgs")]
public partial class EducationOrg
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

    [Column("disp_name")]
    [Unicode(false)]
    public string? DispName { get; set; }

    [Column("resource_id")]
    public long? ResourceId { get; set; }

    [Column("contact_main")]
    [Unicode(false)]
    public string? ContactMain { get; set; }

    [Column("telephone_work")]
    [Unicode(false)]
    public string? TelephoneWork { get; set; }

    [Column("telephone_mobile")]
    [Unicode(false)]
    public string? TelephoneMobile { get; set; }

    [Column("fax")]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("email")]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("is_provider_courses")]
    public bool? IsProviderCourses { get; set; }

    [Column("provider_course_type_id")]
    public long? ProviderCourseTypeId { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
