using MyWalletApi.Context;
using MyWalletApi.Domain;

namespace MyWalletApi.Repositories;

public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(AppDbContext context) : base(context)
    {
    }
}
