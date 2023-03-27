using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

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

    [DataMember] public string Title { get; set; } = null!;
}