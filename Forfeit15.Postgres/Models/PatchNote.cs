using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Forfeit15.Postgres.Models.Nodes;

namespace Forfeit15.Postgres.Models;

[DataContract]
public class PatchNote
{
    /// <summary>
    /// Primary key
    /// </summary>
    [Key]
    [Required]
    [DataMember]
    public Guid Id { get; set; }

    [DataMember] 
    public string Title { get; set; } = null!;

    [DataMember]
    public string Description { get; set; } = null!;

    [DataMember] 
    public virtual ICollection<InfoNode> InfoNodes { get; set; } = null!;
}