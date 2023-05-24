using System.Runtime.Serialization;

namespace Forfeit15.Postgres.Models.Nodes;

[DataContract]
public class ImageNode : InfoNode
{
    [DataMember]
    public string ImageUrl { get; set; } = null!;
}