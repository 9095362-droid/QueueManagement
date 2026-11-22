namespace Entities;

public class QueueTicket
{
    public int Id { get; set; }
    public int TicketNumber { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Waiting";

    public int UserId { get; set; }
    public User? User { get; set; }

    public int ServiceCategoryId { get; set; }
    public ServiceCategory? ServiceCategory { get; set; }

    public int? ServiceStationId { get; set; }
    public ServiceStation? ServiceStation { get; set; }
}