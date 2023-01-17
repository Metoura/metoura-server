using Metoura.Core.Enums;

namespace Metoura.Core.Entities;

public class Review : BaseEntity
{
    public Guid UserId { get; set; }

    public User User { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; }

    public ReviewType ReviewType {get;set;}

    public Guid ReviewedId {get;set;}
}