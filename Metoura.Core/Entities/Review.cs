namespace Metoura.Core.Entities;

public class Review : BaseEntity
{
    public Guid UserId { get; set; }

    public User User { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; }
}