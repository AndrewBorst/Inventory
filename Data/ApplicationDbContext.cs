using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Additional configurations if needed
    }

}