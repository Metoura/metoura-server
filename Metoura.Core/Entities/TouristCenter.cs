namespace Metoura.Core.Entities;

public class TouristCenter : BaseEntity
{
    public string Title {get;set;}

    public string Description {get;set;}

    public Guid LocationId {get;set;}

    public Location Location {get;set;}

    public string ImagePath {get;set;}
}