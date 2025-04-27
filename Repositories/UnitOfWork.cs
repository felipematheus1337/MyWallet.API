
using MyWalletApi.Context;

namespace MyWalletApi.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IUsuarioRepository? _usuarioRepo;

    private ICarteiraRepository? _carteiraRepo;

    private ITransacaoRepository? _transacaoRepo;

    public AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IUsuarioRepository UsuarioRepository
    {
        get
        {
            return _usuarioRepo = _usuarioRepo ?? new UsuarioRepository(_context);
        }
    }

    public ICarteiraRepository CarteiraRepository
    {
        get
        {
            return _carteiraRepo = _carteiraRepo ?? new CarteiraRepository(_context);
        }
    }

    public ITransacaoRepository TransacaoRepository
    {
        get
        {
            return _transacaoRepo = _transacaoRepo ?? new TransacaoRepository(_context);
        }
    }


    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
