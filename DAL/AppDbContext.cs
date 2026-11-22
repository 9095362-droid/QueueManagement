using Microsoft.EntityFrameworkCore;
using Entities;

namespace DAL;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<ServiceCategory> ServiceCategories { get; set; }
    public DbSet<ServiceStation> ServiceStations { get; set; }
    public DbSet<QueueTicket> QueueTickets { get; set; }
    public DbSet<OperatorSchedule> OperatorSchedules { get; set; }
    public DbSet<Role> Roles { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString;

        if (Environment.UserName == "user1")
        {
            connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=QueueManagementDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }
        else
        {
            connectionString = "Server=SEMINAR_SERVER_NAME;Database=QueueManagementDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        optionsBuilder.UseSqlServer(connectionString);
    }
}