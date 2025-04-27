using MyWalletApi.Context;
using MyWalletApi.Domain;

namespace MyWalletApi.Repositories
{
    public class TransacaoRepository : Repository<Transacao>, ITransacaoRepository
    {
        public TransacaoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
