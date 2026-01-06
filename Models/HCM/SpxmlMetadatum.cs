using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace requete.Models.HCM;

[PrimaryKey("Schema", "Form")]
[Table("(spxml_metadata)")]
public partial class SpxmlMetadatum
{
    [Key]
    [Column("schema")]
    [StringLength(64)]
    [Unicode(false)]
    public string Schema { get; set; } = null!;

    [Key]
    [Column("form")]
    [StringLength(64)]
    [Unicode(false)]
    public string Form { get; set; } = null!;

    [Column("tablename")]
    [StringLength(64)]
    [Unicode(false)]
    public string? Tablename { get; set; }

    [Column("hash")]
    [StringLength(64)]
    [Unicode(false)]
    public string? Hash { get; set; }

    [Column("doc_list")]
    public bool? DocList { get; set; }

    [Column("primary_key")]
    [StringLength(64)]
    [Unicode(false)]
    public string? PrimaryKey { get; set; }

    [Column("parent_id_elem")]
    [StringLength(64)]
    [Unicode(false)]
    public string? ParentIdElem { get; set; }

    [Column("spxml_form")]
    [StringLength(512)]
    [Unicode(false)]
    public string? SpxmlForm { get; set; }

    [Column("spxml_form_elem")]
    [StringLength(96)]
    [Unicode(false)]
    public string? SpxmlFormElem { get; set; }

    [Column("spxml_form_type")]
    public byte? SpxmlFormType { get; set; }

    [Column("single_tenant")]
    public byte? SingleTenant { get; set; }

    [Column("ft_idx")]
    public bool? FtIdx { get; set; }
}
