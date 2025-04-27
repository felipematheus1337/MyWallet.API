using Microsoft.EntityFrameworkCore;
using MyWalletApi.Domain;

namespace MyWalletApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Carteira>? Carteiras { get; set; }
    public DbSet<Transacao>? Transacao { get; set; }
}
