namespace Metoura.Core.Entities;

public class Payment : BaseEntity
{
    public string ReferenceNumber { get; set; }

    public double Amount { get; set; }

    public DateTime PaymentDate { get; set; }

    public Guid TourId { get; set; }

    public Tour Tour { get; set; }

    public Guid TouristId { get; set; }

    public Tourist Tourist { get; set; }

    public string PaymentStatus { get; set; }
}