using Microsoft.EntityFrameworkCore;
using Api_Sport.Models;

namespace Api_Sport.Data;

public class Api_SportDbContext : DbContext
{
    public Api_SportDbContext(DbContextOptions<Api_SportDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}
