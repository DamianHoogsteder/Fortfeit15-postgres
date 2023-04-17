using System.Runtime.Serialization;

namespace Forfeit15.Postgres.Models.Nodes;

[DataContract]
public class InfoNode : BaseInfoNode
{
    public Guid? PatchNoteId { get; set; }
}