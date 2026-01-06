using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("projects")]
public partial class Project
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

    [Column("org_id")]
    public long? OrgId { get; set; }

    [Column("subdivision_id")]
    public long? SubdivisionId { get; set; }

    [Column("group_id")]
    public long? GroupId { get; set; }

    [Column("contract_id")]
    public long? ContractId { get; set; }

    [Column("project_type_id")]
    public long? ProjectTypeId { get; set; }

    [Column("sale_contract_id")]
    public long? SaleContractId { get; set; }

    [Column("status")]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("is_model")]
    public bool? IsModel { get; set; }

    [Column("workflow_id")]
    public long? WorkflowId { get; set; }

    [Column("plan_labor_costs")]
    public long? PlanLaborCosts { get; set; }

    [Column("fact_labor_costs")]
    public long? FactLaborCosts { get; set; }

    [Column("percent_complete")]
    public long? PercentComplete { get; set; }

    [Column("team_selected")]
    public bool? TeamSelected { get; set; }

    [Column("start_date_plan", TypeName = "datetime")]
    public DateTime? StartDatePlan { get; set; }

    [Column("end_date_plan", TypeName = "datetime")]
    public DateTime? EndDatePlan { get; set; }

    [Column("start_date_fact", TypeName = "datetime")]
    public DateTime? StartDateFact { get; set; }

    [Column("end_date_fact", TypeName = "datetime")]
    public DateTime? EndDateFact { get; set; }

    [Column("allow_assessment")]
    public bool? AllowAssessment { get; set; }

    [Column("join_mode")]
    [Unicode(false)]
    public string? JoinMode { get; set; }

    [Column("resource_type_id")]
    public long? ResourceTypeId { get; set; }

    [Column("all_participant_view_task")]
    public bool? AllParticipantViewTask { get; set; }

    [Column("allow_assigning_tasks_to_all")]
    public bool? AllowAssigningTasksToAll { get; set; }

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

    [Column("role_id", TypeName = "xml")]
    public string? RoleId { get; set; }
}
