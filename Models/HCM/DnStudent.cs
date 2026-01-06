using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("dn_students")]
public partial class DnStudent
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("type")]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("email")]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("phone")]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("region")]
    [Unicode(false)]
    public string? Region { get; set; }

    [Column("adress_fact_live")]
    [Unicode(false)]
    public string? AdressFactLive { get; set; }

    [Column("special_id")]
    public long? SpecialId { get; set; }

    [Column("specialization_id")]
    public long? SpecializationId { get; set; }

    [Column("educat_form_id")]
    [Unicode(false)]
    public string? EducatFormId { get; set; }

    [Column("edu_condition_id")]
    [Unicode(false)]
    public string? EduConditionId { get; set; }

    [Column("qualification_id")]
    public long? QualificationId { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("main_group_id")]
    public long? MainGroupId { get; set; }

    [Column("educat_groups")]
    [Unicode(false)]
    public string? EducatGroups { get; set; }

    [Column("stud_dt_id")]
    [Unicode(false)]
    public string? StudDtId { get; set; }

    [Column("educat_institution")]
    [Unicode(false)]
    public string? EducatInstitution { get; set; }

    [Column("is_excellent")]
    public bool? IsExcellent { get; set; }

    [Column("faculty_id")]
    public long? FacultyId { get; set; }

    [Column("chair_id")]
    public long? ChairId { get; set; }

    [Column("scient_adviser_id")]
    public long? ScientAdviserId { get; set; }

    [Column("subject")]
    [Unicode(false)]
    public string? Subject { get; set; }

    [Column("file_name")]
    [Unicode(false)]
    public string? FileName { get; set; }

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
