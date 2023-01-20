namespace Metoura.Core.Entities;

public class TourCompany : BaseEntity
{
    public string CompanyName { get; set; }

    public Guid LocationId { get; set; }

    public Location Location { get; set; }

    public string Cac { get; set; }

    public bool isVerified { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; }
}