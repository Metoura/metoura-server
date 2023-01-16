namespace Metoura.Core.Entities
{
    public class Package : BaseEntity
    {
        public double Price { get; set; }

        public Guid TourId { get; set; }

        public Tour Tour { get; set; }

        public string Name { get; set; }
    }
}