namespace Entities;

public class ServiceStation
{
    public int Id { get; set; }
    public string StationName { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}