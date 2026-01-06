using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("vacancy_responses")]
public partial class VacancyResponse
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

    [Column("vacancy_id")]
    public long? VacancyId { get; set; }

    [Column("vacancy_name")]
    [Unicode(false)]
    public string? VacancyName { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("recruiter_person_id")]
    public long? RecruiterPersonId { get; set; }

    [Column("recruiter_person_fullname")]
    [Unicode(false)]
    public string? RecruiterPersonFullname { get; set; }

    [Column("response_author_person_id")]
    public long? ResponseAuthorPersonId { get; set; }

    [Column("response_author_fullname")]
    [Unicode(false)]
    public string? ResponseAuthorFullname { get; set; }

    [Column("resume_id")]
    public long? ResumeId { get; set; }

    [Column("career_reserve_id")]
    public long? CareerReserveId { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("date_invitation", TypeName = "datetime")]
    public DateTime? DateInvitation { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("user_access_role")]
    [Unicode(false)]
    public string? UserAccessRole { get; set; }

    [Column("user_group_id")]
    public long? UserGroupId { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modification_date", TypeName = "datetime")]
    public DateTime? ModificationDate { get; set; }

    [Column("app_instance_id")]
    [Unicode(false)]
    public string? AppInstanceId { get; set; }
}
