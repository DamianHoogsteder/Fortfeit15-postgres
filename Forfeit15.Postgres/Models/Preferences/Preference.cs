using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Forfeit15.Postgres.Models.Preferences;

[DataContract]
public class Preference
{
    [Key]
    [Required]
    [DataMember]
    public Guid Id { get; set; }
    
    [DataMember] 
    public Guid UserId { get; set; }

    [DataMember] 
    public string Content { get; set; } = null!;

    [DataMember] 
    public DateTime TimeStamp { get; set; }
}