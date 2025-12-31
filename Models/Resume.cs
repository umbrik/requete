using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("resumes")]
public partial class Resume
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

    [Column("sex")]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column("email")]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("family_status")]
    [Unicode(false)]
    public string? FamilyStatus { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("person_org_name")]
    [Unicode(false)]
    public string? PersonOrgName { get; set; }

    [Column("person_subdivision")]
    [Unicode(false)]
    public string? PersonSubdivision { get; set; }

    [Column("person_position")]
    [Unicode(false)]
    public string? PersonPosition { get; set; }

    [Column("creator_person_id")]
    public long? CreatorPersonId { get; set; }

    [Column("creator_person_fullname")]
    [Unicode(false)]
    public string? CreatorPersonFullname { get; set; }

    [Column("forbid_portal_delete")]
    public bool? ForbidPortalDelete { get; set; }

    [Column("filling_type")]
    [Unicode(false)]
    public string? FillingType { get; set; }

    [Column("min_wage")]
    public long? MinWage { get; set; }

    [Column("max_wage")]
    public long? MaxWage { get; set; }

    [Column("currency_type_id")]
    [Unicode(false)]
    public string? CurrencyTypeId { get; set; }

    [Column("profession_id")]
    public long? ProfessionId { get; set; }

    [Column("profession_area_id")]
    [Unicode(false)]
    public string? ProfessionAreaId { get; set; }

    [Column("profession_area")]
    [Unicode(false)]
    public string? ProfessionArea { get; set; }

    [Column("region_id")]
    public long? RegionId { get; set; }

    [Column("employment_type_id")]
    [Unicode(false)]
    public string? EmploymentTypeId { get; set; }

    [Column("schedule_work_id")]
    [Unicode(false)]
    public string? ScheduleWorkId { get; set; }

    [Column("schedule_id")]
    public long? ScheduleId { get; set; }

    [Column("vacancy_source_id")]
    public long? VacancySourceId { get; set; }

    [Column("exp_years")]
    public double? ExpYears { get; set; }

    [Column("willingness_travel_type_id")]
    [Unicode(false)]
    public string? WillingnessTravelTypeId { get; set; }

    [Column("is_willing_relocate")]
    public bool? IsWillingRelocate { get; set; }

    [Column("main_educ_type_id")]
    [Unicode(false)]
    public string? MainEducTypeId { get; set; }

    [Column("education")]
    [Unicode(false)]
    public string? Education { get; set; }

    [Column("is_archive")]
    public bool? IsArchive { get; set; }

    [Column("is_candidate")]
    public bool? IsCandidate { get; set; }

    [Column("lng_id", TypeName = "xml")]
    public string? LngId { get; set; }

    [Column("educ_type_id", TypeName = "xml")]
    public string? EducTypeId { get; set; }

    [Column("education_type_id")]
    public long? EducationTypeId { get; set; }

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
