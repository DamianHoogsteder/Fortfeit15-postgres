using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Forfeit15.Postgres.Models.Nodes;

[DataContract]
public abstract class BaseInfoNode
{
    [Key]
    [Required]
    [DataMember]
    public Guid Id { get; set; }

    [DataMember] 
    public string Title { get; set; } = null!;

    [DataMember] 
    public DateTime CreatedDate { get; set; }

    [DataMember] 
    public string NodeType { get; set; } = null!;
}