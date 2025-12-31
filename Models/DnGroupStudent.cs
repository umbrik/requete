using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models;

[Table("dn_group_students")]
public partial class DnGroupStudent
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("student_id")]
    public long? StudentId { get; set; }

    [Column("person_id")]
    public long? PersonId { get; set; }

    [Column("lastname")]
    [Unicode(false)]
    public string? Lastname { get; set; }

    [Column("firstname")]
    [Unicode(false)]
    public string? Firstname { get; set; }

    [Column("middlename")]
    [Unicode(false)]
    public string? Middlename { get; set; }

    [Column("sex")]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("address")]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("phone")]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("mobile_phone")]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    [Column("mobile_phone_conf_code")]
    [Unicode(false)]
    public string? MobilePhoneConfCode { get; set; }

    [Column("mobile_phone_conf_date", TypeName = "datetime")]
    public DateTime? MobilePhoneConfDate { get; set; }

    [Column("mobile_phone_conf")]
    public bool? MobilePhoneConf { get; set; }

    [Column("email")]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("email_conf_code")]
    [Unicode(false)]
    public string? EmailConfCode { get; set; }

    [Column("email_conf_date", TypeName = "datetime")]
    public DateTime? EmailConfDate { get; set; }

    [Column("email_conf")]
    public bool? EmailConf { get; set; }

    [Column("system_email")]
    [Unicode(false)]
    public string? SystemEmail { get; set; }

    [Column("login")]
    [Unicode(false)]
    public string? Login { get; set; }

    [Column("password")]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("comment")]
    [Unicode(false)]
    public string? Comment { get; set; }

    [Column("person_fullname")]
    [Unicode(false)]
    public string? PersonFullname { get; set; }

    [Column("special_id")]
    public long? SpecialId { get; set; }

    [Column("specialization_id")]
    public long? SpecializationId { get; set; }

    [Column("status_id")]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [Column("main_group_id")]
    public long? MainGroupId { get; set; }

    [Column("group_id")]
    public long? GroupId { get; set; }
}
