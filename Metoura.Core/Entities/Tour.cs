namespace Metoura.Core.Entities;

public class Tour : BaseEntity
{
    public Guid UserId { get; set; }

    public User User { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}