using MyWalletApi.Context;
using MyWalletApi.Domain;

namespace MyWalletApi.Repositories;

public class CarteiraRepository : Repository<Carteira>, ICarteiraRepository
{
    public CarteiraRepository(AppDbContext context) : base(context)
    {
    }
}
