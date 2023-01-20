namespace Metoura.Core.Entities;

public class TourTourist : BaseEntity
{
    public Guid TourId { get; set; }

    public Tour Tour { get; set; }

    public Guid TouristId { get; set; }

    public Tourist Tourist { get; set; }

    public Guid PackageId { get; set; }

    public Package Package { get; set; }
}