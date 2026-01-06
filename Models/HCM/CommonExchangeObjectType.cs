using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[Table("common.exchange_object_types")]
public partial class CommonExchangeObjectType
{
    [Key]
    [Column("name")]
    [StringLength(128)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("disp_name")]
    [Unicode(false)]
    public string? DispName { get; set; }

    [Column("title")]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("web_title")]
    [Unicode(false)]
    public string? WebTitle { get; set; }

    [Column("web_template")]
    [Unicode(false)]
    public string? WebTemplate { get; set; }

    [Column("web_const")]
    [Unicode(false)]
    public string? WebConst { get; set; }

    [Column("is_hier")]
    public bool? IsHier { get; set; }

    [Column("is_custom")]
    public bool? IsCustom { get; set; }

    [Column("form_url")]
    [Unicode(false)]
    public string? FormUrl { get; set; }

    [Column("form_type")]
    public long? FormType { get; set; }

    [Column("max_records_num")]
    public long? MaxRecordsNum { get; set; }

    [Column("ft_index")]
    public bool? FtIndex { get; set; }
}
