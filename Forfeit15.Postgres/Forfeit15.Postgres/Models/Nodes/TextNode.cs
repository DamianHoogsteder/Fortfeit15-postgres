using System.Runtime.Serialization;

namespace Forfeit15.Postgres.Models.Nodes;

[DataContract]
public class TextNode : InfoNode
{
    [DataMember]
    public string Text { get; set; } = null!;
}