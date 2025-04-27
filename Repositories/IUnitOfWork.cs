namespace MyWalletApi.Repositories;

public interface IUnitOfWork
{

    IUsuarioRepository UsuarioRepository { get; }
    ICarteiraRepository CarteiraRepository { get; }
    ITransacaoRepository TransacaoRepository { get; }

    Task Commit();
}
