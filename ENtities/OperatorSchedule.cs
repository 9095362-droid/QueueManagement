namespace Entities;

public class OperatorSchedule
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

    public int ServiceStationId { get; set; }
    public ServiceStation? ServiceStation { get; set; }

    public DateTime ShiftStart { get; set; }
    public DateTime ShiftEnd { get; set; }
}