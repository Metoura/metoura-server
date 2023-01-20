namespace Metoura.Core.Entities;

public class TourCategory : BaseEntity
{
    public Guid TourId { get; set; }

    public Tour Tour { get; set; }

    public Guid CategoryId { get; set; }

    public Category Category { get; set; }
}